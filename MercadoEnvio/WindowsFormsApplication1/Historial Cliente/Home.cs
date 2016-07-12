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
        #region Atributos
        private Usuario usuario;
        private Cliente cliente;
        private List<Venta> listaDeComprasQueParticipo;
        private List<Venta> comprasSinCalificar;
        private List<Oferta> listaDeSubastasQueParticipo;
        private List<Calificacion> calificaciones;
        private int ultimaFilaInsertada;
        private List<ElementoHistorial> listaDeTodo;
        private int paginaActual;
        private int ultimaPagina;
        private int cantXPagina = 21;
        #endregion

        public frmHome(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            inicializarAtributos();
            paginaActual = 1;
            ultimaPagina = getUltimaPagina();
            lblPaginaActual.Text = String.Concat("Pagina ", paginaActual.ToString(), " de ", ultimaPagina.ToString());
            llenarDataGridViewSegunPagina(paginaActual);
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
            listaDeTodo = getListaDeTodo();
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

                private List<ElementoHistorial> getListaDeTodo()
                {
                    List<ElementoHistorial> lista = new List<ElementoHistorial>();
                    foreach (var compra in listaDeComprasQueParticipo)
                    {
                        lista.Add(new ElementoHistorial
                        {
                            Tipo = "Compra Inmediata",
                            PublicacionID = compra.PublicacionId.ToString(),
                            Fecha = compra.Fecha.ToString(),
                            Cantidad = compra.Cantidad.ToString(),
                            Monto = "-"
                        });
                    }
                    foreach (var subasta in listaDeSubastasQueParticipo)
                    {
                        lista.Add(new ElementoHistorial
                        {
                            Tipo = "Subasta",
                            PublicacionID = subasta.PublicacionId.ToString(),
                            Fecha = subasta.Fecha.ToString(),
                            Cantidad = "-",
                            Monto = subasta.Monto.ToString()
                        });
                    }
                    return lista;
                }
            #endregion

            #region Llenar forms

                private void llenarDataGridViewConCompras()
                {
                    int fila = 0;
                    
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

       
        #endregion

        #region Validaciones

                private void txtIrAPagina_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    {
                        MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }

        #endregion

        private void llenarDataGridViewSegunPagina(int numeroPagina) 
        {
            dgvHistorial.Rows.Clear();
            List<ElementoHistorial> elementosAMostrar = new List<ElementoHistorial>();
            int ultimaCantidadDeElementos = (listaDeTodo.Count - 1) - ((ultimaPagina - 1) * cantXPagina);
            if (numeroPagina == ultimaPagina)
            {
                elementosAMostrar = listaDeTodo.GetRange((ultimaPagina - 1) * cantXPagina, ultimaCantidadDeElementos);
            }
            else
            {
                elementosAMostrar = listaDeTodo.GetRange(((numeroPagina - 1) * cantXPagina), cantXPagina);
            }
            int fila = 0;
            foreach (var elem in elementosAMostrar) 
            {
                dgvHistorial.Rows.Insert(fila,elem.Tipo,elem.PublicacionID,elem.Fecha,elem.Cantidad,elem.Monto);
                fila++;
            }
        }

        

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (!(paginaActual - 1 == 0))
            {
                paginaActual = paginaActual - 1;
                lblPaginaActual.Text = String.Concat("Pagina ",paginaActual.ToString()," de ",ultimaPagina.ToString());
                llenarDataGridViewSegunPagina(paginaActual);
            }
            else
            {
                paginaActual = 1;
                lblPaginaActual.Text = String.Concat("Pagina ", paginaActual.ToString(), " de ", ultimaPagina.ToString());
                llenarDataGridViewSegunPagina(paginaActual);
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if ((paginaActual + 1 > ultimaPagina))
            {
                paginaActual = ultimaPagina;
                lblPaginaActual.Text = String.Concat("Pagina ", paginaActual.ToString(), " de ", ultimaPagina.ToString());
                llenarDataGridViewSegunPagina(paginaActual);
            }
            else
            {
                paginaActual = paginaActual + 1;
                lblPaginaActual.Text = String.Concat("Pagina ", paginaActual.ToString(), " de ", ultimaPagina.ToString());
                llenarDataGridViewSegunPagina(paginaActual);
            }
        }
        

        private int getUltimaPagina() 
        {
            Double cantElementos = listaDeTodo.Count;
            Double cantDePaginas = cantElementos / cantXPagina;
            int parteEntera = (int)cantDePaginas;
            ultimaPagina = parteEntera;
            if (cantDePaginas - parteEntera > 0) ultimaPagina++;
            return ultimaPagina;
        }

        private void btnOkIrAPagina_Click(object sender, EventArgs e)
        {
            int paginaNueva = System.Int32.Parse(txtIrAPagina.Text);
            if ( paginaNueva > ultimaPagina || paginaNueva == 0) { MessageBox.Show("No existe la pagina", "Error"); }
            else 
            {
                paginaActual = paginaNueva;
                lblPaginaActual.Text = String.Concat("Pagina ", paginaActual.ToString(), " de ", ultimaPagina.ToString());
                llenarDataGridViewSegunPagina(paginaActual); 
            }
            txtIrAPagina.Clear();
        }

       

    }
}
