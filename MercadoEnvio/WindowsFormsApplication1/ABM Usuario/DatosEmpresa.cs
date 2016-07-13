using Clases;
using Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace GDD.ABM_Usuario
{
    public partial class frmEmpresa : Form
    {
        private Usuario usuario;
        private Empresa empresa;
        
        //Cuando vengo del alta
        public frmEmpresa(Usuario us)
        {
            InitializeComponent();
            usuario = us;
            ckbEstado.Visible = false;
            lblEstado.Visible = false;
        }

        //Cuando vengo del modificar
        public frmEmpresa(Empresa emp)
        {
            InitializeComponent();
            emp.Activo = DBHelper.ExecuteReader("Usuario_Get", new Dictionary<string, object>() { { "@usuario", emp.Username } }).ToUsuario().Activo;
            empresa = emp;
            txtCiudad.Text = emp.Ciudad;
            txtCodPostal.Text = emp.CodigoPostal.ToString();
            txtCuit.Text = emp.Cuit;
            txtDireccion.Text = emp.Direccion;
            txtMail.Text = emp.Mail;
            txtNombre.Text = emp.NombreContacto;
            txtRazonSocial.Text = emp.RazonSocial.ToString();
            txtTelefono.Text = emp.Telefono;
            btnContraseña.Visible = true;
            ckbEstado.Checked = emp.Activo;
            if (!emp.Habilitado)
            {
                btnHabilitar.Visible = true;
            }
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            cmbRubro.DataSource = DBHelper.ExecuteReader("Rubro_GetAll").ToRubros(); 
            cmbRubro.DisplayMember = "DescripcionCorta";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (DatosCompletados())
            {
                var emp = new Dictionary<string, object>() {
                    { "@RazonSocial", txtRazonSocial.Text },
                    { "@Mail" , txtMail.Text },
                    { "@Telefono" ,  txtTelefono.Text},
                    { "@Direccion" ,  txtDireccion.Text},
                    { "@CodigoPostal" ,  Convert.ToInt32(txtCodPostal.Text)},
                    { "@Cuit" ,  txtCuit.Text},
                    { "@Ciudad" ,  txtCiudad.Text},
                    { "@NombreContacto" , txtNombre.Text},
                    { "@RubroId" ,  ((Rubro)cmbRubro.SelectedItem).Id}
                };
                if (usuario != null)
                {
                    Alta(emp);
                }
                else
                {
                    Modificar(emp);
                }
            }
        }

        private void Modificar(Dictionary<string, object> emp)
        {
            emp.Add("@Username", empresa.Username);
            DBHelper.ExecuteNonQuery("Empresa_Modify", emp);
            DBHelper.ExecuteNonQuery("Usuario_Activo", new Dictionary<string, object>() { { "@Username", empresa.Username }, { "Activo", ckbEstado.Checked } });            
            MessageBox.Show("Modificado con exito");
            Hide();
        }

        private void Alta(Dictionary<string, object> emp) {

            emp.Add("@Username", usuario.Username);
            DBHelper.ExecuteNonQuery("Usuario_Add", new Dictionary<string, object> { { "@Username", usuario.Username }, { "@Password", usuario.Password } });
            DBHelper.ExecuteNonQuery("Empresa_Add", emp);
            MessageBox.Show("Ingresado con exitos");
            Hide();
        }

        private bool DatosCompletados() {
            int result;
            if (txtRazonSocial.Text == string.Empty || txtMail.Text == string.Empty || txtTelefono.Text == string.Empty || txtDireccion.Text == string.Empty || txtCodPostal.Text == string.Empty || txtCiudad.Text == string.Empty || txtCuit.Text == string.Empty || txtNombre.Text == string.Empty || cmbRubro.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos por favor");
                return false;
            }

            if (!int.TryParse(txtCodPostal.Text, out result)) {
                MessageBox.Show("Codigo Postal debe ser numerico");
                return false;
            }
            return true;
        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            frmContraseña con = new frmContraseña(usuario);
            Show();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            DBHelper.ExecuteNonQuery("Usuario_Habilitar", new Dictionary<string, object>() { { "@Username", empresa.Username } });
            MessageBox.Show("Usuario habilitado nuevamente.");
            btnHabilitar.Visible = false;
        }
    }
}
