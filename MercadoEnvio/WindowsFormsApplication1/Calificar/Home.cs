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
using System.Configuration;

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
        private List<Venta> comprasSinCalificar;
        private Cliente cliente;
        private Venta compraACalificar;
        
        #endregion

        private void frmHome_Load(object sender, EventArgs e)
        {

            btnCalificar.Enabled = false;
            llenarDgvCompras();
                              
        }

        private void llenarDgvCompras() 
        {
            Dictionary<String, Object> diccionario = new Dictionary<string, object>();
            Dictionary<String, Object> diccionario2 = new Dictionary<string, object>();
            diccionario.Add("@username", usuario.Username);
            cliente = DBHelper.ExecuteReader("Cliente_GetClienteSegunUsuario", diccionario).ToCliente();
            if (cliente == null)
            {
                MessageBox.Show("No puede calificar ya que no es cliente.", "Error");
                //COMO HACER PARA QUE NO SE ABRA EL FRM CALIFICAR 
            }
            else
            {
                diccionario2.Add("@clieID", cliente.Id);
                comprasSinCalificar = DBHelper.ExecuteReader("Venta_GetVentasSinCalificarSegunCliente", diccionario2).ToVentas();
                dgvComprasACalificar.DataSource = comprasSinCalificar;
            }        
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            var venta = compraACalificar;
            var estrellas = cmbEstrellas.SelectedItem;
            if (venta != null && estrellas != null)
            {
                var detalle = txtDetalle.Text;
                if (detalle.Length <= 140)
                {
                    Dictionary<string, object> parametros = new Dictionary<string, object>();
                    parametros.Add("@estrellas", estrellas);
                    parametros.Add("@ventaID", venta.Id);
                    parametros.Add("@detalle", detalle);
                    parametros.Add("@fecha", DateTime.Parse(ConfigurationManager.AppSettings["fecha"]));
                    DBHelper.ExecuteNonQuery("Calificacion_Add", parametros);
                    MessageBox.Show("Calificado con exito", "Exito");
                    dgvComprasACalificar.DataSource = null;
                    llenarDgvCompras();
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

        private void dgvComprasACalificar_MouseClick(object sender, MouseEventArgs e)
        {
            compraACalificar = (Venta)dgvComprasACalificar.SelectedRows[0].DataBoundItem;
            btnCalificar.Enabled = true;
        }       
    }
}
