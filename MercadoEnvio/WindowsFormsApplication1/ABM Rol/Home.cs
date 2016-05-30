using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDD.ABM_Rol
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            frmAlta alta = new frmAlta();
            alta.Show();
            this.Hide();
        }
    }
}
