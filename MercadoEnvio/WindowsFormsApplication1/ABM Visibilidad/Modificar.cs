using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Helpers;
using Clases;

namespace GDD.ABM_Visibilidad
{
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }


        private void cmbNombreVisibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             //llenarLosCamposRestantesSegun(nombreVisibilidad);
        }

        private void llenarLosCamposRestantesSegun(String nombreVisibilidad)
        {
            //txtComisionXTipoPublicacion = DBHelper.ExecuteReader("obtener comision X tipo publicacion");
            //txtComisionXProductoVendido = DBHelper.ExecuteReader("obtener comision X producto vendido");
            //txtComisionXEnvioProducto = DBHelper.ExecuteReader("obtener comision X envio producto");
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            List<Visibilidad> visibilidades = DBHelper.ExecuteReader("Visibilidad_GetAll").ToVisibilidades();
            foreach (var visibilidad in visibilidades)
            {
                cmbNombreVisibilidad.Items.Add(visibilidad.Detalle);
            }
            
        }

        private void txtComisionXTipoPublicacion_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
        
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            //FALTAN HACER LAS VALIDACIONES
            
            Dictionary<String, Object> mod = new Dictionary<String, Object>();
            mod.Add("@visi_detalle_mod", cmbNombreVisibilidad.SelectedItem.ToString());
            mod.Add("@visi_porcentaje_prod", txtComisionXProductoVendido.Text);
            mod.Add("@visi_costo_publicacion", txtComisionXTipoPublicacion.Text);
            mod.Add("@visi_costo_envio", txtComisionXEnvioProducto.Text);
            DBHelper.ExecuteNonQuery("Visibilidad_Update", mod);
            btnGuardarCambios.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtComisionXEnvioProducto.Clear();
            txtComisionXProductoVendido.Clear();
            txtComisionXTipoPublicacion.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }
    }
}
