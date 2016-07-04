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
    public partial class frmHome : Form
    {
        private List<Usuario>   listaDeUsuariosVendedores;
        private List<Factura>   listaDeFacturasSegunUsuarioSeleccionado;
        private Usuario         usuarioSeleccionado;
        private List<Cliente>   clientesQueLeCompraronAlVendedor;
        
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
           deshabilitarFiltros();
           listaDeUsuariosVendedores = DBHelper.ExecuteReader("Usuario_GetVendedores").ToUsuarios();
           foreach (var usuario in listaDeUsuariosVendedores)
           {
               cmbUsuarioVendedor.Items.Add(usuario.Username);
           }
        }

        #region Funciones Principales

        private void btnListarFacturas_Click(object sender, EventArgs e)
        {
            usuarioSeleccionado = getUsuarioSeleccionado();
            listaDeFacturasSegunUsuarioSeleccionado = facturasDelUsuario(usuarioSeleccionado);
            listaDeFacturasSegunUsuarioSeleccionado = filtrarSegunCriterios(listaDeFacturasSegunUsuarioSeleccionado);
            foreach (var factura in listaDeFacturasSegunUsuarioSeleccionado)
            {
                lbFacturas.Items.Add(factura);
            }
        }

        private void btnOKVendedor_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> nuevoDiccionario = new Dictionary<string, object>();
            nuevoDiccionario.Add("@vendedorID", cmbUsuarioVendedor.SelectedText);
            clientesQueLeCompraronAlVendedor = DBHelper.ExecuteReader("Cliente_GetClienteQueCompraronAUnVendedor", nuevoDiccionario).ToClientes();
            foreach (var cliente in clientesQueLeCompraronAlVendedor)
            {
                cmbClienteQueCompro.Items.Add(cliente.Id);
            }
            habilitarFiltros();
        }

        #endregion

        #region Extras

            #region filtrar facturas segun criterios

            private List<Factura> filtrarSegunCriterios(List<Factura> unaLista)
                {
                    return unaLista.FindAll(factura => estaDentroDelRangoDeFechas(factura) && estaDentroDelRangoDeImporte(factura) && correspondeAlClienteSeleccionado(factura));
                }

            private Boolean estaDentroDelRangoDeFechas(Factura unaFactura)
            {
                return (dtpFechaInicial.Value <= unaFactura.Fecha) && (unaFactura.Fecha <= dtpFechaFinal.Value);
            }

            private Boolean estaDentroDelRangoDeImporte(Factura unaFactura) 
            {
                return (System.Int32.Parse(txtImporteMinimo.Text) <= unaFactura.Total) && 
                       (unaFactura.Total <= System.Int32.Parse(txtImporteMaximo.Text)); 
            }

            private Boolean correspondeAlClienteSeleccionado(Factura unaFactura) 
            {
                return getClienteDeUnaFactura(unaFactura) == getClienteQueComproSeleccionado(cmbClienteQueCompro.Text); 
            }

            private Cliente getClienteDeUnaFactura(Factura unaFactura)
            {
                Dictionary<string,object> nuevoDiccionario = new Dictionary<string,object>();
                nuevoDiccionario.Add("@factID",unaFactura.Numero);
                return DBHelper.ExecuteReader("Cliente_GetClienteDeUnaFactura",nuevoDiccionario).ToCliente();
            }

            private Cliente getClienteQueComproSeleccionado(String clieID)
            {
                return clientesQueLeCompraronAlVendedor.Find(cliente => cliente.Id.ToString() == clieID);
            }
        
            #endregion

            #region Otros metodos

            private Usuario getUsuarioSeleccionado()
            {
                return listaDeUsuariosVendedores.Find(usuario => usuario.Username == cmbUsuarioVendedor.SelectedItem);
            }

            private List<Factura> facturasDelUsuario(Usuario unUsuario)
            {
                Dictionary<string, object> nuevoDiccionario = new Dictionary<string, object>();
                nuevoDiccionario.Add("@usuario", unUsuario.Username);
                List<Factura> facturas = DBHelper.ExecuteReader("Facturas_GetFacturasSegunUsuario", nuevoDiccionario).ToFacturas();
                return facturas;  //TENGO PROBLEMAS CON ESTA FUNCION, NO LOGRO HACER QUE ME DEVUELVA LAS FACTURAS DEL USUARIO
            }

            private void deshabilitarFiltros()
            {
                dtpFechaFinal.Enabled = false;
                dtpFechaInicial.Enabled = false;
                txtImporteMaximo.Enabled = false;
                txtImporteMinimo.Enabled = false;
                cmbClienteQueCompro.Enabled = false;
            }

            private void habilitarFiltros()
            {
                dtpFechaFinal.Enabled = true;
                dtpFechaInicial.Enabled = true;
                txtImporteMaximo.Enabled = true;
                txtImporteMinimo.Enabled = true;
                cmbClienteQueCompro.Enabled = true;
            }

            #endregion



        #endregion

    }
}
