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
    public partial class frmCliente : Form
    {
        private Usuario usuario;
        private Cliente cliente;
        public frmCliente(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }
        public frmCliente(Cliente cl)
        {
            InitializeComponent();
            cliente = cl;
            ckbEstado.Checked = cl.Activo;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "yyyy-M-d HH:mm:ss";
            dtpFecha.Format = DateTimePickerFormat.Custom;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (DatosCompletados())
            {
                var cli = new Dictionary<string, object>()
                {
                    { "@Username", usuario.Username },
                    { "@Nombre", txtNombre.Text },
                    { "@Apellido", txtApellido.Text },
                    { "@Dni", Convert.ToInt32(txtDni.Text)  },
                    { "@TipoDoc",  txtTipoDoc.Text },
                    { "@Mail",  txtMail.Text  },
                    { "@Telefono", txtTelefono.Text  },
                    { "@Direccion",txtDireccion.Text  },
                    { "@CodPostal", txtCodPostal.Text },
                    { "@Fecha", dtpFecha.Text},
                };
                if (usuario != null)
                {
                    Alta(cli);
                }
                else
                {
                    Modificar(cli);
                }
            }
            else
            {
                MessageBox.Show("Complete los campos correctamente");
            }
        }

        private void Modificar(Dictionary<string, object> cli)
        {
            DBHelper.ExecuteNonQuery("Cliente_Modify", cli);
            if (ckbEstado.Checked != cliente.Activo)
            {
                DBHelper.ExecuteNonQuery("Usuario_Activo", new Dictionary<string, object>() { { "@Username", cliente.Username } });
            }
            else
            {
                DBHelper.ExecuteNonQuery("Usuario_Desactivo", new Dictionary<string, object>() { { "@Username", cliente.Username } });
            }
            MessageBox.Show("Modificado con exito");
            Hide();
        }

        private void Alta(Dictionary<string, object> cli)
        {            
            DBHelper.ExecuteNonQuery("Usuario_Add", new Dictionary<string, object> { { "@Username", usuario.Username }, { "@Password", usuario.Password } });
            DBHelper.ExecuteNonQuery("Cliente_Add", cli);
            MessageBox.Show("Ingresado con exitos");
            Hide();
        }

        private bool DatosCompletados()
        {
            int result;
            return txtNombre.Text != null &&
                txtApellido.Text != null &&
                txtDni.Text != null && int.TryParse(txtDni.Text, out result) &&
                txtTipoDoc.Text != null &&
                txtMail.Text != null &&
                txtTelefono.Text != null &&
                txtDireccion.Text != null &&
                txtCodPostal.Text != null && int.TryParse(txtCodPostal.Text, out result) &&
                dtpFecha.Text != null;
        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            frmContraseña con = new frmContraseña(usuario);
            Show();
        }
    }
}
