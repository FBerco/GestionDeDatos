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
        

        public frmHome(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            inicializarAtributos();
            llenarHistorialConCompras();
            llenarHistorialConSubastas();
            llenarResumenDeCalificaciones();
            llenarOperacionesSinCalificar();
            llenarCalificacionPromedio();
            llenarCalificacionMasAlta();
            llenarCalificacionMasBaja();
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
                    comprasSinCalificar = DBHelper.ExecuteReader("Venta_GetCantDeVentasSinCalificarSegunCliente", diccionario).ToVentas();
                    return comprasSinCalificar.Count();
                }
            #endregion

            #region Llenar forms
                private void llenarHistorialConCompras() 
                {
                    foreach (var compra in listaDeComprasQueParticipo)
                    {
                        ListViewItem lista = new ListViewItem("Compra inmediata");
                        lista.SubItems.Add(compra.PublicacionId.ToString());
                        lista.SubItems.Add(compra.Fecha.ToString());
                        lista.SubItems.Add(compra.Cantidad.ToString());
                        lista.SubItems.Add("-");
                        lvHistorial.Items.Add(lista);
                    }
                }

                private void llenarHistorialConSubastas() 
                {
                    foreach (var subasta in listaDeSubastasQueParticipo)
                    {
                        ListViewItem lista = new ListViewItem("Subasta");
                        lista.SubItems.Add(subasta.PublicacionId.ToString());
                        lista.SubItems.Add(subasta.Fecha.ToString());
                        lista.SubItems.Add("-");
                        lista.SubItems.Add(subasta.Monto.ToString());
                        lvHistorial.Items.Add(lista);
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
            #endregion

        #endregion
    }
}
