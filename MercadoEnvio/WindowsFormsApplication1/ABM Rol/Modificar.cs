﻿using Clases;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;

namespace GDD.ABM_Rol
{
    public partial class frmModificar : Form
    {
        List<Rol> roles;
        List<Funcion> funciones, funcionesXRol;
        public frmModificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            funciones = DBHelper.ExecuteReader("Funciones_GetAll").ToFunciones();
            SetRoles();          
        }

        private void SetRoles() {
            roles = DBHelper.ExecuteReader("Rol_GetAll").ToRoles();
            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "Nombre";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var rolAsignado = (Rol)cmbRoles.SelectedItem;
            if (txtNombre.Text != string.Empty)
            {
                try
                {                   
                    if (txtNombre.Text != rolAsignado.Nombre.Trim())
                    {
                        DBHelper.ExecuteNonQuery("Rol_ModifyName", new Dictionary<string, object>() { { "@nombre", txtNombre.Text }, { "@id", rolAsignado.Id } });
                    }

                    foreach (var item in lstFunciones.Items)
                    {
                        var nombre = (string)item;
                        if (lstFunciones.CheckedItems.Contains(item))
                        {                           
                            //Si está chequeado y no estaba, lo agrego   
                            if (!funcionesXRol.Exists(x => x.Descripcion == nombre))
                            {
                                DBHelper.ExecuteNonQuery("RolXFuncion_Add", new Dictionary<string, object>() { { "@rol", rolAsignado.Id }, { "@funcion", funciones.First(x => x.Descripcion == nombre).Id } });
                            }
                        }
                        else
                        {
                            //No esta chequedado y si estaba, lo borro
                            if (funcionesXRol.Exists(x => x.Descripcion == nombre))
                            {
                                DBHelper.ExecuteNonQuery("RolXFuncion_Remove", new Dictionary<string, object>() { { "@rol", ((Rol)cmbRoles.SelectedItem).Id }, { "@funcion", funciones.First(x => x.Descripcion == nombre).Id } });
                            }
                        }
                    }
                    MessageBox.Show("Modificado con exito");
                    SetRoles();
                }
                catch 
                {
                    MessageBox.Show("Hubo un error en la modificacion", "Error");
                }                
            }
            else
            {
                MessageBox.Show("No puede quedar vacío el nombre del rol");
            }
        }

        private void frmModificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            var home = new frmHome();
            home.Show();
            Hide();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            var rolAsignado = (Rol)cmbRoles.SelectedItem;
            DBHelper.ExecuteNonQuery("Rol_Activate", new Dictionary<string, object>() { { "@rol", rolAsignado.Id }});
            MessageBox.Show("Rol activado nuevamente");
            btnActivar.Visible = false;
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFunciones.Enabled = true;
            var rol = (Rol)cmbRoles.SelectedItem;
            funcionesXRol = DBHelper.ExecuteReader("RolXFuncion_GetFunByRol", new Dictionary<string, object>() { { "@rol", rol.Id } }).ToFunciones();
            lstFunciones.Items.Clear();
            foreach (var fun in funciones)
            {
                //Chequeo aquellas que tiene seleccionada
                lstFunciones.Items.Add(fun.Descripcion, funcionesXRol.Exists(x => x.Id == fun.Id));
            }
            txtNombre.Text = rol.Nombre;
            btnActivar.Visible = !rol.Activo;
        }        
    }
}
