using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GDD
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            GDD.ABM_Rol.Home rol = new ABM_Rol.Home();
            rol.Show();
            this.Hide();
        }

    }
}
