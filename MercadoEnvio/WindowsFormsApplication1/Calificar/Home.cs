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
            usuario = unUsuario;
            cliente = getCliente();
            if (cliente == null) { MessageBox.Show("No puede calificar ya que no es cliente.", "Error"); }
            else { InitializeComponent(); }
        }   //despues ver si esta bien esto

        #region Atributos
        
        private Usuario usuario;
        private Cliente cliente;
        private Venta compraACalificar;
        private List<Venta> comprasSinCalificar;
        private List<Calificacion> comprasInmediatasCalificadas;
        private List<Calificacion> subastasCalificadas; 
        
        #endregion

        private void frmHome_Load(object sender, EventArgs e)
        {
            btnCalificar.Enabled = false;
            inicializarAtributos();
            llenarDataGridViews();
            llenarResumenCalificaciones();
        }

        private void inicializarAtributos() 
        {
            comprasSinCalificar = getComprasSinCalificar();
            comprasInmediatasCalificadas = getComprasInmediatasCalificadas();
            subastasCalificadas = getSubastasCalificadas();
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
                    llenarDataGridViews();
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

        private int cantidadDeCalificacionesSegunEstrellas(List<Calificacion> unaLista, int cantEstrellas) 
        {
            return unaLista.FindAll(elem => elem.Estrellas == cantEstrellas).Count;
        }

        #region Llenar

        private void llenarDataGridViews()
        {
            dgvComprasACalificar.DataSource = null;
            dgvUltimas5.DataSource = null;
            llenarDgvUltimas5();
            llenarDgvCompras();
        }

        private void llenarDgvCompras()
        {
            dgvComprasACalificar.DataSource = comprasSinCalificar;            
        }

        private void llenarDgvUltimas5()
        {
            List<Calificacion> listaAux = comprasInmediatasCalificadas.Concat(subastasCalificadas).
                                        OrderByDescending(elem => elem.Fecha).ToList<Calificacion>();
            dgvUltimas5.DataSource = listaAux.GetRange(0, 5);
        }

        private void llenarResumenCalificaciones()
        {
            llenarResumenCalificacionesCompraInmediata();
            llenarResumenCalificacionesSubasta();
            llenarCantidadDeComprasYSubastasRealizadas();
            llenarTotalDeEstrellasOtrogadas();
        }

        private void llenarResumenCalificacionesCompraInmediata()
        {
            txt1EstrellaCompra.Text = cantidadDeCalificacionesSegunEstrellas(comprasInmediatasCalificadas, 1).ToString();
            txt2EstrellasCompra.Text = cantidadDeCalificacionesSegunEstrellas(comprasInmediatasCalificadas, 2).ToString();
            txt3EstrellasCompra.Text = cantidadDeCalificacionesSegunEstrellas(comprasInmediatasCalificadas, 3).ToString();
            txt4EstrellasCompra.Text = cantidadDeCalificacionesSegunEstrellas(comprasInmediatasCalificadas, 4).ToString();
            txt5EstrellasCompra.Text = cantidadDeCalificacionesSegunEstrellas(comprasInmediatasCalificadas, 5).ToString();
        }

        private void llenarResumenCalificacionesSubasta()
        {
            txt1EstrellaSubasta.Text = cantidadDeCalificacionesSegunEstrellas(subastasCalificadas, 1).ToString();
            txt2EstrellasSubasta.Text = cantidadDeCalificacionesSegunEstrellas(subastasCalificadas, 2).ToString();
            txt3EstrellasSubasta.Text = cantidadDeCalificacionesSegunEstrellas(subastasCalificadas, 3).ToString();
            txt4EstrellasSubasta.Text = cantidadDeCalificacionesSegunEstrellas(subastasCalificadas, 4).ToString();
            txt5EstrellasSubasta.Text = cantidadDeCalificacionesSegunEstrellas(subastasCalificadas, 5).ToString();
        }

        private void llenarCantidadDeComprasYSubastasRealizadas()
        {
            txtComprasRealizadas.Text = getComprasRealizadas().Count.ToString();
            txtSubastasRealizadas.Text = getSubastasGanadas().Count.ToString();
        }

        private void llenarTotalDeEstrellasOtrogadas()
        {
            txtTotalEstrellasOtrogadasCompra.Text = comprasInmediatasCalificadas.Sum<Calificacion>(vent => vent.Estrellas).ToString();
            txtTotalEstrellasOtrogadasSubasta.Text = subastasCalificadas.Sum<Calificacion>(sub => sub.Estrellas).ToString();
            txtTotalDeEstrellas.Text = (comprasInmediatasCalificadas.Sum<Calificacion>(vent => vent.Estrellas) +
                subastasCalificadas.Sum<Calificacion>(sub => sub.Estrellas)).ToString();
        }

        #endregion

        #region Gets

        private Cliente getCliente()
        {
            Dictionary<String, Object> diccionario = new Dictionary<string, object>();
            diccionario.Add("@username", usuario.Username);
            return DBHelper.ExecuteReader("Cliente_GetClienteSegunUsuario", diccionario).ToCliente();
        }

        private List<Venta> getComprasSinCalificar()
        {
            Dictionary<String, Object> diccionario2 = new Dictionary<string, object>();
            diccionario2.Add("@clieID", cliente.Id);
            return DBHelper.ExecuteReader("Venta_GetVentasSinCalificarSegunCliente", diccionario2).ToVentas();
        }

        private List<Calificacion> getComprasInmediatasCalificadas()
        {
            List<Calificacion> lista = new List<Calificacion>();
            Dictionary<String, Object> diccionario = new Dictionary<string, object>();
            diccionario.Add("@clieID", cliente.Id);
            lista = DBHelper.ExecuteReader("Calificacion_GetComprasInmediatasCalificadasSegunCliente", diccionario).ToCalificaciones();
            return lista;
        }

        private List<Calificacion> getSubastasCalificadas()
        {
            List<Calificacion> lista = new List<Calificacion>();
            Dictionary<String, Object> diccionario = new Dictionary<string, object>();
            diccionario.Add("@clieID", cliente.Id);
            lista = DBHelper.ExecuteReader("Calificacion_GetSubastasCalificadasSegunCliente", diccionario).ToCalificaciones();
            return lista;
        }

        private List<Venta> getComprasRealizadas()
        {
            List<Venta> lista = new List<Venta>();
            Dictionary<String, Object> diccionario = new Dictionary<string, object>();
            diccionario.Add("clieID", cliente.Id);
            lista = DBHelper.ExecuteReader("Venta_GetComprasInmediatasSegunCliente", diccionario).ToVentas();
            return lista;
        }

        private List<Venta> getSubastasGanadas()
        {
            List<Venta> lista = new List<Venta>();
            Dictionary<String, Object> diccionario = new Dictionary<string, object>();
            diccionario.Add("clieID", cliente.Id);
            lista = DBHelper.ExecuteReader("Venta_GetSubastasSegunCliente", diccionario).ToVentas();
            return lista;
        }

        #endregion
        

    }
}
