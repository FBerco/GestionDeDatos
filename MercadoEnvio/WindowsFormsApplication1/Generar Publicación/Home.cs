using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Helpers;
using Clases;
using System.Windows.Forms;

namespace GDD.Generar_Publicación
{
    public partial class frmHome : Form
    {
        Usuario usuario;
        List<Publicacion> publicaciones;
        public frmHome(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }
                
        private void Home_Load(object sender, EventArgs e)
        {
            var estados = DBHelper.ExecuteReader("Estado_GetAll").ToEstados();
            cmbEstado.DataSource = estados;
            cmbEstado.DisplayMember = "Descripcion";           
            CargarGrilla(DBHelper.ExecuteReader("Publicacion_GetAll").ToPublicaciones());
        }

      
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var descripcion = txtDescripcion.Text;
            var estado = ((Estado)cmbEstado.SelectedItem).Id;
            CargarGrilla(DBHelper.ExecuteReader("Publicacion_GetByFilters", new Dictionary<string, object>() { { "@text", txtDescripcion.Text }, { "@estado", estado } }).ToPublicaciones());
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta alta = new frmAlta(usuario);
            alta.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //hacer un if si hay public seleccionada 
            var publicacion = (Publicacion)dgvPublicaciones.CurrentRow.DataBoundItem;
            if (publicacion != null)
            {
                frmAlta alta = new frmAlta(usuario, publicacion);
                alta.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Seleccione publicacion a modificar", "Error");
            }

        }

        public int ObtenerIdEstado(string nombreEstado) 
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@Descripcion", nombreEstado);
            Estado estado;
            estado = DBHelper.ExecuteReader("Estado_GetById", parametros).ToEstado();
            int id = estado.Id;
            return id;   
        }        

        private void CargarGrilla(List<Publicacion> publics)
        {
            publicaciones = publics;
            dgvPublicaciones.DataSource = publicaciones;
            dgvPublicaciones.Columns.Clear();
            dgvPublicaciones.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn Descripcion = new DataGridViewTextBoxColumn();
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Width = 100;
            Descripcion.ReadOnly = true;
            DataGridViewTextBoxColumn Precio = new DataGridViewTextBoxColumn();
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.Width = 100;
            Precio.ReadOnly = true;
            DataGridViewTextBoxColumn Stock = new DataGridViewTextBoxColumn();
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.Width = 100;
            Stock.ReadOnly = true;
            DataGridViewTextBoxColumn Tipo = new DataGridViewTextBoxColumn();
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Width = 100;
            Tipo.ReadOnly = true;
            /*DataGridViewTextBoxColumn Usuario = new DataGridViewTextBoxColumn();
            Usuario.DataPropertyName = "Usuario";
            Usuario.HeaderText = "Vendedor";
            Usuario.Width = 100;
            Usuario.ReadOnly = true; para que aparezca el nombre del usuario*/
            DataGridViewTextBoxColumn FechaVencimiento = new DataGridViewTextBoxColumn();
            FechaVencimiento.DataPropertyName = "FechaVencimiento";
            FechaVencimiento.HeaderText = "Fecha de vencimiento";
            FechaVencimiento.Width = 100;
            FechaVencimiento.ReadOnly = true;

            //dgvPublicaciones.Columns.Add(Usuario);
            dgvPublicaciones.Columns.Add(Descripcion);
            dgvPublicaciones.Columns.Add(Precio);
            dgvPublicaciones.Columns.Add(Stock);
            dgvPublicaciones.Columns.Add(FechaVencimiento);
            dgvPublicaciones.Columns.Add(Tipo);
        }
    }
    
}
