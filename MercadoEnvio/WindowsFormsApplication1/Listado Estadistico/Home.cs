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

namespace GDD.Listado_Estadistico
{
    public partial class frmHome : Form
    {
        private int trimestre;
        private int año;
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var tipo = cmbTipo.SelectedIndex;
           
            if (!string.IsNullOrEmpty(txtAño.Text) && tipo != -1 && cmbTrimestre.SelectedItem != null )
            {
                              
                trimestre = ++cmbTrimestre.SelectedIndex;
                año = Convert.ToInt32(txtAño.Text);
                switch (tipo)
                {
                    case 0:
                        var visi = (Visibilidad)cmbFiltro.SelectedItem;                        
                        MayorNoVendido(visi);                                              
                        break;
                    case 1:
                        var rubr = (Rubro)cmbFiltro.SelectedItem;
                        MayorCantidadProductosComprados(rubr);
                        break;
                    case 2:
                        MayorCantidadFActuras();
                        break;
                    case 3:
                        MayorMontoFacturado();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Complete los campos por favor.");
            }
        }


        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFiltro.SelectedIndex) {
                case 0:
                    lblFiltro.Visible = true;
                    cmbFiltro.DataSource = DBHelper.ExecuteReader("Visibilidad_GetAll").ToVisibilidades();
                    cmbFiltro.DisplayMember = "Detalle";
                    break;
                case 1:
                    lblFiltro.Visible = true;
                    cmbFiltro.DataSource = DBHelper.ExecuteReader("Rubro_GetAll").ToVisibilidades();
                    cmbFiltro.DisplayMember = "DescripcionCorta";
                    break;
                default:
                    lblFiltro.Visible = false;
                    cmbFiltro.Visible = false;
                    break;
            }
        }

        private void MayorNoVendido(Visibilidad visi = null)
        {
            
        }

        private void MayorCantidadProductosComprados(Rubro rubr)
        {
            throw new NotImplementedException();
        }
     
        private void MayorCantidadFActuras()
        {
            throw new NotImplementedException();
        }

        private void MayorMontoFacturado()
        {
            throw new NotImplementedException();
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

    }
}
