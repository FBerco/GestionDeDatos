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
        public frmHome(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            inicializarAtributos();
            if (listaDeTodasLasComprasYSubastas.Count > 0)
            {
                paginaActual = 1;
                ultimaPagina = getUltimaPagina();
                lblPaginaActual.Text = String.Concat("Pagina ", paginaActual.ToString(), " de ", ultimaPagina.ToString());
                llenarDataGridViewSegunPagina(paginaActual);
                llenarResumenDeCalificaciones();
                llenarCampos();
            }
            else
            {
                MessageBox.Show("No hay listado de compras ni subastas para mostrar ya que el usuario no generó todavia.");
                btnNextPage.Enabled = false;
                btnPrevPage.Enabled = false;
                txtIrAPagina.Enabled = false;
                btnOkIrAPagina.Enabled = false;
            }
        }

        #region Atributos
       
        private Usuario usuario;
        private Cliente cliente;
        private List<Venta> listaDeComprasQueParticipo;
        private List<Venta> comprasSinCalificar;
        private List<Oferta> listaDeSubastasQueParticipo;
        private List<Calificacion> calificaciones;
        private int ultimaFilaInsertada;
        private List<ElementoHistorial> listaDeTodasLasComprasYSubastas;
        private int paginaActual;
        private int ultimaPagina;
        private int cantXPagina = 21;

        private void inicializarAtributos()
        {
            cliente = DBHelper.ExecuteReader("Cliente_GetClienteSegunUsuario", new Dictionary<string, object>() { { "@username", usuario.Username } }).ToCliente();
            listaDeComprasQueParticipo = DBHelper.ExecuteReader("Ventas_GetVentasSegunCliente", new Dictionary<string, object>() { { "@clieID", cliente.Id } }).ToVentas();
            //Por que es un listado de ofertas y el listado de compras es de ventas?
            listaDeSubastasQueParticipo = DBHelper.ExecuteReader("Oferta_GetOfertasSegunCliente", new Dictionary<string, object>() { { "@clieID", cliente.Id } }).ToOfertas();
            calificaciones = DBHelper.ExecuteReader("Calificacion_GetCalificacionesSegunCliente", new Dictionary<string, object>() { { "@clieID", cliente.Id } }).ToCalificaciones();
            listaDeTodasLasComprasYSubastas = getListaDeTodasLasComprasYSubastas();
        }
        #endregion
               
        #region Get Valores

        private int getCantidadDeOperacionesSinCalificar()
        {
            comprasSinCalificar = DBHelper.ExecuteReader("Venta_GetVentasSinCalificarSegunCliente", new Dictionary<string, object> { { "@clieID", cliente.Id } }).ToVentas();
            return comprasSinCalificar.Count();
        }
        
        private List<ElementoHistorial> getListaDeTodasLasComprasYSubastas()
        {
            List<ElementoHistorial> lista = new List<ElementoHistorial>();
            foreach (var compra in listaDeComprasQueParticipo)
            {
                lista.Add(new ElementoHistorial
                {
                    Tipo = "Compra Inmediata",
                    PublicacionID = compra.PublicacionId.ToString(),
                    Fecha = compra.Fecha,   //modificado recien (.ToString())
                    Cantidad = compra.Cantidad.ToString(),
                    Monto = "-"
                });
            }
            foreach (var subasta in listaDeSubastasQueParticipo.OrderBy(x=>x.PublicacionId))
            {
                lista.Add(new ElementoHistorial
                {
                    Tipo = "Subasta",
                    PublicacionID = subasta.PublicacionId.ToString(),
                    Fecha = subasta.Fecha,  //idem arriba
                    Cantidad = "-",
                    Monto = subasta.Monto.ToString()
                });
            }
            return lista;
        }

        private int getUltimaPagina()
        {
            Double cantElementos = listaDeTodasLasComprasYSubastas.Count;
            Double cantDePaginas = cantElementos / cantXPagina;
            int parteEntera = (int)cantDePaginas;
            ultimaPagina = parteEntera;
            if (cantDePaginas - parteEntera > 0) ultimaPagina++;
            return ultimaPagina;
        }

        #endregion
        
        #region Llenar forms
        
        private void llenarDataGridViewSegunPagina(int numeroPagina)
        {
           
                dgvHistorial.Rows.Clear();
                List<ElementoHistorial> elementosAMostrar = new List<ElementoHistorial>();
                int ultimaCantidadDeElementos = (listaDeTodasLasComprasYSubastas.Count - 1) - ((ultimaPagina - 1) * cantXPagina);
                if (numeroPagina == ultimaPagina)
                {
                    elementosAMostrar = listaDeTodasLasComprasYSubastas.GetRange((ultimaPagina - 1) * cantXPagina, ultimaCantidadDeElementos);
                }
                else
                {
                    elementosAMostrar = listaDeTodasLasComprasYSubastas.GetRange(((numeroPagina - 1) * cantXPagina), cantXPagina);
                }
                int fila = 0;
                foreach (var elem in elementosAMostrar)
                {
                    dgvHistorial.Rows.Insert(fila, elem.Tipo, elem.PublicacionID, elem.Fecha.ToString(), elem.Cantidad, elem.Monto);
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

        private void llenarCampos() {
            //llenarOperacionesCalificadas
            txtOperacionesCalificadas.Text = calificaciones.Count.ToString();
            
            //llenarOperacionesSinCalificar
            txtOperacionesSinCalificar.Text = getCantidadDeOperacionesSinCalificar().ToString();
            
            //llenarCalificacionPromedio
            double promedio = calificaciones.Select(calificacion => calificacion.Estrellas).Average();
            txtCalificacionPromedio.Text = promedio.ToString().Substring(0, 4);

            //llenarCalificacionMasAlta
            txtCalificacionMasAlta.Text = calificaciones.Select(calificacion => calificacion.Estrellas).Max().ToString();

            //llenarCalificacionMasBaja
            txtCalificacionMasBaja.Text = calificaciones.Select(calificacion => calificacion.Estrellas).Min().ToString();

            //llenarCantidadDeTransacciones
            txtCantTransacciones.Text = (listaDeComprasQueParticipo.Count + listaDeSubastasQueParticipo.Count).ToString();

            //llenarCantidadDeCompras
            txtCantCompras.Text = listaDeComprasQueParticipo.Count.ToString();

            //llenarCantidadDeSubastas
            txtCantSubastas.Text = listaDeSubastasQueParticipo.Count.ToString();
        }
                    
        #endregion
        
        #region Botones

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (!(paginaActual - 1 == 0))
            {
                paginaActual = paginaActual - 1;
                lblPaginaActual.Text = String.Concat("Pagina ", paginaActual.ToString(), " de ", ultimaPagina.ToString());
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

        private void btnOkIrAPagina_Click(object sender, EventArgs e)
        {
            int paginaNueva = System.Int32.Parse(txtIrAPagina.Text);
            if (paginaNueva > ultimaPagina || paginaNueva == 0) { MessageBox.Show("No existe la pagina", "Error"); }
            else
            {
                paginaActual = paginaNueva;
                lblPaginaActual.Text = String.Concat("Pagina ", paginaActual.ToString(), " de ", ultimaPagina.ToString());
                llenarDataGridViewSegunPagina(paginaActual);
            }
            txtIrAPagina.Clear();
        }

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
    }
}
