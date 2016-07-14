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
        private int facturasXpagina = 14;
        private int paginaActual = 0;
        private int ultimaPagina = 0;
        private List<Factura> facturas;

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
                if (chbComisionPublicacion.Checked)
                {
                    todasLasFacturasDelUsuarioVendedor = DBHelper.ExecuteReader("Factura_GetFacturaSegunVendedorYCliente_OrderByCostoPublicacion", new Dictionary<string, object>() { { "@vendedorID", vendedorSeleccionado } }).ToFacturas();
                }
                else if(chbVentas.Checked)
                {
                    todasLasFacturasDelUsuarioVendedor = DBHelper.ExecuteReader("Factura_GetFacturaSegunVendedorYCliente_OrderByPorcentajeProducto", new Dictionary<string, object>() { { "@vendedorID", vendedorSeleccionado } }).ToFacturas();
                }
                else if(chbEnvios.Checked)
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
                            // lleno dgvFacturas
                            LoadFacturas(facturasFiltradas);
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
                    resultado = resultado.Where(x => fechaInicial <= x.Fecha && x.Fecha <= fechaFinal).ToList();
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
                            resultado = resultado.Where(x => montoMin <= x.Total && x.Total <= montoMax).ToList();
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
                dgvFacturas.DataSource = null;               
                chkFecha.Checked = false;
                chkMonto.Checked = false;
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


        private List<Factura> actualizarPagina()
        {
            List<Factura> retorno;
            lblPagina.Text = (paginaActual + 1).ToString();
            btnInicio.Enabled = true;
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = true;
            btnFin.Enabled = true;
            if (paginaActual == ultimaPagina)
            {
                int mod = facturas.Count % facturasXpagina;
                if (mod != 0 || facturas.Count == 0)
                {
                    retorno = facturas.GetRange(paginaActual * facturasXpagina, mod);
                }
                else
                {
                    ultimaPagina -= 1;
                    paginaActual = ultimaPagina;
                    retorno = facturas.GetRange(paginaActual * facturasXpagina, facturasXpagina);
                }
                btnSiguiente.Enabled = false;
                btnFin.Enabled = false;
            }
            else
            {
                retorno = facturas.GetRange(paginaActual * facturasXpagina, facturasXpagina);
                if (paginaActual == 0)
                {
                    btnInicio.Enabled = false;
                    btnAnterior.Enabled = false;
                }
            }
            if (ultimaPagina == 0)
            {

                btnInicio.Enabled = false;
                btnAnterior.Enabled = false;
            }

            return retorno;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            paginaActual = 0;
            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = actualizarPagina();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            paginaActual -= 1;
            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = actualizarPagina();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaActual += 1;
            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = actualizarPagina();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            paginaActual = ultimaPagina;
            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = actualizarPagina();
        }

        private void LoadFacturas(List<Factura> facturas)
        {
            this.facturas = facturas;
            paginaActual = 0;
            ultimaPagina = (int)Math.Floor(Convert.ToDouble(facturas.Count / facturasXpagina));
            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = actualizarPagina();
        }
    }
}
