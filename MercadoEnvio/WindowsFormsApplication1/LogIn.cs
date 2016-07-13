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
        private Dictionary<string, int> intentos;
        public LogIn()
        {
            InitializeComponent();
            intentos = new Dictionary<string, int>();
        }
        

        private void btnLoguear_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password= txtPassword.Text;
            if (username != null && password != null)
            {
                usuario = DBHelper.ExecuteReader("Usuario_Get", new Dictionary<string, object>() { { "@usuario", username } }).ToUsuario();
                if (usuario != null && !usuario.Habilitado)
                {                    
                    MessageBox.Show("Usuario Inhabilitado. El administrador debe volver a habilitarlo");
                    return;
                }
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Username", username);
                parametros.Add("@Password", password);
                usuario = DBHelper.ExecuteReader("Usuario_LogIn", parametros).ToUsuario();
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
                    DBHelper.ExecuteNonQuery("Usuario_SumarIntento", new Dictionary<string, object>() { { "@Username", username } });
                    var usuario = DBHelper.ExecuteReader("Usuario_Get", new Dictionary<string, object>() { { "@usuario", username } }).ToUsuario();
                    if (usuario != null && usuario.Intentos >= 3)
                    {                        
                        DBHelper.ExecuteNonQuery("Usuario_Inhabilitar", new Dictionary<string, object> { { "@Username", username } });
                        MessageBox.Show("Usuario ha quedado inhabilitado");
                    }
                    else
                    {
                        MessageBox.Show("Password no corresponde con Username.", "Error");
                    }
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
