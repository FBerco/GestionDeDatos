using System;
using System.Linq;
using System.Collections.Generic;
using Helpers;
using Clases;
using System.Windows.Forms;

namespace GDD.ABM_Rol
{
    public partial class frmAlta : Form
    {
        public List<Funcion> funciones;
        public frmAlta()
        {
            InitializeComponent();
            funciones = DBHelper.ExecuteReader("Funciones_GetAll").ToFunciones();
<<<<<<< HEAD
            setList();
=======
            foreach (var fun in funciones)
            {
                //Chequeo aquellas que tiene seleccionada
                lstFunciones.Items.Add(fun.Descripcion, CheckState.Unchecked);
            }
>>>>>>> origin/master
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text;
<<<<<<< HEAD
            var rol = DBHelper.ExecuteReader("Rol_Exists", new Dictionary<string, object>() { { "@Nombre", nombre } }).ToRol();
            if (rol != null)
=======
            var rol = DBHelper.ExecuteReader("Rol_Exists", new Dictionary<string, object>() { { "@rol", nombre } }).ToRol();
            if (rol == null)
>>>>>>> origin/master
            {
                var funcionesSeleccionadas = lstFunciones.CheckedItems;
                if (funcionesSeleccionadas.Count > 0)
                {
                    try
                    {                    
                        DBHelper.ExecuteNonQuery("Rol_Add", new Dictionary<string, object>() { { "@rol", nombre } });
                        rol = DBHelper.ExecuteReader("Rol_GetByName", new Dictionary<string, object>() { { "@nombre", nombre } }).ToRol();
                        foreach (string fun in funcionesSeleccionadas)
                        {
                            var id = funciones.FirstOrDefault(x => x.Descripcion == fun).Id;
                            DBHelper.ExecuteNonQuery("RolXFuncion_Add", new Dictionary<string, object>() { { "@rol", rol.Id }, { "@funcion", id} });
                        }
                        MessageBox.Show("Insertado con exito");
                        txtNombre.Text = "";
                        lstFunciones.ClearSelected();
                    }
                    catch 
                    {
<<<<<<< HEAD
                        DBHelper.ExecuteNonQuery("RolXFuncion", new Dictionary<string, object>() { { "@Rol", rol.Id }, { "@Funcion", fun.Id } });
=======
                        MessageBox.Show("Hubo un error en el alta", "Error");
>>>>>>> origin/master
                    }
                }
                else {
                    MessageBox.Show("Seleccione funciones");
                }
            }
            else
            {
                MessageBox.Show("Ya existe el rol");
            }            
        }

        private void frmAlta_FormClosing(object sender, FormClosingEventArgs e)
        {
            var home = new frmHome();
            home.Show();
            Hide();
        }
<<<<<<< HEAD

        private void setList() {
            foreach (var fun in funciones)
            {
                lstFunciones.Items.Add(fun);
            }
        }
=======
>>>>>>> origin/master
    }
}
