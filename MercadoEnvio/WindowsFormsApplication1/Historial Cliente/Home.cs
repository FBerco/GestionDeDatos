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

namespace GDD.Historial_Cliente
{
    public partial class frmHome : Form
    {
        private Usuario usuario;
        private Cliente cliente;
        private List<Venta> listaDeComprasQueParticipo;
        private List<Venta> comprasSinCalificar;
        private List<Oferta> listaDeSubastasQueParticipo;
        private List<Calificacion> calificaciones;
        private int ultimaFilaInsertada;
        

        public frmHome(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            inicializarAtributos();
            llenarDataGridViewConCompras();
            llenarDataGridViewConSubastas();
            llenarResumenDeCalificaciones();
            llenarOperacionesCalificadas();
            llenarOperacionesSinCalificar();
            llenarCalificacionPromedio();
            llenarCalificacionMasAlta();
            llenarCalificacionMasBaja();
            llenarCantidadDeTransacciones();
            llenarCantidadDeCompras();
            llenarCantidadDeSubastas();
        }

        #region Metodos
            
            private void inicializarAtributos() 
        {
            cliente = getCliente();
            listaDeComprasQueParticipo = getCompras();
            listaDeSubastasQueParticipo = getSubastas();
            calificaciones = getCalificacionesSegunCliente();
        }
        
            #region Get Valores
                private Cliente getCliente() 
                {
                    Dictionary<String, Object> diccionario = new Dictionary<String, Object>();
                    diccionario.Add("@username",usuario.Username);
                    return DBHelper.ExecuteReader("Cliente_GetClienteSegunUsuario", diccionario).ToCliente();
                }

                private List<Venta> getCompras() 
                {
                    Dictionary<String, Object> diccionario = new Dictionary<string, object>();
                    diccionario.Add("@clieID", cliente.Id);
                    return DBHelper.ExecuteReader("Ventas_GetVentasSegunCliente", diccionario).ToVentas();
                }

                private List<Oferta> getSubastas() 
                {
                    Dictionary<String, Object> diccionario = new Dictionary<string, object>();
                    diccionario.Add("@clieID", cliente.Id);
                    return DBHelper.ExecuteReader("Oferta_GetOfertasSegunCliente", diccionario).ToOfertas();
                }

                private List<Calificacion> getCalificacionesSegunCliente() 
                {
                    Dictionary<String, Object> diccionario = new Dictionary<string, object>();
                    diccionario.Add("@clieID", cliente.Id);
                    return DBHelper.ExecuteReader("Calificacion_GetCalificacionesSegunCliente", diccionario).ToCalificaciones();
                }

                private int getCantidadDeOperacionesSinCalificar() 
                {
                    Dictionary<String, Object> diccionario = new Dictionary<string, object>();
                    diccionario.Add("@clieID", cliente.Id);
                    comprasSinCalificar = DBHelper.ExecuteReader("Venta_GetVentasSinCalificarSegunCliente", diccionario).ToVentas();
                    return comprasSinCalificar.Count();
                }
            #endregion

            #region Llenar forms

                private void llenarDataGridViewConCompras()
                {
                    int fila = 0;
                    foreach (var compra in listaDeComprasQueParticipo)
                    {
                        dgvHistorial.Rows.Insert(
                            fila,
                            "Compra Inmediata",
                            compra.PublicacionId.ToString(),
                            compra.Fecha.ToString(),
                            compra.Cantidad.ToString(),
                            "-"
                            );
                        fila++;
                    }
                    ultimaFilaInsertada = fila;
                }

                private void llenarDataGridViewConSubastas()
                {
                    int fila = ultimaFilaInsertada++;
                    foreach (var subasta in listaDeSubastasQueParticipo)
                    {
                        dgvHistorial.Rows.Insert(
                            fila,
                            "Subasta",
                            subasta.PublicacionId.ToString(),
                            subasta.Fecha.ToString(),
                            "-",
                            subasta.Monto.ToString()
                            );
                        fila++;
                    }
                }        
        
                private void llenarResumenDeCalificaciones() 
                {
                    foreach (var calificacion in calificaciones) 
                    {
                        ListViewItem lista = new ListViewItem(calificacion.Fecha.ToString());
                        lista.SubItems.Add(calificacion.Estrellas.ToString());
                        lvResumenCalificaciones.Items.Add(lista);
                    }
                }

                private void llenarOperacionesCalificadas() 
                {
                    txtOperacionesCalificadas.Text = calificaciones.Count.ToString();
                }
        
                private void llenarOperacionesSinCalificar() 
                {
                    txtOperacionesSinCalificar.Text = getCantidadDeOperacionesSinCalificar().ToString();
                }

                private void llenarCalificacionPromedio() 
                {
                    double promedio = calificaciones.Select(calificacion => calificacion.Estrellas).Average();
                    String mostrar = promedio.ToString();
                    txtCalificacionPromedio.Text = mostrar.Substring(0,4); 
                }

                private void llenarCalificacionMasAlta() 
                {
                    txtCalificacionMasAlta.Text = calificaciones.Select(calificacion => calificacion.Estrellas).Max().ToString();
                }

                private void llenarCalificacionMasBaja() 
                {
                    txtCalificacionMasBaja.Text = calificaciones.Select(calificacion => calificacion.Estrellas).Min().ToString();
                }

                private void llenarCantidadDeTransacciones() 
                {
                    var cantidad = (listaDeComprasQueParticipo.Count + listaDeSubastasQueParticipo.Count);
                    txtCantTransacciones.Text = cantidad.ToString();
                }

                private void llenarCantidadDeCompras() 
                {
                    txtCantCompras.Text = listaDeComprasQueParticipo.Count.ToString();
                }

                private void llenarCantidadDeSubastas() 
                {
                    txtCantSubastas.Text = listaDeSubastasQueParticipo.Count.ToString();
                }
            #endregion

                private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {

                }

                

        #endregion

                private void button1_Click(object sender, EventArgs e)
                {
                    llenarDataGridViewConCompras();
                }
                
    }
}
