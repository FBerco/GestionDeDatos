using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Clases;
using Helpers;
using System.Windows.Forms;

namespace GDD.Generar_Publicación
{
    public partial class Alta : Form
    {
        int id;
        public Alta(Publicacion publicacionSeleccionada) {
            InitializeComponent();
            CargarDatos(publicacionSeleccionada);
            id = publicacionSeleccionada.Id;
            gbPublicacion.Enabled = false;
            gbEstado.Enabled = false;
           
        }
        
        public Alta()
        {
            InitializeComponent();
        }

        private void CargarDatos(Publicacion publicacion) 
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

        private void lstVisibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Alta_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var descripcion = txtDescripcion.Text;
            var precio = txtPrecio.Text;
            var stock = txtStock.Text;
            var fechaVencimiento = dtpFecha.Value;
            //List<string> rubros = 
            var tipoPublicacion = "";
            foreach(Control ctrl in gbPublicacion.Controls)
            {
                if(ctrl is RadioButton)
                {
                    RadioButton radio = ctrl as RadioButton;
                    if(radio.Checked)
                    {
                        tipoPublicacion = radio.Text;
                    }
                    else
                    {
                       MessageBox.Show("Seleccionar tipo de publicacion");     
                    }
                }
            }
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@Descripcion", descripcion);
            parametros.Add("@Precio", precio);
            parametros.Add("@Stock", stock);
            parametros.Add("@FechaVencimiento", fechaVencimiento);
            //faltan agregar mas parametros           
            DBHelper.ExecuteNonQuery("Publicacion_Insertar", parametros);
            MessageBox.Show("Se ha cargado la publicacion");
        }

  

        

     

     

        

        
    }
}
