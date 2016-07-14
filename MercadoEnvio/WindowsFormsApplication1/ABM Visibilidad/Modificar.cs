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

        private Visibilidad visibilidadAModificar;
        
        private void frmModificar_Load(object sender, EventArgs e)
        {
            btnGuardarCambios.Enabled = false;
            chbTieneEnvio.Enabled = false;
            txtComisionXProductoVendido.Enabled = false;
            txtComisionXTipoPublicacion.Enabled = false;
            txtComisionXEnvioProducto.Enabled = false;
            List<Visibilidad> visibilidades = DBHelper.ExecuteReader("Visibilidad_GetAll").ToVisibilidades();
            foreach (var visibilidad in visibilidades)
            {
                cmbNombreVisibilidad.Items.Add(visibilidad.Detalle);
            }
        }

        #region Funciones principales
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {        
            if(textBoxesValidos())
            { 
                Dictionary<String, Object> mod = new Dictionary<String, Object>();
                mod.Add("@visi_detalle_mod", cmbNombreVisibilidad.SelectedItem.ToString());
                mod.Add("@visi_porcentaje_prod", txtComisionXProductoVendido.Text);
                mod.Add("@visi_costo_publicacion", txtComisionXTipoPublicacion.Text);
                mod.Add("@visi_costo_envio", txtComisionXEnvioProducto.Text);
                DBHelper.ExecuteNonQuery("Visibilidad_Update", mod);
                btnGuardarCambios.Enabled = false;
                txtComisionXEnvioProducto.Enabled = false;
                txtComisionXTipoPublicacion.Enabled = false;
                txtComisionXProductoVendido.Enabled = false;
                chbTieneEnvio.Enabled = false;
                MessageBox.Show("Visibilidad modificada exitosamente!");
            }else { MessageBox.Show("Ingrese campos validos."); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnGuardarCambios.Enabled = false;
            txtComisionXEnvioProducto.Clear();
            txtComisionXProductoVendido.Clear();
            txtComisionXTipoPublicacion.Clear();
            cmbNombreVisibilidad.Enabled = true;
            btnOKVisibilidad.Enabled = true;
            txtComisionXProductoVendido.Enabled = false;
            txtComisionXTipoPublicacion.Enabled = false;
            chbTieneEnvio.Enabled = false;
            chbTieneEnvio.CheckState = CheckState.Unchecked;
            txtComisionXEnvioProducto.Enabled = false;
        }
        #endregion

        #region Extras
 
            #region Validaciones

                private Boolean textBoxesValidos()
                {
                    return porcentajeNoMayorA100();
                }

                private Boolean porcentajeNoMayorA100() 
                {
                    if (!String.IsNullOrEmpty(txtComisionXProductoVendido.Text))
                    {
                        return System.Int32.Parse(txtComisionXProductoVendido.Text) <= 100;
                    }
                    else return true;
                }

                    #region Solo numeros donde deberia haber numeros
                        private void txtComisionXTipoPublicacion_KeyPress(object sender, KeyPressEventArgs e)
                        {
                            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                            {
                                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                e.Handled = true;
                                return;
                            }
                        }

                        private void txtComisionXProductoVendido_KeyPress(object sender, KeyPressEventArgs e)
                        {
                            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                            {
                                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                e.Handled = true;
                                return;
                            }
                        }

                        private void txtComisionXEnvioProducto_KeyPress(object sender, KeyPressEventArgs e)
                        {
                            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                            {
                                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                e.Handled = true;
                                return;
                            }
                        }
                    #endregion
        
            #endregion

            #region Botones
            private void btnBack_Click(object sender, EventArgs e)
            {
                frmHome home = new frmHome();
                home.Show();
                this.Hide();
            }

            private void btnOKVisibilidad_Click(object sender, EventArgs e)
            {
                btnGuardarCambios.Enabled = true;
                txtComisionXProductoVendido.Enabled = true;
                txtComisionXTipoPublicacion.Enabled = true;
                chbTieneEnvio.Enabled = true;
                btnOKVisibilidad.Enabled = false;
                cmbNombreVisibilidad.Enabled = false;
                llenarTextBoxesConValoresAnteriores();            
            }
            #endregion

            private void chbTieneEnvio_CheckedChanged(object sender, EventArgs e)
            {
                if (txtComisionXEnvioProducto.Enabled) { txtComisionXEnvioProducto.Enabled = false; }
                else { txtComisionXEnvioProducto.Enabled = true; }
            }

            private Visibilidad getVisibilidadAModificar() 
            {
                var diccionario = new Dictionary<String, Object>();
                diccionario.Add("@visiDetalle", cmbNombreVisibilidad.SelectedItem.ToString());
                return DBHelper.ExecuteReader("Visibilidad_GetVisibilidadSegunDetalle", diccionario).ToVisibilidad();
            }

            private void llenarTextBoxesConValoresAnteriores() 
            {
                visibilidadAModificar = getVisibilidadAModificar();
                txtComisionXTipoPublicacion.Text = visibilidadAModificar.CostoPublicacion.ToString();
                txtComisionXProductoVendido.Text = visibilidadAModificar.PorcentajeProducto.ToString();
                txtComisionXEnvioProducto.Text = visibilidadAModificar.CostoEnvio.ToString();
            }
        #endregion

    }
}
