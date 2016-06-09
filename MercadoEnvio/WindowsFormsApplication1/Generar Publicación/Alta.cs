using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace GDD.Generar_Publicación
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
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
        }

  

        

     

     

        

        
    }
}
