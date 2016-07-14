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
            cliente = DBHelper.ExecuteReader("Cliente_GetClienteSegunUsuario", new Dictionary<string, object>() { { "@username", usuario.Username } }).ToCliente();
            InitializeComponent();
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
            comprasSinCalificar = DBHelper.ExecuteReader("Venta_GetVentasSinCalificarSegunCliente", new Dictionary<string, object>() { { "@clieID", cliente.Id } }).ToVentas();
            comprasInmediatasCalificadas = DBHelper.ExecuteReader("Calificacion_GetComprasInmediatasCalificadasSegunCliente", new Dictionary<string, object>() { { "@clieID", cliente.Id } }).ToCalificaciones();
            subastasCalificadas = DBHelper.ExecuteReader("Calificacion_GetSubastasCalificadasSegunCliente", new Dictionary<string, object>() { { "@clieID", cliente.Id } }).ToCalificaciones();
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
                    Dictionary<string, object> parametros = new Dictionary<string, object>() {
                        { "@estrellas", estrellas },
                        { "@ventaID", venta.Id },
                        { "@detalle", detalle},
                        { "@fecha", DateTime.Parse(ConfigurationManager.AppSettings["fecha"]) }
                    };                    
                    DBHelper.ExecuteNonQuery("Calificacion_Add", parametros);
                    MessageBox.Show("Calificado con exito", "Exito");
                    inicializarAtributos();
                    llenarDataGridViews();
                    llenarResumenCalificaciones();
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
            dgvComprasACalificar.DataSource = comprasSinCalificar;
            dgvComprasACalificar.Columns.Clear();
            dgvComprasACalificar.AutoGenerateColumns = false;
            dgvComprasACalificar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Fecha",
                HeaderText = "Fecha",
                Width = 100,
                ReadOnly = true
            });
            dgvComprasACalificar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PublicacionId",
                HeaderText = "Publicacion ID",
                Width = 100,
                ReadOnly = true
            });

            List<Calificacion> lista = comprasInmediatasCalificadas.Concat(subastasCalificadas).OrderByDescending(elem => elem.Fecha).ToList();
            if (lista.Count < 5) {
                dgvUltimas5.DataSource = lista;
            }
            else {
                dgvUltimas5.DataSource = lista.GetRange(0, 5);
            }
            dgvUltimas5.Columns.Clear();
            dgvUltimas5.AutoGenerateColumns = false;
            dgvUltimas5.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Detalle",
                HeaderText = "Detalle",
                Width = 100,
                ReadOnly = true
            });
            dgvUltimas5.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Estrellas",
                HeaderText = "Estrellas",
                Width = 100,
                ReadOnly = true
            });
            dgvUltimas5.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Fecha",
                HeaderText = "Fecha",
                Width = 100,
                ReadOnly = true
            });
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
            txt1EstrellaCompra.Clear();
            txt2EstrellasCompra.Clear();
            txt3EstrellasCompra.Clear();
            txt4EstrellasCompra.Clear();
            txt5EstrellasCompra.Clear();                
            txt1EstrellaCompra.Text = cantidadDeCalificacionesSegunEstrellas(comprasInmediatasCalificadas, 1).ToString();
            txt2EstrellasCompra.Text = cantidadDeCalificacionesSegunEstrellas(comprasInmediatasCalificadas, 2).ToString();
            txt3EstrellasCompra.Text = cantidadDeCalificacionesSegunEstrellas(comprasInmediatasCalificadas, 3).ToString();
            txt4EstrellasCompra.Text = cantidadDeCalificacionesSegunEstrellas(comprasInmediatasCalificadas, 4).ToString();
            txt5EstrellasCompra.Text = cantidadDeCalificacionesSegunEstrellas(comprasInmediatasCalificadas, 5).ToString();
        }

        private void llenarResumenCalificacionesSubasta()
        {
            txt1EstrellaSubasta.Clear();
            txt2EstrellasSubasta.Clear();
            txt3EstrellasSubasta.Clear();
            txt4EstrellasSubasta.Clear();
            txt5EstrellasSubasta.Clear();
            txt1EstrellaSubasta.Text = cantidadDeCalificacionesSegunEstrellas(subastasCalificadas, 1).ToString();
            txt2EstrellasSubasta.Text = cantidadDeCalificacionesSegunEstrellas(subastasCalificadas, 2).ToString();
            txt3EstrellasSubasta.Text = cantidadDeCalificacionesSegunEstrellas(subastasCalificadas, 3).ToString();
            txt4EstrellasSubasta.Text = cantidadDeCalificacionesSegunEstrellas(subastasCalificadas, 4).ToString();
            txt5EstrellasSubasta.Text = cantidadDeCalificacionesSegunEstrellas(subastasCalificadas, 5).ToString();
        }

        private void llenarCantidadDeComprasYSubastasRealizadas()
        {
            txtComprasRealizadas.Clear();
            txtSubastasRealizadas.Clear();
            txtComprasRealizadas.Text = getComprasRealizadas().Count.ToString();
            txtSubastasRealizadas.Text = getSubastasGanadas().Count.ToString();
        }

        private void llenarTotalDeEstrellasOtrogadas()
        {
            txtTotalDeEstrellas.Clear();
            txtTotalEstrellasOtrogadasCompra.Clear();
            txtTotalEstrellasOtrogadasSubasta.Clear();
            txtTotalEstrellasOtrogadasCompra.Text = comprasInmediatasCalificadas.Sum<Calificacion>(vent => vent.Estrellas).ToString();
            txtTotalEstrellasOtrogadasSubasta.Text = subastasCalificadas.Sum<Calificacion>(sub => sub.Estrellas).ToString();
            txtTotalDeEstrellas.Text = (comprasInmediatasCalificadas.Sum<Calificacion>(vent => vent.Estrellas) +
                subastasCalificadas.Sum<Calificacion>(sub => sub.Estrellas)).ToString();
        }
        #endregion

        #region Gets
        private List<Venta> getComprasRealizadas()
        {
            return DBHelper.ExecuteReader("Venta_GetComprasInmediatasSegunCliente", new Dictionary<string, object>() { { "@clieID", cliente.Id } }).ToVentas();
        }

        private List<Venta> getSubastasGanadas()
        {
            return DBHelper.ExecuteReader("Venta_GetSubastasSegunCliente", new Dictionary<string, object>() { { "@clieID", cliente.Id } }).ToVentas();
        }

        #endregion
        

    }
}
