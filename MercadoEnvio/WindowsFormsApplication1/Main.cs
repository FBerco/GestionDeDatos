using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Clases;
using System.Windows.Forms;
using Helpers;

namespace GDD
{
    public partial class Main : Form
    {
        public Usuario usuario;
        public Main(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            var botones = new List<Control>();
            //Obtengo los botones de la vista
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    botones.Add(control);
                }
            }
            var funciones = DBHelper.ExecuteReader("dame funciones").ToFunciones();
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
            { 0, new EventHandler(ABMRol)},
            { 1, new EventHandler(ABMRubro)},
            { 2, new EventHandler(ABMUsuario)},
            { 3, new EventHandler(ABMVisibilidad)},
            { 4, new EventHandler(Calificar)},
            { 5, new EventHandler(ComprarOfertar)},
            { 6, new EventHandler(Facturas)},
            { 7, new EventHandler(GenerarPublicacion)},
            { 8, new EventHandler(HistorialCliente)},
            { 9, new EventHandler(ListadoEstadistico)}
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
            var home = new ABM_Rubro.frmHome();
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
            var home = new ComprarOfertar.frmHome();
            home.Show();
        }
        static void Facturas(object sender, EventArgs e)
        {
            var home = new Facturas.frmHome();
            home.Show();
        }
        static void GenerarPublicacion(object sender, EventArgs e)
        {
            var home = new Generar_Publicación.frmHome();
            home.Show();
        }
        static void HistorialCliente(object sender, EventArgs e)
        {
            var home = new Historial_Cliente.frmHome();
            home.Show();
        }
        static void ListadoEstadistico(object sender, EventArgs e)
        {
            var home = new Listado_Estadistico.frmHome();
            home.Show();
        }

    }
}
