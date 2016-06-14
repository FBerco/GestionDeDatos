using Clases;
using Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace GDD.ABM_Rol
{
    public partial class frmBaja : Form
    {
        List<Rol> roles;
        public frmBaja()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in lstRoles.Items)
                {
                    var nombre = (string)item;
                    var rol = roles.First(x => x.Nombre == nombre);
                    if (lstRoles.CheckedItems.Contains(item))
                    {
                        //Si está chequeado y no estaba, lo agrego   
                        if (!rol.Activo)
                        {
                            DBHelper.ExecuteNonQuery("Rol_Activate", new Dictionary<string, object>() { { "@rol", rol.Id } });
                        }
                    }
                    else
                    {
                        //No esta chequedado y si estaba, lo borro
                        if (rol.Activo)
                        {
                            DBHelper.ExecuteNonQuery("Rol_Deactivate", new Dictionary<string, object>() { { "@rol", rol.Id } });
                        }
                    }
                }
                MessageBox.Show("Guardado con exito");
            }
            catch 
            {
                MessageBox.Show("Hubo un error en la baja", "Error");
            }
           
        }     

        private void frmBaja_Load(object sender, EventArgs e)
        {
            roles = DBHelper.ExecuteReader("Rol_GetAll").ToRoles();
            foreach (var rol in roles)
            {
                //Chequeo aquellas que tiene seleccionada
                lstRoles.Items.Add(rol.Nombre, rol.Activo);
            }
        }

        private void frmBaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            var home = new frmHome();
            home.Show();
            Hide();
        }
    }
}
