using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Helpers;

using System.Windows.Forms;

namespace GDD.ABM_Usuario
{
    public partial class frmAlta : Form
    {
        public frmAlta()
        {
            InitializeComponent();
        }

        private void Alta_Load(object sender, EventArgs e)
        {

        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {             
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text) && (rdbCliente.Checked == true || rdbEmpresa.Checked == true))
            {
                if (DBHelper.ExecuteReader("Usuario_Get", new Dictionary<string, object> { { "@usuario", txtUsername.Text } }).ToUsuario() == null)
                {                
                    var user = new Usuario()
                    {
                        Username = txtUsername.Text,
                        Password = txtPassword.Text
                    };
                    if (rdbCliente.Checked==true)
                    {
                        frmCliente cli = new frmCliente(user);
                        cli.Show();
                    }
                    else
                    {
                        frmEmpresa emp = new frmEmpresa(user);
                        emp.Show();
                    }
                    Hide();
                }
                else
                {
                    MessageBox.Show("Usuario existente");
                }
            }
            else
            {
                MessageBox.Show("Complete los campos.");
            }
        }
    }
}
