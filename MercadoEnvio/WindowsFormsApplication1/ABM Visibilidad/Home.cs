using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDD.ABM_Visibilidad
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta alta = new frmAlta();
            alta.Show();
            this.Hide();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmBaja baja = new frmBaja();
            baja.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificar modificar = new frmModificar();
            modificar.Show();
            this.Hide();
        }
    }
}
