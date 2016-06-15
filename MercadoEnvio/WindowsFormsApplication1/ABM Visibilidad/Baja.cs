using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Helpers;
using Clases;

namespace GDD.ABM_Visibilidad
{
    public partial class frmBaja : Form
    {
 
        public frmBaja()
        {
            InitializeComponent();
        }

        private void frmBaja_Load(object sender, EventArgs e)
        {
            List<Visibilidad> visibilidades = DBHelper.ExecuteReader("Visibilidad_GetAll").ToVisibilidades();
            foreach(Visibilidad visibilidad in visibilidades)
            {
                cmbNombreVisibilidad.Items.Add(visibilidad.Detalle);  
            }           
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            //TENEMOS QUE VER SI LA BAJA ES LOGICA O LO BORRAMOS EFECTIVAMENTE DE LA TABLA
        }
        
        private Boolean estaSeguro()
        {
            return chkEstaSeguro.Checked;
        }
    }
}
