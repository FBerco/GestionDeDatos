using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using Helpers;


namespace GDD.ABM_Visibilidad
{
    public partial class frmAlta : Form
    {
        



        public frmAlta()
        {
            InitializeComponent();
            
        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            
        }
        
  
        private void btnGuardarNuevaVisibilidad_Click(object sender, EventArgs e)
        {
            if (textBoxesValidos())
            {
                Visibilidad nuevaVisibilidad = new Visibilidad();
                nuevaVisibilidad.Detalle = txtNombreVisibilidad.Text;
                nuevaVisibilidad.CostoPublicacion = System.Int32.Parse(txtComisionTipoPublicacion.Text);
                nuevaVisibilidad.PorcentajeProducto = System.Int32.Parse(txtComsionProductoVendido.Text);
                if (txtComisionEnvioProducto.Enabled)
                {
                    nuevaVisibilidad.CostoEnvio = System.Int32.Parse(txtComisionEnvioProducto.Text);
                }
                else
                {
                    nuevaVisibilidad.CostoEnvio = 0;
                }
                guardarVisibilidad(nuevaVisibilidad);
                btnGuardarNuevaVisibilidad.Enabled = false;
            }   //else { MessageBox.Show("Ingrese campos validos."); }      
        }

       
        #region validaciones
        private Boolean textBoxesValidos() 
        {
            if (nadaNulo()) { return nadaNegativo() && ingresadosTipoDeTextoCorrectamente(); } else { return false; }
        }
        
        private Boolean nadaNulo()
        {
            return  !String.IsNullOrEmpty(txtNombreVisibilidad.Text) &&
                    !String.IsNullOrEmpty(txtComsionProductoVendido.Text) &&
                    !String.IsNullOrEmpty(txtComisionTipoPublicacion.Text) &&
                    siHayEnvioNoEsNulo();
        }

        private Boolean siHayEnvioNoEsNulo()
        {
            if (txtComisionEnvioProducto.Enabled) { return !String.IsNullOrEmpty(txtComisionEnvioProducto.Text); }
        else {return true;}
        }

        private Boolean nadaNegativo()
        {
            return
            System.Int32.Parse(txtComsionProductoVendido.Text) > 0 &&
            System.Int32.Parse(txtComisionTipoPublicacion.Text) > 0 &&
            siHayEnvioNoEsNegativo();
        }

        private Boolean siHayEnvioNoEsNegativo()
        {
            if (txtComisionEnvioProducto.Enabled) { return System.Int32.Parse(txtComisionEnvioProducto.Text) > 0 ; }
            else { return true; }
        }

        private Boolean ingresadosTipoDeTextoCorrectamente() {
            return nombreVisibilidadValido() ;//&& porcentajeNoMayorAl100();
        }

        private Boolean nombreVisibilidadValido() { return txtNombreVisibilidad.TextLength <= 20; }

        //private Boolean porcentajeNoMayorAl100() { return System.Int32.Parse(txtComsionProductoVendido.Text); }
        
        
        
        
        #endregion

        private void guardarVisibilidad(Visibilidad unaVisibilidad)
        { 
            Dictionary<String,Object> nuevoDiccionario = new Dictionary<String,Object>();
            nuevoDiccionario.Add("@visi_detalle",unaVisibilidad.Detalle);
            nuevoDiccionario.Add("@visi_porcentaje_prod", unaVisibilidad.PorcentajeProducto);
            nuevoDiccionario.Add("@visi_costo_publicacion", unaVisibilidad.CostoPublicacion);
            nuevoDiccionario.Add("@visi_costo_envio", unaVisibilidad.CostoEnvio);
            DBHelper.ExecuteNonQuery("Visibilidad_Alta", nuevoDiccionario);
        }
        
        
        
        private void chbTieneEnvio_CheckedChanged(object sender, EventArgs e)
        {
            btnGuardarNuevaVisibilidad.Enabled = true;
            txtComisionEnvioProducto.Enabled = true;                
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtComisionEnvioProducto.Clear();
            txtComisionTipoPublicacion.Clear();
            txtNombreVisibilidad.Clear();
            txtComsionProductoVendido.Clear();
            chbTieneEnvio.Checked = false;
            txtComisionEnvioProducto.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        private void txtComisionTipoPublicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtComsionProductoVendido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtComisionEnvioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreVisibilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        
    }   
}
