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
        private List<Cliente>   clientesQueLeCompraronAlVendedor;
        private Usuario         usuarioSeleccionado;
        private List<CheckBox>  listaDeChbListarPor = new List<CheckBox>();
        private List<Object>    listaDeFiltros = new List<Object>();
        
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

           inicializarListasDeObjetos();
           habilitarFiltros();
           deshabilitarListarPor();
           btnListarFacturas.Enabled = false;
           listaDeUsuariosVendedores = DBHelper.ExecuteReader("Usuario_GetVendedores").ToUsuarios();
           foreach (var usuario in listaDeUsuariosVendedores)
           {
               cmbUsuarioVendedor.Items.Add(usuario.Username);
           }
        }

        #region Inicializaciones de listas
        private void inicializarListasDeObjetos() 
        {
            inicializarListaDeFiltros();
            inicializarListaDeChbListarPor();
        }

        private void inicializarListaDeFiltros() 
        {
            listaDeFiltros.Add(dtpFechaInicial);
            listaDeFiltros.Add(dtpFechaFinal);
            listaDeFiltros.Add(txtImporteMaximo);
            listaDeFiltros.Add(txtImporteMinimo);
            listaDeFiltros.Add(cmbClienteQueCompro);
        }

        private void inicializarListaDeChbListarPor() 
        {
            listaDeChbListarPor.Add(chbComisionDePublicacion);
            listaDeChbListarPor.Add(chbEnvios);
            listaDeChbListarPor.Add(chbVentas);
        }
        #endregion 

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

        private void btnOKFiltros_Click(object sender, EventArgs e)
        {
            habilitarListarPor();
        }

        private void btnOKListarPor_Click(object sender, EventArgs e)
        {
            btnListarFacturas.Enabled = true;
        }

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

            private void deshabilitarListarPor() 
            {
                foreach (var elem in listaDeChbListarPor) { elem.Enabled = false; }
            }

            private void habilitarListarPor() 
            {
                foreach (var elem in listaDeChbListarPor) { elem.Enabled = true; }
            }

            

            #endregion

            private void button1_Click(object sender, EventArgs e)
            {

            }



        #endregion

            private void button1_Click_1(object sender, EventArgs e)
            {
                List<Factura> lista = DBHelper.ExecuteReader("Factura_GetAll").ToFacturas();
                foreach (var factura in lista) { listBox1.Items.Add(factura.Numero); }
            }

            private void btnLimpiar_Click(object sender, EventArgs e)
            {
            }

            private void chbComisionDePublicacion_CheckedChanged(object sender, EventArgs e)
            {
                foreach (var elem in listaDeChbListarPor.FindAll(chb => chb != chbComisionDePublicacion)) { elem.Checked = false; }
            }

            private void chbEnvios_CheckedChanged(object sender, EventArgs e)
            {
                foreach (var elem in listaDeChbListarPor.FindAll(chb => chb != chbEnvios)) { elem.Checked = false; }
            }

            private void chbVentas_CheckedChanged(object sender, EventArgs e)
            {
                foreach (var elem in listaDeChbListarPor.FindAll(chb => chb != chbVentas)) { elem.Checked = false; }
            }

           

    }
}
