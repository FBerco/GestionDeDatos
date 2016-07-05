using System;
using System.Collections.Generic;
using Clases;
using System.Windows.Forms;
using Helpers;

namespace GDD
{
    public partial class Main : Form
    {
        public static Usuario usuario { get; private set; }
        public Rol rol;
        public Main(Usuario us, Rol ro)
        {
            InitializeComponent();
            usuario = us;
            rol = ro;
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            var funciones = DBHelper.ExecuteReader("RolXFuncion_GetFunByRol", new Dictionary<string, object>() { { "@rol", rol.Id } }).ToFunciones();

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
            { 10, new EventHandler(ListadoEstadistico)}
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
            var home = new ABM_Usuario.frmHome(usuario);
            home.Show();
        }
        static void ABMVisibilidad(object sender, EventArgs e)
        {
            var home = new ABM_Visibilidad.frmHome();
            home.Show();
        }
        static void Calificar(object sender, EventArgs e)
        {
            var home = new Calificar.frmHome();
            home.Show();
        }
        static void ComprarOfertar(object sender, EventArgs e)
        {
            var home = new ComprarOfertar.frmHome(usuario);
            home.Show();
        }
        static void Facturas(object sender, EventArgs e)
        {
            var home = new Facturas.frmListadoDeFacturas();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
