using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDD
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLoguear_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parametros = new Dictionary<string, string>();
            var username = txtUsername.Text;
            var password= txtPassword.Text;
            if (username != null && password != null)
            {
                parametros.Add("@Username", username);
                parametros.Add("@Password", password);
            }
            lblError.Text = "Ingresar Username y Password por favor.";
        }
    }
}
