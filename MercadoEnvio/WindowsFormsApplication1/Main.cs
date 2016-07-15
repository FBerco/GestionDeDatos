using System;
using System.Collections.Generic;
using Clases;
using System.Windows.Forms;
using Helpers;
using System.Linq;
using System.Configuration;

namespace GDD
{
    public partial class Main : Form
    {
        public static Usuario usuario { get; private set; }
        public static Rol rol;
        public Main(Usuario us, Rol ro)
        {
            InitializeComponent();
            usuario = us;
            rol = ro;
            ProcesarSubastasVencidas();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            var funciones = DBHelper.ExecuteReader("RolXFuncion_GetFunByRol", new Dictionary<string, object>() { { "@rol", rol.Id } }).ToFunciones();
            //Agrego funcionalidad de cambiar contraseña que es para todos
            funciones.Add(new Funcion() { Id = 11, Descripcion = "Cambiar contraseña" });
            var botones = new List<Control>();
            //Obtengo los botones de la vista
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    botones.Add(control);
                }
            }
            botones.Reverse();
            int i = 0;
            foreach (Funcion fun in funciones)
            {
                botones[i].Visible = true;
                botones[i].Text = fun.Descripcion;
                botones[i].Click += dicFunciones[fun.Id];
                i++;
            }
        }

        Dictionary<int, EventHandler> dicFunciones = new Dictionary<int, EventHandler>() {
            { 1, new EventHandler(ABMRol)},
            { 2, new EventHandler(ABMRubro)},
            { 3, new EventHandler(ABMUsuario)},
            { 4, new EventHandler(ABMVisibilidad)},
            { 5, new EventHandler(Calificar)},
            { 6, new EventHandler(ComprarOfertar)},
            { 7, new EventHandler(Facturas)},
            { 8, new EventHandler(GenerarPublicacion)},
            { 9, new EventHandler(HistorialCliente)},
            { 10, new EventHandler(ListadoEstadistico)},
            { 11, new EventHandler(CambiarContraseña)}
        };

        static void ABMRol(object sender, EventArgs e) {
            var home = new ABM_Rol.frmHome();
            home.Show();
        }
        static void ABMRubro(object sender, EventArgs e)
        {
            var home = new ABM_Rubro.frmHome();
            home.Show();
        }
        static void ABMUsuario(object sender, EventArgs e)
        {
            var home = new ABM_Usuario.frmHome();
            home.Show();
        }
        static void ABMVisibilidad(object sender, EventArgs e)
        {
            var home = new ABM_Visibilidad.frmHome();
            home.Show();
        }
        static void Calificar(object sender, EventArgs e)
        {
            var home = new Calificar.frmHome(usuario);
            home.Show();
        }
        static void ComprarOfertar(object sender, EventArgs e)
        {
            var home = new ComprarOfertar.frmHome(usuario);
            home.Show();
        }
        static void Facturas(object sender, EventArgs e)
        {
            var esAdmin = rol.Id == 1;
            var home = new Facturas.frmListadoDeFacturas(usuario, esAdmin);
            home.Show();
        }
        static void GenerarPublicacion(object sender, EventArgs e)
        {
            var home = new Generar_Publicación.frmHome(usuario);
            home.Show();
        }
        static void HistorialCliente(object sender, EventArgs e)
        {
            var home = new Historial_Cliente.frmHome(usuario);
            home.Show();
        }
        static void ListadoEstadistico(object sender, EventArgs e)
        {
            var home = new Listado_Estadistico.frmHome();
            home.Show();
        }

        static void CambiarContraseña(object sender, EventArgs e)
        {
            var home = new ABM_Usuario.frmContraseña(usuario);
            home.Show();
        }

        static void CerrarSesion(object sender, EventArgs e)
        {
            var home = new LogIn();
            home.Show();
        }

        private void ProcesarSubastasVencidas()
        {
            var publicaciones = DBHelper.ExecuteReader("Publicacion_SubastasAFinalizarPorVencimiento", new Dictionary<string, object>() { { "@hoy", ConfigurationManager.AppSettings["fecha"] } }).ToPublicaciones();
            if (publicaciones.Count > 0)
            {
                MessageBox.Show(string.Format("Se está corriendo el proceso para finalizar subastas vencidas. Se encontraron {0} para procesar. Puede tardar unos segundos, por favor tenga paciencia.", publicaciones.Count));
                foreach (var publ in publicaciones)
                {
                    var factura = DBHelper.ExecuteReader("Factura_GetByPublicacion", new Dictionary<string, object>() { { "@publicacion", publ.Id } }).ToFactura();
                    var items = DBHelper.ExecuteReader("ItemFactura_GetByFactura", new Dictionary<string, object>() { { "@factura", factura.Numero } }).ToItemFacturas();
                    //Actualizo item de envio
                    var itemEnvio = items.FirstOrDefault(x => x.Detalle == "CostoEnvio");
                    if (itemEnvio != null)
                    {
                        DBHelper.ExecuteNonQuery("ItemFactura_ModificarCantidad", new Dictionary<string, object>() { { "@item", itemEnvio.Id }, { "@cantidad", publ.Stock } });
                    }
                    //Item porcentaje
                    ItemFactura itemPorcentaje = items.FirstOrDefault(x => x.Detalle == "ItemPorcentaje");
                    if (itemPorcentaje != null)
                    {
                        DBHelper.ExecuteNonQuery("ItemFactura_ModificarCantidad", new Dictionary<string, object>() { { "@item", itemPorcentaje.Id }, { "@cantidad", publ.Stock } });
                    }

                    //Actualizo el total de facturas
                    decimal total = 0;
                    foreach (var item in items)
                    {
                        if (itemPorcentaje != null && item.Detalle == itemPorcentaje.Detalle)
                        {
                            total = total + itemPorcentaje.PrecioUnitario * publ.Stock;
                        }
                        else if (itemEnvio != null && item.Detalle == itemEnvio.Detalle)
                        {
                            total = total + itemEnvio.PrecioUnitario * publ.Stock;
                        }
                        else
                        {
                            total = total + item.PrecioUnitario * item.Cantidad;
                        }
                    }
                    DBHelper.ExecuteNonQuery("Factura_ActualizarTotal", new Dictionary<string, object>() { { "@factura", factura.Numero }, { "@total", total } });

                    //Doy como finalizada la publicacion
                    DBHelper.ExecuteNonQuery("Publicacion_Finalizar", new Dictionary<string, object>() { { "@publicacion", publ.Id } });
                }
            }
        }
    }
}
