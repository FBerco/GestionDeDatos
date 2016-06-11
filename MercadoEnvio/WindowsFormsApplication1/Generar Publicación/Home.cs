using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Helpers;

using System.Windows.Forms;

namespace GDD.Generar_Publicación
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

    

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Form alta = new Generar_Publicación.Alta();
            alta.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form alta = new Generar_Publicación.Alta(/*pasar public seleccionada*/);
            alta.Show();
            this.Close();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            //activar la publicacion seleccionada
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            //pausar la publicacion seleccionada
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //finalizar la publicacion seleccionada
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

            var estadoSeleccionado = cmbEstado.Text;
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@EstadoPublicacion", estadoSeleccionado);            
            var publicacion = DBHelper.ExecuteReader("Publicacion_GetByFilter", parametros);
            //publicacion es un sqldatareader, tengo que parsearlo a una lista
            if (publicacion != null)
            {
                //dgvPublicaciones.DataSource = 
            }
            else
            {  
               var texto = string.Format("No hay publicaciones en estado {0}", estadoSeleccionado);
               lblError.Text = texto;      
            }
            switch (estadoSeleccionado) 
            {
                case "Borrador":
                    btnModificar.Enabled = true;
                    btnActivar.Enabled = true;
                    btnPausar.Enabled = false;
                    btnFinalizar.Enabled = false;
                    break;
                case "Activa":
                    btnModificar.Enabled = false;
                    btnActivar.Enabled = false;
                    btnPausar.Enabled = true;
                    btnFinalizar.Enabled = true; //habria que ver si es subasta, compra inm
                    break;
                case "Pausada":
                    btnModificar.Enabled = false;
                    btnActivar.Enabled = true;
                    btnPausar.Enabled = false;
                    btnFinalizar.Enabled = false;
                    break;
                case "Finalizada":
                    btnModificar.Enabled = false;
                    btnActivar.Enabled = false;
                    btnPausar.Enabled = false;
                    btnFinalizar.Enabled = false;
                    break;
            }
        }

      

        

    }
    
}
