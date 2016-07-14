﻿using Clases;
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
            ckbEstado.Visible = false;
            lblEstado.Visible = false;
        }
        public frmCliente(Cliente cl)
        {
            InitializeComponent();
            cl.Activo = DBHelper.ExecuteReader("Usuario_Get", new Dictionary<string, object>() { { "@usuario", cl.Username } }).ToUsuario().Activo;
            cliente = cl;
            txtNombre.Text = cl.Nombre;
            txtApellido.Text = cl.Apellido;
            txtDni.Text = cl.Dni.ToString();
            txtTipoDoc.Text = cl.TipoDocumento;
            txtMail.Text = cl.Mail;
            txtTelefono.Text = cl.Telefono;
            txtDireccion.Text = cl.Direccion;
            txtCodPostal.Text = cl.CodigoPostal.ToString();
            dtpFecha.Value = cl.FechaNacimiento;
            ckbEstado.Checked = cl.Activo;
            btnContraseña.Visible = true;
            if (!cliente.Habilitado)
            {
                btnHabilitar.Visible = true;
            }
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
                    { "@Nombre", txtNombre.Text },
                    { "@Apellido", txtApellido.Text },
                    { "@Dni", Convert.ToInt32(txtDni.Text)  },
                    { "@TipoDoc",  txtTipoDoc.Text },
                    { "@Mail",  txtMail.Text  },
                    { "@Telefono", txtTelefono.Text  },
                    { "@Direccion",txtDireccion.Text  },
                    { "@CodPostal", Convert.ToInt32(txtCodPostal.Text) },
                    { "@Fecha", dtpFecha.Value},
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
        }

        private void Modificar(Dictionary<string, object> cli)
        {
            cli.Add("@Username", cliente.Username);
            DBHelper.ExecuteNonQuery("Cliente_Modify", cli);
            DBHelper.ExecuteNonQuery("Usuario_Activo", new Dictionary<string, object>() { { "@Username", cliente.Username }, { "Activo", ckbEstado.Checked } });
            MessageBox.Show("Modificado con exito");
            Hide();
        }

        private void Alta(Dictionary<string, object> cli)
        {
            cli.Add("@Username", usuario.Username);
            DBHelper.ExecuteNonQuery("Usuario_Add", new Dictionary<string, object> { { "@Username", usuario.Username }, { "@Password", usuario.Password } });
            DBHelper.ExecuteNonQuery("Cliente_Add", cli);
            MessageBox.Show("Ingresado con exitos");
            Hide();
        }

        private bool DatosCompletados()
        {
            int result;
            if(txtNombre.Text == string.Empty || txtApellido.Text == string.Empty|| txtDni.Text == string.Empty ||  txtTipoDoc.Text== string.Empty || txtMail.Text == string.Empty ||
                txtTelefono.Text == string.Empty || txtDireccion.Text == string.Empty || txtCodPostal.Text == string.Empty || dtpFecha.Text == string.Empty){
               MessageBox.Show("Complete todos los campos por favor");
                return false;
            }

            if(!int.TryParse(txtDni.Text, out result)){
                MessageBox.Show("El campo DNI debe ser numérico.");
                return false;
            }
            if (!int.TryParse(txtCodPostal.Text, out result)) {
                MessageBox.Show("El campo Codigo Postal debe ser numérico.");
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
            DBHelper.ExecuteNonQuery("Usuario_Habilitar", new Dictionary<string, object>() { { "@Username", cliente.Username } });
            MessageBox.Show("Usuario habilitado nuevamente.");
            btnHabilitar.Visible = false;
        }

    }
}
