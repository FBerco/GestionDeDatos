using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Helpers;

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
            var username = txtUsername.Text;
            var password= txtPassword.Text;
            if (username != null && password != null)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Username", username);
                parametros.Add("@Password", password);
                var usuario = DBHelper.ExecuteReader("Usuario_LogIn", parametros);
                if (usuario != null)
                {
                    //Sigo adelante
                }
                lblError.Text = "no existe usuario";
            }
            lblError.Text = "Ingresar Username y Password por favor.";
        }
    }
}
