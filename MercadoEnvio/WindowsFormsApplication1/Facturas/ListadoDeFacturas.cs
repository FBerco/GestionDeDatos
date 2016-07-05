﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Clases;
using Helpers;

using System.Windows.Forms;

namespace GDD.Facturas
{
    public partial class frmListadoDeFacturas : Form
    {
        #region Atributos
        
        private List<Usuario>   listaDeUsuariosVendedores;
        private List<Factura>   todasLasFacturasDelUsuarioVendedor;
        private String          vendedorSeleccionado;
        private List<Factura>   facturasFiltradas;


        #endregion
        
        public frmListadoDeFacturas()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
           deshabilitarFiltros();
           btnListarFacturas.Enabled = false;
           btnOKFiltros.Enabled = false;
           btnOKListarPor.Enabled = false;
           deshabilitarListarPor();
           listaDeUsuariosVendedores = DBHelper.ExecuteReader("Usuario_GetVendedores").ToUsuarios();
           foreach (var usuario in listaDeUsuariosVendedores)
           {
               cmbUsuarioVendedor.Items.Add(usuario.Username);
           }
           
        }

        #region Funciones Principales

            private void btnListarFacturas_Click(object sender, EventArgs e)
            {
                if (chbComisionPublicacion.Checked)
                {
                    Dictionary<String, Object> diccionario = new Dictionary<string, object>();
                    diccionario.Add("@vendedorID", vendedorSeleccionado);
                    todasLasFacturasDelUsuarioVendedor = DBHelper.ExecuteReader("Factura_GetFacturaSegunVendedorYCliente_OrderByCostoPublicacion", diccionario).ToFacturas();
                }
                else 
                {
                    if (chbVentas.Checked)
                    {
                        Dictionary<String, Object> diccionario = new Dictionary<string, object>();
                        diccionario.Add("@vendedorID", vendedorSeleccionado);
                        todasLasFacturasDelUsuarioVendedor = DBHelper.ExecuteReader("Factura_GetFacturaSegunVendedorYCliente_OrderByPorcentajeProducto", diccionario).ToFacturas();
                    }
                    else
                    {
                        Dictionary<String, Object> diccionario = new Dictionary<string, object>();
                        diccionario.Add("@vendedorID", vendedorSeleccionado);
                        todasLasFacturasDelUsuarioVendedor = DBHelper.ExecuteReader("Factura_GetFacturaSegunVendedorYCliente_OrderByCostoEnvio", diccionario).ToFacturas();
                    }  
                 
                }
                facturasFiltradas = filtrarFacturas();            
                foreach (var factura in facturasFiltradas)
                {
                    ListViewItem lista = new ListViewItem(factura.Numero.ToString());
                    lista.SubItems.Add(factura.Fecha.ToString());
                    lista.SubItems.Add(factura.Total.ToString());
                    lista.SubItems.Add(factura.PublicacionId.ToString());
                    lvFacturas.Items.Add(lista);
                }
            
            }

            

            

            #region filtrarFacturas

            private List<Factura> filtrarFacturas()
            {
               return todasLasFacturasDelUsuarioVendedor.FindAll(factura => estaDentroDelRangoDeFechas(factura)
                        && estaDentroDelRangoDeImporte(factura));
            }

            private Boolean estaDentroDelRangoDeFechas(Factura unaFactura) 
            {
                return (dtpFechaInicial.Value <= unaFactura.Fecha) && (unaFactura.Fecha <= dtpFechaFinal.Value);
            }

            private Boolean estaDentroDelRangoDeImporte(Factura unaFactura) 
            {
                if (String.IsNullOrEmpty(txtImporteMinimo.Text) && String.IsNullOrEmpty(txtImporteMaximo.Text)) return true;
                if (String.IsNullOrEmpty(txtImporteMaximo.Text)) return System.Decimal.Parse(txtImporteMinimo.Text) <= unaFactura.Total;
                if (String.IsNullOrEmpty(txtImporteMinimo.Text)) return unaFactura.Total <= System.Decimal.Parse(txtImporteMaximo.Text);
                return (System.Decimal.Parse(txtImporteMinimo.Text) <= unaFactura.Total) 
                    && (unaFactura.Total <= System.Decimal.Parse(txtImporteMaximo.Text));
            }

                 

            #endregion

        #endregion

        #region Extras
           
            #region Validaciones
        
                #region Solo numeros en los txt que solo deberian tener numeros

                private void txtImporteMinimo_KeyPress(object sender, KeyPressEventArgs e) 
                {
                    if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    {
                        MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
                private void txtImporteMaximo_KeyPress(object sender, KeyPressEventArgs e)
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
            
            #region Otros metodos

                private void deshabilitarFiltros()
                {
                    dtpFechaFinal.Enabled = false;
                    dtpFechaInicial.Enabled = false;
                    txtImporteMaximo.Enabled = false;
                    txtImporteMinimo.Enabled = false;
                }

                private void habilitarFiltros()
                {
                    dtpFechaFinal.Enabled = true;
                    dtpFechaInicial.Enabled = true;
                    txtImporteMaximo.Enabled = true;
                    txtImporteMinimo.Enabled = true;
                }

                private void deshabilitarListarPor() 
                {
                    chbComisionPublicacion.Enabled = false;
                    chbEnvios.Enabled = false;
                    chbVentas.Enabled = false;
                }

                private void habilitarListarPor() 
                {
                    chbComisionPublicacion.Enabled = true;
                    chbEnvios.Enabled = true;
                    chbVentas.Enabled = true;
                }

                private void deshabilitarUsuarioVendedor()
                {
                    cmbUsuarioVendedor.Enabled = false;
                    btnOKVendedor.Enabled = false;
                }

                private void btnOKVendedor_Click(object sender, EventArgs e)
                {
                    Dictionary<string, object> nuevoDiccionario = new Dictionary<string, object>();
                    vendedorSeleccionado = cmbUsuarioVendedor.SelectedItem.ToString();
                    nuevoDiccionario.Add("@vendedorID", vendedorSeleccionado);
                    todasLasFacturasDelUsuarioVendedor = DBHelper.ExecuteReader("Factura_GetFacturasSegunVendedor", nuevoDiccionario).ToFacturas();
                    deshabilitarUsuarioVendedor();
                    habilitarListarPor();
                    btnOKListarPor.Enabled = true;
                }

                private void btnOKListarPor_Click(object sender, EventArgs e)
                {
                    habilitarFiltros();
                    btnOKFiltros.Enabled = true;
                    btnOKListarPor.Enabled = false;
                    deshabilitarListarPor();
                }
        
                private void btnOKFiltros_Click(object sender, EventArgs e)
                {
                    btnListarFacturas.Enabled = true;
                    deshabilitarFiltros();
                    btnOKFiltros.Enabled = false;
                }

                private void btnLimpiar_Click(object sender, EventArgs e)
                {
                    lvFacturas.Items.Clear();
                    btnListarFacturas.Enabled = false;
                    btnOKFiltros.Enabled = false;
                    limpiarFiltros();
                    deshabilitarFiltros();
                    btnOKVendedor.Enabled = true;
                    cmbUsuarioVendedor.Enabled = true;
                }

                private void limpiarFiltros()
                {
                    txtImporteMaximo.Clear();
                    txtImporteMinimo.Clear();
                }

             #endregion

            #region Checkboxes
                private void chbComisionPublicacion_CheckedChanged(object sender, EventArgs e)
                {
                    if (chbComisionPublicacion.Checked)
                    {
                        chbVentas.CheckState = CheckState.Unchecked;
                        chbEnvios.CheckState = CheckState.Unchecked;
                    }
                }

                private void chbEnvios_CheckedChanged(object sender, EventArgs e)
                {
                    if (chbEnvios.Checked)
                    {
                        chbComisionPublicacion.CheckState = CheckState.Unchecked;
                        chbVentas.CheckState = CheckState.Unchecked;
                    }
                }

                private void chbVentas_CheckedChanged(object sender, EventArgs e)
                {
                    if (chbVentas.Checked)
                    {
                        chbComisionPublicacion.CheckState = CheckState.Unchecked;
                        chbEnvios.CheckState = CheckState.Unchecked;
                    }
                }
                #endregion                

                

        #endregion




    }
}