using System;
using System.Collections.Generic;
using Clases;
using Helpers;
using System.Windows.Forms;

namespace GDD.ABM_Usuario
{
    public partial class frmContraseña : Form
    {
        private Usuario usuario;
        public frmContraseña(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != null)
            {
                DBHelper.ExecuteNonQuery("Usuario_CambiarContraseña", new Dictionary<string, object>() { { "@Username", usuario.Username}, { "@Password", txtContraseña.Text } });
                MessageBox.Show("Contraseña cambiada");
                Hide();
            }
            else
            {
                MessageBox.Show("Escriba una contraseña");
            }
        }
    }
}
