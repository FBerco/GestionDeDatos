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
        public Empresa empresa;
        private frmHome frmHome;

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
            var usu = DBHelper.ExecuteReader("Usuario_Get", new Dictionary<string, object>() { { "@usuario", emp.Username } }).ToUsuario();
            emp.Habilitado = usu.Habilitado;
            emp.Activo = usu.Activo;
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

        public frmEmpresa(Usuario us, frmHome frmHome) : this(us)
        {
            this.frmHome = frmHome;
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
                //Me fijo si alta o modificacion
                if (usuario != null)
                {                    
                    Alta(emp);
                }
                else
                {
                    Modificar(emp);
                }
                Close();
            }
        }

        private void Modificar(Dictionary<string, object> parametros)
        {
            var empr = DBHelper.ExecuteReader("Empresa_GetByCuitORazonSocial", new Dictionary<string, object>() { { "@RazonSocial", txtRazonSocial.Text }, { "@Cuit", txtCuit.Text }, { "@Username", empresa.Username } }).ToEmpresa();
            if (empr != null)
            {
                MessageBox.Show("Ya existe una empresa con esa razon social o cuit. Ingrese otros por favor");
                return;
            }
            parametros.Add("@Username", empresa.Username);
            DBHelper.ExecuteNonQuery("Empresa_Modify", parametros);
            DBHelper.ExecuteNonQuery("Usuario_Activo", new Dictionary<string, object>() { { "@Username", empresa.Username }, { "Activo", ckbEstado.Checked } });            
            MessageBox.Show("Modificado con exito");
        }

        private void Alta(Dictionary<string, object> parametros)
        {
            var empr = DBHelper.ExecuteReader("Empresa_GetByCuitORazonSocial", new Dictionary<string, object>() { { "@RazonSocial", txtRazonSocial.Text }, { "@Cuit", txtCuit.Text }, { "@Username", usuario.Username} }).ToEmpresa();
            if (empr != null)
            {
                MessageBox.Show("Ya existe una empresa con esa razon social o cuit. Ingrese otros por favor");
                return;
            }
            parametros.Add("@Username", usuario.Username);
            DBHelper.ExecuteNonQuery("Usuario_Add", new Dictionary<string, object> { { "@Username", usuario.Username }, { "@Password", usuario.Password } });
            DBHelper.ExecuteNonQuery("Empresa_Add", parametros);
            MessageBox.Show("Ingresado con exitos");
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
            var usua = new Usuario()
            {
                Username = empresa.Username
            };
            frmContraseña con = new frmContraseña(usua);
            con.Show();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            DBHelper.ExecuteNonQuery("Usuario_Habilitar", new Dictionary<string, object>() { { "@Username", empresa.Username } });
            MessageBox.Show("Usuario habilitado nuevamente.");
            btnHabilitar.Visible = false;
        }

        private void txtCodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
        }
    }
}
