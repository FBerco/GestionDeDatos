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
        private int anio;
        public frmHome()
        {
            InitializeComponent();
            dtpAnio.Format = DateTimePickerFormat.Custom;
            dtpAnio.CustomFormat = "yyyy";
            dtpAnio.ShowUpDown = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var tipo = cmbTipo.SelectedIndex;
           
            if (!string.IsNullOrEmpty(dtpAnio.Text) && tipo != -1 && cmbTrimestre.SelectedItem != null )
            {
                              
                trimestre = ++cmbTrimestre.SelectedIndex;
                anio = Convert.ToInt32(dtpAnio.Text);
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
                        MayorCantidadFacturas();
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

        private int GetMes() {
            switch (trimestre)
            {
                case 1:
                    return 1;
                case 2:
                    return 4;
                case 3:
                    return 7;
                case 4:
                    return 10;
                default:
                    return 1;
            }
        }

        private Dictionary<string, object> GetDiccionario() {
            return new Dictionary<string, object> { { "@Mes", GetMes() }, { "@Anio", anio } };
        }

        private void MayorNoVendido(Visibilidad visi)
        {
            var parametros = GetDiccionario();
            if (visi != null)
            {
                parametros.Add("@Visibilidad", visi.Id);
            }
            var estadistica = DBHelper.ExecuteReader("Estadisticas_MayorNoVendido", parametros).ToEstadisticas();
            CargarGrilla(estadistica);
        }

        private void MayorCantidadProductosComprados(Rubro rubr)
        {
            var parametros = GetDiccionario();
            if (rubr != null)
            {
                parametros.Add("@Rubro", rubr.Id);
            }
            var estadistica = DBHelper.ExecuteReader("Estadisticas_ClientesComprados", parametros).ToEstadisticas();
            CargarGrilla(estadistica);
        }
     
        private void MayorCantidadFacturas()
        {
            var estadistica = DBHelper.ExecuteReader("Estadisticas_MayorFacturas", GetDiccionario()).ToEstadisticas();
            CargarGrilla(estadistica);
        }

        private void MayorMontoFacturado()
        {
            var estadistica = DBHelper.ExecuteReader("Estadisticas_MayorFacturado", GetDiccionario()).ToEstadisticas();
            CargarGrilla(estadistica);
        }

        private void CargarGrilla(List<Estadistica> estadistica) {
            dgvResultado.DataSource = estadistica;
            dgvResultado.Columns.Clear();
            dgvResultado.AutoGenerateColumns = false;

            dgvResultado.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Username",
                HeaderText = "Username",
                Width = 100,
                ReadOnly = true
            });
            dgvResultado.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Extra",
                HeaderText = "Extra",
                Width = 100,
                ReadOnly = true
            });
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

    }
}
