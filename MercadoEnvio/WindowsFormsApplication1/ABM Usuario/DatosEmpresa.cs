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
            else
            {
                MessageBox.Show("Complete los campos correctamente");
            }
        }

        private void Modificar(Dictionary<string, object> emp)
        {
            emp.Add("@Username", empresa.Username);
            DBHelper.ExecuteNonQuery("Empresa_Modify", emp);
            if (ckbEstado.Checked != empresa.Activo)
            {
                DBHelper.ExecuteNonQuery("Usuario_Activo", new Dictionary<string, object>() { { "@Username", empresa.Username } });
            }
            else
            {
                DBHelper.ExecuteNonQuery("Usuario_Desactivo", new Dictionary<string, object>() { { "@Username", empresa.Username } });
            }
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
            return txtRazonSocial.Text != null && int.TryParse(txtRazonSocial.Text, out result) &&
                txtMail.Text != null &&
                txtTelefono.Text != null && 
                txtDireccion.Text != null &&
                txtCodPostal.Text != null && int.TryParse(txtCodPostal.Text, out result) &&
                txtCiudad.Text != null &&
                txtCuit.Text != null &&
                txtNombre.Text != null &&
                cmbRubro.SelectedItem != null;
        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            frmContraseña con = new frmContraseña(usuario);
            Show();
        }       
    }
}
