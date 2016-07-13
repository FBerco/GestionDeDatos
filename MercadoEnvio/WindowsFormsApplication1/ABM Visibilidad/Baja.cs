using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Helpers;
using Clases;

namespace GDD.ABM_Visibilidad
{
    public partial class frmBaja : Form
    {

        private List<Visibilidad> visibilidades;

        public frmBaja()
        {
            InitializeComponent();
        }

        private void frmBaja_Load(object sender, EventArgs e)
        {
            LoadVisibilidades();
        }

        private void LoadVisibilidades()
        {
            cmbNombreVisibilidad.DataSource = DBHelper.ExecuteReader("Visibilidad_GetAll").ToVisibilidades();
            cmbNombreVisibilidad.DisplayMember = "Detalle";
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Visibilidad visibilidadElegida = (Visibilidad)cmbNombreVisibilidad.SelectedItem;
            if (!estaAsociadaAAlgunUsuario(visibilidadElegida))
            { 
                darDeBaja(visibilidadElegida);
                MessageBox.Show(string.Concat("Se dio de baja: ",visibilidadElegida.Detalle));
            } 
            else {
                MessageBox.Show("La visibilidad seleccionada esta asociada a un usuario. No se puede dar de baja");
            }
            LoadVisibilidades();
        }

        private bool estaAsociadaAAlgunUsuario(Visibilidad unaVisibilidad)
        {
            List<Visibilidad> visibilidadesAsociadasAUnUsuario = DBHelper.ExecuteReader("Visibilidad_GetVisibilidadesAsociadas").ToVisibilidades();
            return visibilidadesAsociadasAUnUsuario.ConvertAll(visi => visi.Detalle).Contains(unaVisibilidad.Detalle);
        }

        private void darDeBaja(Visibilidad unaVisibilidad)
        {
            Dictionary<string, object> nuevoDiccionario = new Dictionary<string, object>();
            nuevoDiccionario.Add("@visi_id", unaVisibilidad.Id);
            DBHelper.ExecuteNonQuery("Visibilidad_Baja", nuevoDiccionario);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }       
    }
}
