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
            setList();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text;
            var rol = DBHelper.ExecuteReader("Rol_Exists", new Dictionary<string, object>() { { "@nombre", nombre } }).ToRol();
            if (rol != null)
            {
                var funcionesSeleccionadas = lstFunciones.SelectedItems;
                if (funciones.Count > 0)
                {
                    foreach (string fun in funcionesSeleccionadas)
                    {
                        DBHelper.ExecuteNonQuery("RolXFuncion_Add", new Dictionary<string, object>() { { "@rol", rol.Id }, { "@funcion", funciones.FirstOrDefault(x=>x.Descripcion == fun).Id } });
                    }
                    MessageBox.Show("Insertado con exito");
                    txtNombre.Text = "";
                    lstFunciones = new CheckedListBox();
                    setList();
                }else {
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

        private void setList() {
            foreach (var fun in funciones)
            {
                //Chequeo aquellas que tiene seleccionada
                lstFunciones.Items.Add(fun.Descripcion);
            }
        }
    }
}
