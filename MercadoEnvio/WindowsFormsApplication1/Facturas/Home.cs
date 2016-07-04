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
        
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
           listaDeUsuariosVendedores = DBHelper.ExecuteReader("Usuario_GetVendedores").ToUsuarios();
           foreach (var usuario in listaDeUsuariosVendedores)
           {
               cmbUsuarioVendedor.Items.Add(usuario.Username);
           }
        }

        private void btnListarFacturas_Click(object sender, EventArgs e)
        {
            usuarioSeleccionado = getUsuarioSeleccionado();
            listaDeFacturasSegunUsuarioSeleccionado = facturasDelUsuario(usuarioSeleccionado);
            foreach (var factura in listaDeFacturasSegunUsuarioSeleccionado) 
            {
                lbFacturas.Items.Add(factura);
            }
        }

        private Usuario getUsuarioSeleccionado() 
        {
           return listaDeUsuariosVendedores.Find(usuario => usuario.Username == cmbUsuarioVendedor.SelectedItem);
        }

        private List<Factura> facturasDelUsuario(Usuario unUsuario) 
        {
            Dictionary<string, object> nuevoDiccionario = new Dictionary<string, object>();
            nuevoDiccionario.Add("@usuario", unUsuario.Username);
            List<Factura> facturas = DBHelper.ExecuteReader("Facturas_GetFacturasSegunUsuario", nuevoDiccionario).ToFacturas();
            return facturas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTest.Text = getUsuarioSeleccionado().Username;
        }

    }
}
