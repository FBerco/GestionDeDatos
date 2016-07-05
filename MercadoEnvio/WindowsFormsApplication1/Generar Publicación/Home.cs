using System;
using System.Collections.Generic;
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
            CargarGrilla(DBHelper.ExecuteReader("Publicacion_GetByUsername", new Dictionary<string, object> { { "@username", usuario.Username} }).ToPublicaciones());
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var descripcion = txtDescripcion.Text;
            var estado = ((Estado)cmbEstado.SelectedItem).Id;
            CargarGrilla(DBHelper.ExecuteReader("Publicacion_GetByFilters", new Dictionary<string, object>() { { "@text", txtDescripcion.Text }, { "@estado", estado } }).ToPublicaciones());
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmPublicacion alta = new frmPublicacion(usuario);
            alta.Show();
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var publicacion = (Publicacion)dgvPublicaciones.CurrentRow.DataBoundItem;
            if (publicacion != null)
            {
                //Finalizado
                if (publicacion.Estado == 3)
                {
                    MessageBox.Show("Esta publicacion está finalizada, no se puede editar", "Error");
                    return;
                }
                frmPublicacion alta = new frmPublicacion(usuario, publicacion);
                alta.Show();
                Close();
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

            dgvPublicaciones.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Descripcion",
                HeaderText = "Descripcion",
                Width = 100,
                ReadOnly = true
            });
            dgvPublicaciones.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                Width = 100,
                ReadOnly = true
            });
            dgvPublicaciones.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Stock",
                HeaderText = "Stock",
                Width = 100,
                ReadOnly = true
            });
            dgvPublicaciones.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Tipo",
                HeaderText = "Tipo",
                Width = 100,
                ReadOnly = true
            });
            dgvPublicaciones.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "FechaVencimiento",
                HeaderText = "Fecha de vencimiento",
                Width = 100,
                ReadOnly = true
            });
            dgvPublicaciones.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Estado",
                HeaderText = "Fecha de vencimiento",
                Width = 100,
                ReadOnly = true
            }); 
        }
    }
}
