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
        public frmHome()
        {
            InitializeComponent();
        }

        Publicacion publicacionSeleccionada;
        bool verPublic = true;
        

        private void Home_Load(object sender, EventArgs e)
        {
            //ActualizarGrilla(); si le paso asi es como un diccionario sin nada?
            if (dgvPublicaciones.Rows.Count <= 0)
            {
                btnModificar.Enabled = false;
                btnActivar.Enabled = false;
                btnPausar.Enabled = false;
                btnFinalizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void ActualizarGrilla(Dictionary<string, object> filtros = null) 
        {
            dgvPublicaciones.Columns.Clear();
            dgvPublicaciones.AutoGenerateColumns = false;
            if (verPublic)
            {
                dgvPublicaciones.DataSource = DBHelper.ExecuteReader("Publicacion_ObtenerTodas", null);
            }
            else
            {
                dgvPublicaciones.DataSource = DBHelper.ExecuteReader("Publicacion_ObtenerPorFiltros", filtros);
            }

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
    

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Form alta = new Generar_Publicación.Alta();
            alta.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {   
            //hacer un if si hay public seleccionada 
            publicacionSeleccionada = (Publicacion)dgvPublicaciones.CurrentRow.DataBoundItem;
            int id = publicacionSeleccionada.Id;
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@IdPublicacion", id);
            publicacionSeleccionada = DBHelper.ExecuteReader("Publicacion_ObtenerPorId", parametros).ToPublicacion();
            Form alta = new Generar_Publicación.Alta(publicacionSeleccionada);
            alta.Show();
            this.Close();
            
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            //activar la publicacion seleccionada
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            //pausar la publicacion seleccionada
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //finalizar la publicacion seleccionada
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();  
        }

        private void Limpiar() 
        {
            txtDescripcion.Text = "";
            cmbEstado.SelectedValue = false;
            cmbEstado.Text = "";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            if (cmbEstado.Text == "" && txtDescripcion.Text == "")
            {
                verPublic = true;
                MessageBox.Show("No ha seleccionado ningun filtro");
                ActualizarGrilla();                
            }
            else
            {
                var estadoSeleccionado = cmbEstado.Text;
                var descripcion = txtDescripcion.Text;
                verPublic = false; 
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@EstadoPublicacion", estadoSeleccionado);
                parametros.Add("@DescripcionPublicacion", descripcion);
                ActualizarGrilla(parametros);
                
                if (dgvPublicaciones.Rows.Count <= 0)
                {
                    MessageBox.Show("No se encontraron resultados");
                }
                else
                {
                    switch (estadoSeleccionado)
                    {
                        case "Borrador":
                            btnModificar.Enabled = true;
                            btnActivar.Enabled = true;
                            btnPausar.Enabled = false;
                            btnFinalizar.Enabled = false;
                            btnEliminar.Enabled = true;
                            break;
                        case "Activa":
                            btnModificar.Enabled = false;
                            btnActivar.Enabled = false;
                            btnPausar.Enabled = true;
                            btnFinalizar.Enabled = true; //habria que ver si es subasta, compra inm
                            btnEliminar.Enabled = true;
                            break;
                        case "Pausada":
                            btnModificar.Enabled = false;
                            btnActivar.Enabled = true;
                            btnPausar.Enabled = false;
                            btnFinalizar.Enabled = false;
                            btnEliminar.Enabled = true;
                            break;
                        case "Finalizada":
                            btnModificar.Enabled = false;
                            btnActivar.Enabled = false;
                            btnPausar.Enabled = false;
                            btnFinalizar.Enabled = false;
                            btnEliminar.Enabled = true;
                            break;
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar la publicacion? ", "Información", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                publicacionSeleccionada = (Publicacion)dgvPublicaciones.CurrentRow.DataBoundItem;
                parametros.Add("@IdPublicacion", publicacionSeleccionada.Id);
                DBHelper.ExecuteNonQuery("Publicacion_Eliminar", parametros);
                ActualizarGrilla();
                Limpiar();
            }
            else 
            {
            }
        }

      

        

    }
    
}
