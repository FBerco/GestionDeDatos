using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Clases;
using Helpers;
using System.Windows.Forms;

namespace GDD.ABM_Rubro
{
    public partial class frmHome : Form
    {
        private List<Publicacion> publicaciones;
        private List<Rubro> rubros;
        private Publicacion publiSeleccionada;
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            rubros = DBHelper.ExecuteReader("Rubro_GetAll").ToRubros();
            cmbRubros.DataSource = rubros;
            cmbRubros.DisplayMember = "DescripcionCorta";

            publicaciones = DBHelper.ExecuteReader("Publicacion_GetAll").ToPublicaciones();
            cmbProductos.DataSource = publicaciones;
            cmbProductos.DisplayMember = "Descripcion";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbRubros.SelectedIndex != -1)
            {
                var rubro = (Rubro)cmbRubros.SelectedItem;
                DBHelper.ExecuteNonQuery("Publicacion_ModifyRubro", new Dictionary<string, object> { { "@publicacion", publiSeleccionada.Id }, { "@rubro", rubro.Id } });
                MessageBox.Show("Modificado con exito");
            }
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedIndex != -1)
            {
                publiSeleccionada = (Publicacion)cmbProductos.SelectedItem;
                cmbRubros.SelectedItem = rubros.FirstOrDefault(x => x.Id == publiSeleccionada.Rubro);
            }
        }
    }
}



