using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace GDD.Calificar
{
    public partial class frmCalificar : Form
    {
        public frmCalificar()
        {
            InitializeComponent();
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            var venta = cmbVentas.SelectedItem;
            var estrellas = cmbEstrellas.SelectedItem;
            if (venta != null && estrellas != null)
            {
                var detalle = txtDetalle.Text;
                if (detalle.Length <= 140)
                {
                    Dictionary<string, object> parametros = new Dictionary<string, object>();
                    parametros.Add("@Estrellas", estrellas);
                    parametros.Add("@Venta", venta);
                    parametros.Add("@Detalle", detalle);
                    DBHelper.ExecuteNonQuery("Calificacion_Add", parametros);
                    MessageBox.Show("Calificado con exito", "Exito");
                    cmbVentas.Items.Remove(venta);
                }
                MessageBox.Show("El detalle tiene que ser como maximo 140", "Error");
            }
            MessageBox.Show("Seleccionar venta y estrellas", "Error");
        }
    }
}
