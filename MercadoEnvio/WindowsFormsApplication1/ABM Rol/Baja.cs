using Clases;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;

namespace GDD.ABM_Rol
{
    public partial class frmBaja : Form
    {
        List<Rol> roles;
        public frmBaja()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var rol = (Rol)cmbRoles.SelectedItem;
            DBHelper.ExecuteNonQuery("Rol_Deactivate", new Dictionary<string, object>() { { "@rol", rol.Id } });
            MessageBox.Show("Dado de baja con exito");
            LoadRoles();
        }     

        private void frmBaja_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void LoadRoles()
        {
            roles = DBHelper.ExecuteReader("Rol_GetAll").ToRoles();
            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "Nombre";
        }

        private void frmBaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            var home = new frmHome();
            home.Show();
            Hide();
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rol = (Rol)cmbRoles.SelectedItem;
            btnGuardar.Enabled = rol.Activo;
        }
    }
}
