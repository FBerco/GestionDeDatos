using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Helpers;
using Clases;
using System.Security.Cryptography;
using System.Text;

namespace GDD
{
    public partial class LogIn : Form
    {
        public Usuario usuario;
        public List<Rol> roles;
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
                usuario = DBHelper.ExecuteReader("dbo.Usuario_LogIn", parametros).ToUsuario();
                if (usuario != null)
                {
                    roles = DBHelper.ExecuteReader("UsuarioXRol_GetRolesByUser", new Dictionary<string, object>() { { "@Username", usuario.Username } }).ToRoles();
                    if (roles.Count > 1)
                    {
                        cmbRoles.Visible = true;
                        cmbRoles.DataSource = roles;
                        cmbRoles.DisplayMember = "Nombre";
                        btnRol.Visible = true;
                    }
                    else if (roles.Count == 0) {
                        MessageBox.Show("Este usuario no tiene roles asignados");
                    } else
                    {
                        Main main = new Main(usuario, roles.FirstOrDefault());
                        main.Show();
                        Hide();
                    }
                }
                else
                {

                    MessageBox.Show("No existe usuario.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Ingresar Username y Password por favor.", "Error");
            }
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            if (cmbRoles.SelectedIndex != -1)
            {
                Main main = new Main(usuario, (Rol)cmbRoles.SelectedItem);
                main.Show();
                Hide();
            }
        }        
    }
}
