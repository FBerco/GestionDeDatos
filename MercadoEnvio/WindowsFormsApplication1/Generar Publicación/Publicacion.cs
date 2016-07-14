using System;
using System.Linq;
using System.Collections.Generic;
using Clases;
using Helpers;
using System.Windows.Forms;
using System.Text;
using System.Globalization;
using System.Configuration;

namespace GDD.Generar_Publicación
{
    /// <summary>
    /// Formulario en proceso, falta terminar
    /// </summary>
    public partial class frmPublicacion : Form
    {
        private Publicacion publicacion = null;
        private Usuario usuario;
        private List<Rubro> rubros;
        private List<Visibilidad> visibilidades;
        private DateTime fecha = DateTime.Parse(ConfigurationManager.AppSettings["fecha"]);
        //Para alta
        public frmPublicacion(Usuario us)
        {
            InitializeComponent();
            usuario = us;
            btnConfirmar.Text = "Dar de alta";
            CargarRubrosYVisibilidades();
            rdbFinalizada.Enabled = false;
            rdbPausada.Enabled = false;
            rdbActiva.Checked = true;
            dtpFecha.CustomFormat = "yyyy-M-d HH:mm:ss";
            dtpFecha.Format = DateTimePickerFormat.Custom;
        }

        //Para modificaciones
        public frmPublicacion(Usuario us,Publicacion publicacionSeleccionada)
        {
            InitializeComponent();
            usuario = us;
            publicacion = publicacionSeleccionada;
            btnConfirmar.Text = "Guardar cambios";            
            CargarDatos();
        }

        private void CargarRubrosYVisibilidades() {
            visibilidades = DBHelper.ExecuteReader("Visibilidad_GetAll").ToVisibilidades();
            var gratis = visibilidades.First(x => x.Detalle == "Gratis");
            //Me fijo si tiene publicaciones
            //No muestro visibilidad gratis si no tiene permitido
            if (DBHelper.ExecuteReader("Publicacion_GetByUsername", new Dictionary<string, object>() { { "@Username", usuario.Username } }).ToPublicaciones().Count != 0)
            {
                visibilidades.Remove(gratis);
            }
            cmbVisibilidad.DataSource = visibilidades;
            cmbVisibilidad.DisplayMember = "Detalle";            
            cmbRubro.DataSource = rubros = DBHelper.ExecuteReader("Rubro_GetAll").ToRubros();
            cmbRubro.DisplayMember = "DescripcionCorta";
        }

        private void CargarDatos() 
        {
            CargarRubrosYVisibilidades();
            if (publicacion.Tipo == "Subasta")
            {
                rdbSubasta.Checked = true;
            }
            else
            {
                rdbCompra.Checked = true;
            }
            fecha = publicacion.FechaInicio;
            txtDescripcion.Text = publicacion.Descripcion;
            txtPrecio.Text = publicacion.Precio.ToString("0.00");
            txtStock.Text = publicacion.Stock.ToString();
            dtpFecha.CustomFormat = "yyyy-M-d HH:mm:ss";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Value = publicacion.FechaVencimiento;
            switch (publicacion.Estado)
            {
                case 1:
                    rdbActiva.Checked = true;
                    rdbBorrador.Enabled = false;
                    break;
                case 2:
                    rdbPausada.Checked = true;
                    rdbFinalizada.Enabled = false;
                    rdbBorrador.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtStock.Enabled = false;
                    dtpFecha.Enabled = false;
                    rdbCompra.Enabled = false;
                    rdbSubasta.Enabled = false;
                    cmbRubro.Enabled = false;
                    cmbVisibilidad.Enabled = false;
                    break;
                case 3:
                    rdbFinalizada.Checked = true;
                    rdbPausada.Enabled = false;
                    rdbBorrador.Enabled = false;
                    rdbActiva.Enabled = false;
                    break;
                case 4:
                    rdbBorrador.Checked = true;
                    rdbPausada.Enabled = false;
                    rdbFinalizada.Enabled = false;
                    break;
            }
            cmbVisibilidad.SelectedItem = visibilidades.First(x => x.Id == publicacion.VisibilidadId);
            cmbRubro.SelectedItem = rubros.First(x => x.Id == publicacion.Rubro);
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStock.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Campo Stock y Precio no pueden estar vacios");
                return;
            }
            var stock = Convert.ToInt32(txtStock.Text);
            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, NumberStyles.Currency, new CultureInfo("es-AR"), out precio))
            {
                MessageBox.Show("Ingrese un numero correcto. No es un numero de tipo decimal");
                return;
            }
            //Cuento el punto mas los decimales
            else if (txtPrecio.Text.Contains(",") && txtPrecio.Text.Substring(txtPrecio.Text.IndexOf(',')).Length > 3) {
                MessageBox.Show("Ingrese un precio con dos decimales por favor.");
                return;
            }
            else if (precio < 1)
            {
                MessageBox.Show("Precio debe ser mayor o igual a $1");
            }
            if (stock < 1)
            {
                MessageBox.Show("Stock debe ser mayor o igual a 1");
            }

            int estado = 4;
            if (rdbActiva.Checked)
            {
                estado = 1;
            }
            else if (rdbPausada.Checked)
            {
                estado = 2;
            }
            else if (rdbFinalizada.Checked)
            {
                estado = 3;
            }
            if (dtpFecha.Value <= fecha)
            {
                MessageBox.Show("La fecha de vencimiento tiene que se mayor a la fecha de inicio seteada en el sistema.");
                return;
            }
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "@tipo", rdbCompra.Checked ? "Compra Inmediata" : "Subasta" },
                { "@fechaInicio", fecha},
                { "@fechaVencimiento", dtpFecha.Value},
                { "@descripcion", txtDescripcion.Text},
                { "@rubro", ((Rubro)cmbRubro.SelectedItem).Id},
                { "@estado", estado},
                { "@stock", stock},
                { "@precio", precio},
                { "@visibilidad", ((Visibilidad)cmbVisibilidad.SelectedItem).Id}
            };
            
            //Alta
            if (publicacion == null)
            {
                parametros.Add("@username", usuario.Username);
                DBHelper.ExecuteNonQuery("Publicacion_Add", parametros);
                publicacion = DBHelper.ExecuteReader("Publicacion_GetLast").ToPublicacion();
                MessageBox.Show("Insertado con exito");
            }
            else
            {
                parametros.Add("@id", publicacion.Id);
                DBHelper.ExecuteNonQuery("Publicacion_Modify", parametros);
                MessageBox.Show("Modificado con exito con exito");
            }
            //Genero factura
            if (estado == 1 && DBHelper.ExecuteReader("Factura_GetByPublicacion", new Dictionary<string, object>() { { "@publicacion", publicacion.Id }}).ToFactura() == null) {
                GenerarFacturar((Visibilidad)cmbVisibilidad.SelectedItem);
            }

            LoadHome();
        }

        private void LoadHome() {
            frmHome home = new frmHome(usuario);
            home.Show();
            Hide();
        }

        private void GenerarFacturar(Visibilidad visi)
        {
            List<ItemFactura> items = new List<ItemFactura>() {
                //Item por porcentaje
                new ItemFactura() {
                    Cantidad = 0,
                    PrecioUnitario =  Convert.ToDecimal(txtPrecio.Text) * visi.PorcentajeProducto,
                    Detalle = "ItemPorcentaje"
                },
                //Costo publicacion
                new ItemFactura() {
                    Cantidad = 1,
                    PrecioUnitario =  visi.CostoPublicacion,
                    Detalle = "CostoPublicacion"
                },
                //Costo envio
                new ItemFactura() {
                    Cantidad = 0,
                    PrecioUnitario =  visi.CostoEnvio,
                    Detalle = "CostoEnvio"
                },
            };
            var fechaString = fecha.ToString("dd/MM/yyyy HH:mm:ss");
            DBHelper.ExecuteNonQuery("Factura_Add", new Dictionary<string, object>() { { "@fecha", fechaString }, { "@total", Convert.ToDecimal(items.Sum(x => x.PrecioUnitario * x.Cantidad))}, { "@publicacion", publicacion.Id } });
            var factura = DBHelper.ExecuteReader("Factura_GetLast").ToFactura();
            foreach (var item in items)
            {
                DBHelper.ExecuteNonQuery("ItemFactura_Add", new Dictionary<string, object> { {"@factura", factura.Numero }, {"@cantidad", item.Cantidad }, { "@precio", item.PrecioUnitario }, { "@detalle", item.Detalle} });
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Factura ID:" + factura.Numero);
            sb.AppendLine("Total: $" + factura.Total);
            sb.AppendLine();
            sb.AppendLine("Comision tipo producto: $" + Convert.ToDouble(Convert.ToDecimal(txtPrecio.Text) * visi.PorcentajeProducto).ToString());
            sb.AppendLine("Costo publicacion: $" + visi.CostoPublicacion);
            sb.AppendLine("Costo envio: $" + visi.CostoEnvio);
            MessageBox.Show(sb.ToString());
        }
                
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') )
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
        }
    }
}
