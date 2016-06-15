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
        }

        private void llenarLosCamposRestantesSegun(String nombreVisibilidad)
        {
            //txtComisionXTipoPublicacion = DBHelper.ExecuteReader("obtener comision X tipo publicacion");
            //txtComisionXProductoVendido = DBHelper.ExecuteReader("obtener comision X producto vendido");
            //txtComisionXEnvioProducto = DBHelper.ExecuteReader("obtener comision X envio producto");
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            txtComisionXEnvioProducto.Enabled = false;
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
           if(textBoxesValidos()){ 
            Dictionary<String, Object> mod = new Dictionary<String, Object>();
            mod.Add("@visi_detalle_mod", cmbNombreVisibilidad.SelectedItem.ToString());
            mod.Add("@visi_porcentaje_prod", txtComisionXProductoVendido.Text);
            mod.Add("@visi_costo_publicacion", txtComisionXTipoPublicacion.Text);
            mod.Add("@visi_costo_envio", txtComisionXEnvioProducto.Text);
            DBHelper.ExecuteNonQuery("Visibilidad_Update", mod);
            btnGuardarCambios.Enabled = false;
           }else { MessageBox.Show("Ingrese campos validos."); }
        }


        #region Validaciones
        private Boolean textBoxesValidos()
        {
            if (nadaNulo()) { return nadaNegativo() && ingresadosTipoDeTextoCorrectamente(); }
            else { return false; }
        }

        private Boolean nadaNulo()
        {
            return  !String.IsNullOrEmpty(txtComisionXProductoVendido.Text) &&
                    !String.IsNullOrEmpty(txtComisionXTipoPublicacion.Text) &&
                    siHayEnvioNoEsNulo();
        }

        private Boolean siHayEnvioNoEsNulo()
        {
            if (txtComisionXEnvioProducto.Enabled) { return !String.IsNullOrEmpty(txtComisionXEnvioProducto.Text); }
            else { return true; }
        }

        private Boolean nadaNegativo()
        {
            return
            System.Int32.Parse(txtComisionXProductoVendido.Text) > 0 &&
            System.Int32.Parse(txtComisionXTipoPublicacion.Text) > 0 &&
            siHayEnvioNoEsNegativo();
        }

        private Boolean siHayEnvioNoEsNegativo()
        {
            if (txtComisionXEnvioProducto.Enabled) { return System.Int32.Parse(txtComisionXEnvioProducto.Text) > 0; }
            else { return true; }
        }

        private Boolean ingresadosTipoDeTextoCorrectamente()
        {
            return comisionProductoVendididoValida() && comisionTipoPublicacionValida() && siHayEnvioEsValido();
        }

        private Boolean comisionProductoVendididoValida() { return tieneSoloNumeros(); }
        private Boolean comisionTipoPublicacionValida() { return tieneSoloNumeros(); }
        private Boolean siHayEnvioEsValido() { if (txtComisionXEnvioProducto.Enabled) { return tieneSoloNumeros(); } else { return true; } }
        private Boolean tieneSoloTexto() { return true; } //No se como se valida esto
        private Boolean tieneSoloNumeros() { return true; } //No se como se valida esto
        
        #endregion

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

        private void chbTieneEnvio_CheckedChanged(object sender, EventArgs e)
        {
            if(txtComisionXEnvioProducto.Enabled) {txtComisionXEnvioProducto.Enabled = false;}
            else { txtComisionXEnvioProducto.Enabled = true; }
        }
    }
}
