using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
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
            ProcesarSubastasVencidas();
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
                    var usu = DBHelper.ExecuteReader("Usuario_Get", new Dictionary<string, object>() { { "@usuario", username } }).ToUsuario();
                    if (usu != null && usu.Intentos >= 3)
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
        
        private void ProcesarSubastasVencidas()
        {
            var publicaciones = DBHelper.ExecuteReader("Publicacion_SubastasAFinalizarPorVencimiento", new Dictionary<string, object>() { { "@hoy", ConfigurationManager.AppSettings["fecha"] } }).ToPublicaciones();

            foreach (var publ in publicaciones)
            {
                var factura = DBHelper.ExecuteReader("Factura_GetByPublicacion", new Dictionary<string, object>() { { "@publicacion", publ.Id } }).ToFactura();
                var items = DBHelper.ExecuteReader("ItemFactura_GetByFactura", new Dictionary<string, object>() { { "@factura", factura.Numero } }).ToItemFacturas();
                //Actualizo item de envio
                var itemEnvio = items.FirstOrDefault(x => x.Detalle == "CostoEnvio");
                if (itemEnvio != null)
                {
                    DBHelper.ExecuteNonQuery("ItemFactura_ModificarCantidad", new Dictionary<string, object>() { { "@item", itemEnvio.Id }, { "@cantidad", publ.Stock } });
                }
                //Item porcentaje
                ItemFactura itemPorcentaje = items.FirstOrDefault(x => x.Detalle == "ItemPorcentaje");
                if (itemPorcentaje != null)
                {
                    DBHelper.ExecuteNonQuery("ItemFactura_ModificarCantidad", new Dictionary<string, object>() { { "@item", itemPorcentaje.Id }, { "@cantidad", publ.Stock } });
                }

                //Actualizo el total de facturas
                decimal total = 0;
                foreach (var item in items)
                {
                    if (itemPorcentaje != null && item.Detalle == itemPorcentaje.Detalle)
                    {
                        total = total + itemPorcentaje.PrecioUnitario * publ.Stock;
                    }
                    else if (itemEnvio != null && item.Detalle == itemEnvio.Detalle)
                    {
                        total = total + itemEnvio.PrecioUnitario * publ.Stock;
                    }
                    else
                    {
                        total = total + item.PrecioUnitario * item.Cantidad;
                    }
                }
                DBHelper.ExecuteNonQuery("Factura_ActualizarTotal", new Dictionary<string, object>() { { "@factura", factura.Numero }, { "@total", total } });

                //Doy como finalizada la publicacion
                DBHelper.ExecuteNonQuery("Publicacion_Finalizar", new Dictionary<string, object>() { { "@publicacion", publ.Id} });
            }
        }
    }
}
