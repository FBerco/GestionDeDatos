using System;
using System.Collections.Generic;
using Clases;
using Helpers;
using System.Windows.Forms;

namespace GDD.Generar_Publicación
{
    /// <summary>
    /// Formulario en proceso, falta terminar
    /// </summary>
    public partial class frmAlta : Form
    {
        Publicacion publicacion;
        Usuario usuario;
        //Para alta
        public frmAlta(Usuario usuario)
        {
            InitializeComponent();
            btnConfirmar.Text = "Dar de alta";
        }

        //Para modificaciones
        public frmAlta(Usuario us,Publicacion publicacionSeleccionada)
        {
            InitializeComponent();
            usuario = us;
            btnConfirmar.Text = "Guardar cambios";
            publicacion = publicacionSeleccionada;
            CargarDatos();
        }

        private void CargarDatos() 
        {
            txtDescripcion.Text = publicacion.Descripcion;
            txtPrecio.Text = publicacion.Precio.ToString();
            txtStock.Text = publicacion.Stock.ToString();
            dtpFecha.Text = publicacion.FechaVencimiento.ToString();
            if (publicacion.Tipo == "Subasta")
            {
                rbtnSubasta.Focus();
            }
            else 
            {
                rbtnCompra.Focus();                
            }        
        }
          
        private void Alta_Load(object sender, EventArgs e)
        {
            cmbRubro.DataSource = DBHelper.ExecuteReader("Rubro_GetAll").ToRubros();
            cmbRubro.DisplayMember = "DescripcionCorta";
            
            cmbVisibilidad.DataSource = DBHelper.ExecuteReader("Visibilidad_GetAll").ToVisibilidades();
            cmbVisibilidad.DisplayMember = "Detalle";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var tipo = rbtnCompra.Checked ? "Compra Inmediata" : "Subasta";
            var descripcion = txtDescripcion.Text;
            var precio = Convert.ToDecimal(txtPrecio.Text);
            var stock = Convert.ToInt32(txtStock.Text);
            var fecha = dtpFecha.Value;
            var estado = rbtnActiva.Checked ? "Activa" : "Borrador";
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
