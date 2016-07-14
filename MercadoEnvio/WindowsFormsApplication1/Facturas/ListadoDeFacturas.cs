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

namespace GDD.Facturas
{
    public partial class frmListadoDeFacturas : Form
    {
        #region Atributos
                
        private List<Usuario>   listaDeUsuariosVendedores;
        private List<Factura>   todasLasFacturasDelUsuarioVendedor;
        private List<Factura>   facturasFiltradas;
        private Usuario usuario;
        private bool esAdmin;

        #endregion
        
        public frmListadoDeFacturas(Usuario us, bool administrador)
        {
            InitializeComponent();
            usuario = us;
            esAdmin = administrador;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //Si es admin le muestro todos, sino le muestro solo el de el
            if (esAdmin)
            {
                cmbUsuarioVendedor.DataSource = DBHelper.ExecuteReader("Usuario_GetVendedores").ToUsuarios();
                cmbUsuarioVendedor.DisplayMember = "Username";
            }
            else
            {
                cmbUsuarioVendedor.DataSource = new List<Usuario>() { usuario };
                cmbUsuarioVendedor.DisplayMember = "Username";
                cmbUsuarioVendedor.SelectedIndex = 0;
                cmbUsuarioVendedor.Enabled = false;
            }                    
        }

        #region Funciones Principales

        private void btnListarFacturas_Click(object sender, EventArgs e)
        {
            if (cmbUsuarioVendedor.SelectedItem != null)
            {
                var vendedorSeleccionado = ((Usuario)cmbUsuarioVendedor.SelectedItem).Username;
                todasLasFacturasDelUsuarioVendedor = DBHelper.ExecuteReader("Factura_GetFacturasSegunVendedor", new Dictionary<string, object>() { { "@vendedorID", vendedorSeleccionado } }).ToFacturas();
                if (rdbComisionPublicacion.Checked)
                {
                    todasLasFacturasDelUsuarioVendedor = DBHelper.ExecuteReader("Factura_GetFacturaSegunVendedorYCliente_OrderByCostoPublicacion", new Dictionary<string, object>() { { "@vendedorID", vendedorSeleccionado } }).ToFacturas();
                }
                else if(rdbVentas.Checked)
                {
                    todasLasFacturasDelUsuarioVendedor = DBHelper.ExecuteReader("Factura_GetFacturaSegunVendedorYCliente_OrderByPorcentajeProducto", new Dictionary<string, object>() { { "@vendedorID", vendedorSeleccionado } }).ToFacturas();
                }
                else if(rdbEnvios.Checked)
                {
                    todasLasFacturasDelUsuarioVendedor = DBHelper.ExecuteReader("Factura_GetFacturaSegunVendedorYCliente_OrderByCostoEnvio", new Dictionary<string, object>() { { "@vendedorID", vendedorSeleccionado } }).ToFacturas();
                }
                else
                {
                    MessageBox.Show("Seleccione una manera de listar las facturas por favor.");
                    return;
                }
                if (todasLasFacturasDelUsuarioVendedor.Count > 0)
                {                
                    facturasFiltradas = filtrarFacturas();
                    if (facturasFiltradas != null)
                    {
                        if (facturasFiltradas.Count > 0)
                        {
                            foreach (var factura in facturasFiltradas)
                            {
                                ListViewItem lista = new ListViewItem(factura.Numero.ToString());
                                lista.SubItems.Add(factura.Fecha.ToString());
                                lista.SubItems.Add(factura.Total.ToString());
                                lista.SubItems.Add(factura.PublicacionId.ToString());
                                lvFacturas.Items.Add(lista);
                            }
                        }
                        else
                        {

                            MessageBox.Show("No hay facturas aplicando esos filtros");
                        }
                    }                   
                }
                else
                {
                    MessageBox.Show("Este vendedor no tiene facturas asignadas");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un vendedor por favor.");
                return;
            }                               
        }
        
        private List<Factura> filtrarFacturas()
        {
            var resultado = todasLasFacturasDelUsuarioVendedor;
            if (chkFecha.Checked)
            {
                var fechaInicial = dtpFechaInicial.Value;
                var fechaFinal = dtpFechaFinal.Value;
                if (fechaInicial <= fechaFinal)
                {
                    todasLasFacturasDelUsuarioVendedor = resultado.Where(x => fechaInicial <= x.Fecha && x.Fecha <= fechaFinal).ToList();
                }
                else
                {
                    MessageBox.Show("Fecha inicio debe ser menor a la fecha final.");
                    return null;
                }
            }
            if (chkMonto.Checked)
            {
                if (!string.IsNullOrEmpty(txtImporteMinimo.Text) && !string.IsNullOrEmpty(txtImporteMaximo.Text))
                {
                    var montoMin = Convert.ToInt32(txtImporteMinimo.Text);
                    var montoMax = Convert.ToInt32(txtImporteMaximo.Text);
                    if (!(montoMin <= 0 || montoMax <= 0))
                    {
                        if (montoMin < montoMax)
                        {
                            todasLasFacturasDelUsuarioVendedor = resultado.Where(x => montoMax <= x.Total && x.Total <= montoMax).ToList();
                        }
                        else
                        {
                            MessageBox.Show("El monto minimo debe ser menor al maximo");
                            return null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese valores positivos.");
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese valor minimo y maximo.");
                    return null;
                }               
            }
            return resultado;
        }
        
        #endregion

        #region Extras
           
            #region Validaciones
            private void txtImporteMinimo_KeyPress(object sender, KeyPressEventArgs e) 
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            private void txtImporteMaximo_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            #endregion

            #region Otros metodos

            private void deshabilitarFiltros()
            {
                chkFecha.Checked = false;
                chkMonto.Checked = false;
            }

            private void habilitarFiltros()
            {
                chkFecha.Checked = true;
                chkMonto.Checked = true;
            }
        
            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                lvFacturas.Items.Clear();               
                chkFecha.Checked = false;
                chkMonto.Checked = false;
            }
        
            #endregion
        
        #endregion

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFecha.Checked)
            {
                dtpFechaInicial.Enabled = true;
                dtpFechaFinal.Enabled = true;                
            }
            else
            {
                dtpFechaInicial.Enabled = false;
                dtpFechaFinal.Enabled = false;
            }
        }

        private void chkMonto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonto.Checked)
            {
                txtImporteMinimo.Enabled = true;
                txtImporteMaximo.Enabled = true;
            }
            else
            {
                txtImporteMinimo.Enabled = false;
                txtImporteMaximo.Enabled = false;
            }
        }
    }
}
