using System;
using System.Linq;
using System.Collections.Generic;
using Clases;
using Helpers;
using System.Windows.Forms;

namespace GDD.Generar_Publicación
{
    /// <summary>
    /// Formulario en proceso, falta terminar
    /// </summary>
    public partial class frmPublicacion : Form
    {
        private Publicacion publicacion;
        private Usuario usuario;
        private List<Rubro> rubros;
        private List<Visibilidad> visibilidades;
        //Para alta
        public frmPublicacion(Usuario usuario)
        {
            InitializeComponent();
            btnConfirmar.Text = "Dar de alta";
            CargarDatos();
        }

        //Para modificaciones
        public frmPublicacion(Usuario us,Publicacion publicacionSeleccionada)
        {
            InitializeComponent();
            usuario = us;
            btnConfirmar.Text = "Guardar cambios";
            publicacion = publicacionSeleccionada;
            
            CargarDatos();
        }

        private void CargarRubrosYVisibilidades() {            
            cmbVisibilidad.DataSource = visibilidades = DBHelper.ExecuteReader("Visibilidad_GetAll").ToVisibilidades();
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
            txtDescripcion.Text = publicacion.Descripcion;
            txtPrecio.Text = publicacion.Precio.ToString();
            txtStock.Text = publicacion.Stock.ToString();
            dtpFecha.CustomFormat = "yyyy-M-d HH:mm:ss";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Value = publicacion.FechaVencimiento;
            switch (publicacion.Estado)
            {
                case 1:
                    rdbActiva.Checked = true;
                    break;
                case 2:
                    rdbPausada.Checked = true;
                    break;
                case 3:
                    rdbFinalizada.Checked = true;
                    break;
                case 4:
                    rdbBorrador.Checked = true;
                    break;
            }
            cmbVisibilidad.SelectedItem = visibilidades.First(x => x.Id == publicacion.VisibilidadId);
            cmbRubro.SelectedItem = rubros.First(x => x.Id == publicacion.Rubro);
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var tipo = rdbCompra.Checked ? "Compra Inmediata" : "Subasta";
            var descripcion = txtDescripcion.Text;
            var precio = Convert.ToDecimal(txtPrecio.Text);
            var stock = Convert.ToInt32(txtStock.Text);
            var fecha = dtpFecha.Value;
            var estado = rdbActiva.Checked ? "Activa" : "Borrador";
            var visibilidad = (Visibilidad)cmbVisibilidad.SelectedItem;
            var rubro = (Rubro)cmbRubro.SelectedItem;
                
           
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            
            parametros.Add("@tipo", tipo);
            parametros.Add("@fechaVencimiento", descripcion);
            parametros.Add("@descripcion", precio);
            parametros.Add("@rubroId", stock);
            parametros.Add("@estadoId", fecha);           
            parametros.Add("@stock", estado);
            parametros.Add("@precio", visibilidad);
            parametros.Add("@visibilidadId", rubro);
            //Ver casos de los que no son ni cliente ni empresa. ej: administrador
            parametros.Add("@usuario", usuario.Username);
      

            //FALTA TERMINAR

            //DBHelper.ExecuteNonQuery("Publicacion_Insert", parametros);
            //MessageBox.Show("Se ha cargado la publicacion");
            //Limpiar();

        }

        //private void Limpiar()
        //{
        //    txtDescripcion.Text = "";
        //    txtPrecio.Text = "";
        //    txtStock.Text = "";
        //    rbtnActiva.Checked = false;
        //    rbtnSubasta.Checked = false;
        //    rbtnCompra.Checked = false;
        //    rbtnBorrador.Checked = false;
        //}

        private void frmAlta_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome home = new frmHome(usuario);
            home.Show();
            Hide();
        }
    }
}
