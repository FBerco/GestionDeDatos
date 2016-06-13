using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
             //String nombreVisibilidad = cmbNombreVisibilidad.SelectedValue;
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
            //var visibilidades = DBHelper.ExecuteReader("nombre de visibilidades");
            //cmbNombreVisibilidad.Items = visibilidades;
        }

        private void txtComisionXTipoPublicacion_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e){
        
        }
        
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            /*String nuevaComisionXTipoPublicacion = txtComisionXEnvioProducto.Text;
            String nuevaComisionXProductoVendido = txtComisionXProductoVendido.Text;
            String nuevaComisionXEnvioDeProducto = txtComisionXEnvioProducto.Text;
            Dictionary<String,String> modificaciones;            
            modificaciones.Add("comisionXTipoPublicacion",nuevaComisionXTipoPublicacion);
            modificaciones.Add("comisionXProductoVendido",nuevaComisionXProductoVendido);
            modificaciones.Add("comisinoXEnvioDeProducto",nuevaComisionXEnvioDeProducto);
            DBHelper.ExecuteNonQuery("guardarcambios",modificaciones);*/
        }
    }
}
