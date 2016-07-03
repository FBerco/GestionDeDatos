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

namespace GDD.ABM_Usuario
{
    public partial class frmHome : Form
    {
        private Usuario usuario;

        //TEMPORAL PARA PRUEBAS, DESPUES BORRAR
        public frmHome()
        {
            InitializeComponent();
        }

        public frmHome(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadClientes(DBHelper.ExecuteReader("Cliente_GetAll").ToClientes());
            LoadEmpresas(DBHelper.ExecuteReader("Empresa_GetAll").ToEmpresas());
        }

        private void LoadEmpresas(List<Empresa> empresas)
        {
            dgvEmpresa.DataSource = empresas;
            dgvEmpresa.Columns.Clear();
            dgvEmpresa.AutoGenerateColumns = false;

            dgvEmpresa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "RazonSocial",
                HeaderText = "Razon Social",
                Width = 100,
                ReadOnly = true
            });
            dgvEmpresa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Cuit",
                HeaderText = "CUIT",
                Width = 100,
                ReadOnly = true
            });
            dgvEmpresa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Mail",
                HeaderText = "Mail",
                Width = 100,
                ReadOnly = true
            });
        }

        private void LoadClientes(List<Cliente> clientes)
        {
            dgvCliente.DataSource = clientes;
            dgvCliente.Columns.Clear();
            dgvCliente.AutoGenerateColumns = false;

            dgvCliente.Columns.Add(new DataGridViewTextBoxColumn() {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 100,
                ReadOnly = true
            });
            dgvCliente.Columns.Add(new DataGridViewTextBoxColumn() { 
                DataPropertyName = "Apellido",
                HeaderText = "Apellido",
                Width = 100,
                ReadOnly = true
            });
            dgvCliente.Columns.Add(new DataGridViewTextBoxColumn() {
                DataPropertyName = "Dni",
                HeaderText = "DNI",
                Width = 100,
                ReadOnly = true
            });
            dgvCliente.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Mail",
                HeaderText = "Mail",
                Width = 100,
                ReadOnly = true
            });
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta alta = new frmAlta();
            alta.Show();
        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            frmContraseña con = new frmContraseña(usuario);
            Show();
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            var cli = (Cliente)dgvCliente.CurrentRow.DataBoundItem;
            if (cli != null)
            {
                frmCliente cliente = new frmCliente(cli);
                cliente.Show();
            }
        }

        private void dgvEmpresa_DoubleClick(object sender, EventArgs e)
        {
            var emp = (Empresa)dgvEmpresa.CurrentRow.DataBoundItem;
            if (emp != null)
            {
                frmEmpresa empresa = new frmEmpresa(emp);
                empresa.Show();
            }
        }
    }
}
