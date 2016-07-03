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
    public partial class frmHome : Form
    {
        private Usuario usuario;

        public frmHome(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta alta = new frmAlta();
            alta.Show();
        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            frmContraseña con = new frmContraseña(usuario);
            Show();
        }
    }
}
