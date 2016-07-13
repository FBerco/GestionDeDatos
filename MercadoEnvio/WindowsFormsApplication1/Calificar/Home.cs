using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Helpers;
using Clases;

using System.Windows.Forms;

namespace GDD.Calificar
{
    public partial class frmHome : Form
    {
        
        public frmHome(Usuario unUsuario) 
        {
            InitializeComponent();
            usuario = unUsuario; 
        }

        #region Atributos
        
        private Usuario usuario;
        private List<Venta> ventasSinCalificar;
        private Cliente cliente;
        
        #endregion

        private void frmHome_Load(object sender, EventArgs e)
        {
            llenarCmbCompras();
        }

        private void llenarCmbCompras() 
        {
            Dictionary<String, Object> diccionario = new Dictionary<string, object>();
            Dictionary<String, Object> diccionario2 = new Dictionary<string, object>();
            diccionario.Add("@username", usuario.Username);
            cliente = DBHelper.ExecuteReader("Cliente_GetClienteSegunUsuario", diccionario).ToCliente();
            diccionario2.Add("@clieID", cliente.Id);
            ventasSinCalificar = DBHelper.ExecuteReader("Venta_GetVentasSinCalificarSegunCliente", diccionario2).ToVentas();
            foreach (var venta in ventasSinCalificar)
            {
                cmbVentas.Items.Add(venta.Id);
            }
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            var venta = cmbVentas.SelectedItem;
            var estrellas = cmbEstrellas.SelectedItem;
            if (venta != null && estrellas != null)
            {
                var detalle = txtDetalle.Text;
                if (detalle.Length <= 140)
                {
                    Dictionary<string, object> parametros = new Dictionary<string, object>();
                    parametros.Add("@estrellas", estrellas);
                    parametros.Add("@ventaID", venta);
                    parametros.Add("@detalle", detalle);
                    DBHelper.ExecuteNonQuery("Calificacion_Add", parametros);
                    MessageBox.Show("Calificado con exito", "Exito");
                    cmbVentas.Items.Clear();
                    llenarCmbCompras();
                }
                else
                {
                    MessageBox.Show("El detalle tiene que ser como maximo 140", "Error");
                }

            }
            else
            {
                MessageBox.Show("Seleccionar venta, estrellas y completar detalle", "Error");
            }
        }
            
    }
}
