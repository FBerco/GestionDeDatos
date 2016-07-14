using System;
using System.Collections.Generic;
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
                              
                trimestre = cmbTrimestre.SelectedIndex + 1;
                anio = Convert.ToInt32(dtpAnio.Text);
                switch (tipo)
                {
                    case 0:
                        var visi = chkFiltro.Checked ? (Visibilidad)cmbFiltro.SelectedItem : null;                        
                        MayorNoVendido(visi);                                              
                        break;
                    case 1:
                        var rubr = chkFiltro.Checked ? (Rubro)cmbFiltro.SelectedItem : null;
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
            switch (cmbTipo.SelectedIndex) {
                case 0:
                    lblFiltro.Visible = true;
                    lblFiltro.Text = "Seleccione visibilidad";                    
                    cmbFiltro.DataSource = DBHelper.ExecuteReader("Visibilidad_GetAll").ToVisibilidades();
                    cmbFiltro.DisplayMember = "Detalle";
                    cmbFiltro.Visible = true;
                    chkFiltro.Visible = true;
                    break;
                case 1:
                    lblFiltro.Visible = true;
                    lblFiltro.Text = "Seleccione rubro";
                    cmbFiltro.DataSource = DBHelper.ExecuteReader("Rubro_GetAll").ToRubros();
                    cmbFiltro.DisplayMember = "DescripcionCorta";
                    cmbFiltro.Visible = true;
                    chkFiltro.Visible = true;
                    break;
                default:
                    lblFiltro.Visible = false;
                    cmbFiltro.Visible = false;
                    chkFiltro.Visible = false;
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

        private void MayorNoVendido(Visibilidad visi = null)
        {
            var parametros = GetDiccionario();
            if (visi != null)
            {
                parametros.Add("@Visibilidad", visi.Id);
            }
            else
            {
                parametros.Add("@Visibilidad", DBNull.Value);
            }
            var estadistica = DBHelper.ExecuteReader("Estadisticas_MayorNoVendido", parametros).ToEstadisticas();
            CargarGrilla(estadistica, "Cantidad productos vendidos");
        }

        private void MayorCantidadProductosComprados(Rubro rubr = null)
        {
            var parametros = GetDiccionario();
            if (rubr != null)
            {
                parametros.Add("@Rubro", rubr.Id);
            }
            else
            {
                parametros.Add("@Rubro", DBNull.Value);
            }
            var estadistica = DBHelper.ExecuteReader("Estadisticas_ClientesComprados", parametros).ToEstadisticas();
            CargarGrilla(estadistica, "Cantidad productos comprados");
        }
     
        private void MayorCantidadFacturas()
        {
            var estadistica = DBHelper.ExecuteReader("Estadisticas_MayorFacturas", GetDiccionario()).ToEstadisticas();
            CargarGrilla(estadistica, "Cantidad de facturas");
        }

        private void MayorMontoFacturado()
        {
            var estadistica = DBHelper.ExecuteReader("Estadisticas_MayorFacturado", GetDiccionario()).ToEstadisticas();
            CargarGrilla(estadistica, "Monto facturado ($)");
        }

        private void CargarGrilla(List<Estadistica> estadistica, string nombreColumnaExtra) {
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
                HeaderText = nombreColumnaExtra,
                Width = 100,
                ReadOnly = true
            });
        }
    }
}
