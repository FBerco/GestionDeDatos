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
                DBHelper.ExecuteNonQuery("Usuario_CambiarContraseña", new Dictionary<string, object>() { { "@Usuario", usuario.Username}, { "@Password", txtContraseña.Text } });
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
