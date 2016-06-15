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

namespace GDD.Generar_Publicación
{
    public partial class Alta : Form
    {
        
        public Alta(Publicacion publicacionSeleccionada)
        {
            int id;
            InitializeComponent();
            CargarDatos(publicacionSeleccionada);
            id = publicacionSeleccionada.Id;
            gbPublicacion.Enabled = false;
            gbEstado.Enabled = false;
           
        }
        
        public Alta()
        {
            InitializeComponent();
        }

        private void CargarDatos(Publicacion publicacion) 
        {
            txtDescripcion.Text = publicacion.Descripcion;
            txtPrecio.Text = publicacion.Precio.ToString();
            txtStock.Text = publicacion.Stock.ToString();
            dtpFecha.Text = publicacion.FechaVencimiento.ToString();
            if (publicacion.Tipo == "Subasta")
            {
                rbtnSubasta.Focus();
            }
            else 
            {
                rbtnCompra.Focus();
                
            }
        
        }

  

        private void Alta_Load(object sender, EventArgs e)
        {
           
            dgvRubro.DataSource = DBHelper.ExecuteReader("Rubro_GetAll").ToRubros();
            dgvRubro.Columns.Clear();
            dgvRubro.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn DescripcionCorta = new DataGridViewTextBoxColumn();
            DescripcionCorta.DataPropertyName = "DescripcionCorta";
            DescripcionCorta.HeaderText = "Rubro";
            DescripcionCorta.Width = 100;
            DescripcionCorta.ReadOnly = true;

            dgvVisibilidad.DataSource = DBHelper.ExecuteReader("Visibilidad_GetAll").ToVisibilidades();
            dgvVisibilidad.Columns.Clear();
            dgvVisibilidad.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn Detalle = new DataGridViewTextBoxColumn();
            Detalle.DataPropertyName = "Detalle";
            Detalle.HeaderText = "Visibilidad";
            Detalle.Width = 100;
            Detalle.ReadOnly = true;
          
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int idEstado = 0;
            var descripcion = txtDescripcion.Text;
            var precio = txtPrecio.Text;
            var stock = txtStock.Text;
            var fechaVencimiento = dtpFecha.Value;
            Rubro rubroSeleccionado = (Rubro)dgvRubro.CurrentRow.DataBoundItem;
            int idRubro = rubroSeleccionado.Id;
            Visibilidad visibilidadSeleccionada = (Visibilidad)dgvVisibilidad.CurrentRow.DataBoundItem;
            int idVisibilidad = visibilidadSeleccionada.Id;
            
            if (rbtnPublicar.Checked == true)
            {
                idEstado = 1; //id Publicada
            }
            else if (rbtnBorrador.Checked == true)
            {
                idEstado = 4; //id Borrador
            }
            else 
            {
                MessageBox.Show("Seleccionar estado publicacion");
            }
            var tipoPublicacion = "";
            foreach(Control ctrl in gbPublicacion.Controls)
            {
                if(ctrl is RadioButton)
                {
                    RadioButton radio = ctrl as RadioButton;
                    if(radio.Checked)
                    {
                        tipoPublicacion = radio.Text;
                    }
                    else
                    {
                       MessageBox.Show("Seleccionar tipo de publicacion");     
                    }
                }
            }
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            
            parametros.Add("@Tipo", tipoPublicacion);
            //fechaInicio
            parametros.Add("@FechaVencimiento", fechaVencimiento);
            parametros.Add("@Descripcion", descripcion);
            //usuarioId
            parametros.Add("@RubroId", idRubro);
            parametros.Add("@EstadoId", idEstado);           
            parametros.Add("@Stock", stock);
            parametros.Add("@Precio", precio);
            parametros.Add("@VisibilidadId", idVisibilidad);
            //faltan agregar mas parametros     
      
            DBHelper.ExecuteNonQuery("Publicacion_Insert", parametros);
            MessageBox.Show("Se ha cargado la publicacion");
            Limpiar();

        }

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            rbtnPublicar.Checked = false;
            rbtnSubasta.Checked = false;
            rbtnCompra.Checked = false;
            rbtnBorrador.Checked = false;
        }
  

        

     

     

        

        
    }
}
