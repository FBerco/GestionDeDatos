using System;
using System.Collections.Generic;
using Helpers;
using Clases;
using System.Windows.Forms;

namespace GDD.ABM_Rol
{
    public partial class frmAlta : Form
    {
        public List<Funcion> funciones;
        public List<Funcion> funcionesXRol;
        public frmAlta()
        {
            InitializeComponent();
            funciones = DBHelper.ExecuteReader("Funciones_GetAll").ToFunciones();
            funcionesXRol = DBHelper.ExecuteReader("RolXFuncion_GetFunByRol", new Dictionary<string, object>() { { "@rol", rol.Id } })
            setList();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text;
            var rol = DBHelper.ExecuteReader("Rol_Exists", new Dictionary<string, object>() { { "@nombre", nombre } }).ToRol();
            if (rol != null)
            {
                var funciones = lstFunciones.SelectedItems;
                if (funciones.Count > 0)
                {
                    foreach (Funcion fun in funciones)
                    {
                        DBHelper.ExecuteNonQuery("RolXFuncion_Add", new Dictionary<string, object>() { { "@Rol", rol.Id }, { "@Funcion", fun.Id } });
                    }
                    MessageBox.Show("Insertado con exito");
                    txtNombre.Text = "";
                    lstFunciones = new CheckedListBox();
                    setList();
                }else {
                    MessageBox.Show("Seleccione funciones");
                }
            }
            MessageBox.Show("Ya existe el rol");
            
        }

        private void frmAlta_FormClosing(object sender, FormClosingEventArgs e)
        {
            var home = new frmHome();
            home.Show();
            Hide();
        }

        private void setList() {
            foreach (var fun in funciones)
            {
                lstFunciones.Items.Add(fun);
            }
            lstFunciones.
        }
    }
}
