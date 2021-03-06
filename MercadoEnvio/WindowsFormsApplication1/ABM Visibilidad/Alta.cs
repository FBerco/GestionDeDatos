﻿using System;
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
                int costoPublicacion, porcentajeProducto;
                if (String.IsNullOrEmpty(txtComisionTipoPublicacion.Text)) { costoPublicacion = 0; }
                    else { costoPublicacion = System.Int32.Parse(txtComisionTipoPublicacion.Text); }
                if (String.IsNullOrEmpty(txtComsionProductoVendido.Text)) { porcentajeProducto = 0; }
                    else { porcentajeProducto = System.Int32.Parse(txtComsionProductoVendido.Text); }
                nuevaVisibilidad.Detalle = txtNombreVisibilidad.Text;
                nuevaVisibilidad.CostoPublicacion = costoPublicacion;
                nuevaVisibilidad.PorcentajeProducto = porcentajeProducto;
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
                MessageBox.Show("Visiblidad guardada exitosamente!", "Exito :D");
            }   else { MessageBox.Show("Ingrese campos validos."); }      
        }

       
        #region validaciones
        private Boolean textBoxesValidos() 
        {
            return porcentajeNoMayorAl100() ;
        }

        private Boolean porcentajeNoMayorAl100()
        {
            if (!String.IsNullOrEmpty(txtComsionProductoVendido.Text))
            {
                return System.Int32.Parse(txtComsionProductoVendido.Text) <= 100;
            }
            else return true;
        }

            #region Solo se ingresan los tipos de datos correctos en los textboxes
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
            #endregion

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
            btnGuardarNuevaVisibilidad.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        
     }   
}
