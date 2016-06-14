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
        bool verPublicacionesTodas = true;
        bool verPublicaciones2Filtros = false;
        bool verPublicacionesEstado = false;
        bool verPublicacionesDescripcion = false;

        private void Home_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            if (dgvPublicaciones.Rows.Count <= 0)
            {
                btnModificar.Enabled = false;
                btnPublicar.Enabled = false;
                btnPausar.Enabled = false;
                btnFinalizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void ActualizarGrilla(Dictionary<string, object> filtros = null) 
        {
            dgvPublicaciones.Columns.Clear();
            dgvPublicaciones.AutoGenerateColumns = false;
            if (verPublicacionesTodas)
            {
                dgvPublicaciones.DataSource = DBHelper.ExecuteReader("Publicacion_GetAll").ToPublicaciones();
            }
            else if(verPublicaciones2Filtros)
            {
                dgvPublicaciones.DataSource = DBHelper.ExecuteReader("Publicacion_GetByFilters", filtros).ToPublicaciones();
            }
            else if (verPublicacionesDescripcion)
            {
                dgvPublicaciones.DataSource = DBHelper.ExecuteReader("Publicacion_GetByDescripcion", filtros).ToPublicaciones();
            }
            else if (verPublicacionesEstado) 
            {
                dgvPublicaciones.DataSource = DBHelper.ExecuteReader("Publicacion_GetByEstado", filtros).ToPublicaciones();
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
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string estadoSeleccionado = cmbEstado.Text;
            var descripcion = txtDescripcion.Text;
            int id = ObtenerIdEstado(estadoSeleccionado);
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (estadoSeleccionado == "" && descripcion == "")
            {
                verPublicacionesTodas = true;
                verPublicacionesEstado = false;
                verPublicacionesDescripcion = false;
                verPublicaciones2Filtros = false;
                MessageBox.Show("No ha seleccionado ningun filtro");
                ActualizarGrilla();                
            }
            else if(estadoSeleccionado != "" && descripcion == "")
            {
                verPublicacionesTodas = false;
                verPublicacionesEstado = true;
                verPublicacionesDescripcion = false;
                verPublicaciones2Filtros = false;
             
                parametros.Add("@EstadoId", id);
                ActualizarGrilla(parametros);
                parametros.Clear();
            }
            else if (estadoSeleccionado == "" && descripcion != "" )
            {
                verPublicacionesTodas = false;
                verPublicacionesEstado = false;
                verPublicacionesDescripcion = true;
                verPublicaciones2Filtros = false;

                parametros.Add("@Descripcion", descripcion);
                ActualizarGrilla(parametros);
                parametros.Clear();
            }
            else if (estadoSeleccionado != "" && descripcion != "")
            {
                verPublicacionesTodas = false;
                verPublicacionesEstado = false;
                verPublicacionesDescripcion = false;
                verPublicaciones2Filtros = true;

                parametros.Add("@Descripcion", descripcion);
                parametros.Add("@EstadoId", id);
                ActualizarGrilla(parametros);
                parametros.Clear();
            }
                
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
                        btnPublicar.Enabled = true;
                        btnPausar.Enabled = false;
                        btnFinalizar.Enabled = false;
                        btnEliminar.Enabled = true;
                        break;
                    case "Publicada": //Estado se llama publicada (no activa)
                        btnModificar.Enabled = false;
                        btnPublicar.Enabled = false;
                        btnPausar.Enabled = true;
                        btnFinalizar.Enabled = true; //habria que ver si es subasta, compra inm
                        btnEliminar.Enabled = true;
                        break;
                    case "Pausada":
                        btnModificar.Enabled = false;
                        btnPublicar.Enabled = true;
                        btnPausar.Enabled = false;
                        btnFinalizar.Enabled = false;
                        btnEliminar.Enabled = true;
                        break;
                    case "Finalizada":
                        btnModificar.Enabled = false;
                        btnPublicar.Enabled = false;
                        btnPausar.Enabled = false;
                        btnFinalizar.Enabled = false;
                        btnEliminar.Enabled = true;
                        break;
                 }               
            }
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
            parametros.Add("@Id", id);
            publicacionSeleccionada = DBHelper.ExecuteReader("Publicacion_ObtenerPorId", parametros).ToPublicacion();
            Form alta = new Generar_Publicación.Alta(publicacionSeleccionada);
            alta.Show();
            this.Close();

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


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar la publicacion? ", "Información", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                publicacionSeleccionada = (Publicacion)dgvPublicaciones.CurrentRow.DataBoundItem;
                parametros.Add("@IdPublicacion", publicacionSeleccionada.Id);
                DBHelper.ExecuteNonQuery("Publicacion_Delete", parametros);
                verPublicacionesTodas = true;
                verPublicacionesEstado = false;
                verPublicacionesDescripcion = false;
                verPublicaciones2Filtros = false;
                ActualizarGrilla();
                Limpiar();
                parametros.Clear();
            }
            else 
            {
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            //pausar la publicacion seleccionada

            publicacionSeleccionada = (Publicacion)dgvPublicaciones.CurrentRow.DataBoundItem;
            int id = publicacionSeleccionada.Id;
            int idEstado = 2;
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@Id", id);
            parametros.Add("@EstadoId", idEstado);
            DBHelper.ExecuteNonQuery("Publicacion_UpdateEstado", parametros);
            MessageBox.Show("La publicacion ha sido pausada");
            Limpiar();
            verPublicacionesTodas = true;
            verPublicacionesEstado = false;
            verPublicacionesDescripcion = false;
            verPublicaciones2Filtros = false;
            ActualizarGrilla();
            parametros.Clear();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //finalizar la publicacion seleccionada

            publicacionSeleccionada = (Publicacion)dgvPublicaciones.CurrentRow.DataBoundItem;
            int id = publicacionSeleccionada.Id;
            int idEstado = 3;
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@Id", id);
            parametros.Add("@EstadoId", idEstado);
            DBHelper.ExecuteNonQuery("Publicacion_UpdateEstado", parametros);
            MessageBox.Show("La publicacion ha sido finalizada");
            Limpiar();
            verPublicacionesTodas = true;
            verPublicacionesEstado = false;
            verPublicacionesDescripcion = false;
            verPublicaciones2Filtros = false;
            ActualizarGrilla();
            parametros.Clear();
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

        private void btnPublicar_Click(object sender, EventArgs e)
        { 
            //publicar la publicacion seleccionada

            publicacionSeleccionada = (Publicacion)dgvPublicaciones.CurrentRow.DataBoundItem;
            int id = publicacionSeleccionada.Id;
            int idEstado = 1;
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@Id", id);
            parametros.Add("@EstadoId", idEstado);
            DBHelper.ExecuteNonQuery("Publicacion_UpdateEstado", parametros);
            MessageBox.Show("La publicacion ha sido publicada");
            Limpiar();
            verPublicacionesTodas = true;
            verPublicacionesEstado = false;
            verPublicacionesDescripcion = false;
            verPublicaciones2Filtros = false;
            ActualizarGrilla();
            parametros.Clear();
        }
    }
    
}
