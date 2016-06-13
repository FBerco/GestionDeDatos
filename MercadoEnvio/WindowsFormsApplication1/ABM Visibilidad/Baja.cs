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
        //VER EL TEMA DEL CHECKED STATE Y EL TEMA DE LA BASE DE DATOS
        public frmBaja()
        {
            InitializeComponent();
        }

        private void frmBaja_Load(object sender, EventArgs e)
        {
            List<Visibilidad> visibilidades = new List<Visibilidad>(); //DBHelper.ExecuteReader("nombreSPQueTraeTodasLasVisibilidadesActivas").ToVisibilidades;
            foreach(Visibilidad visibilidad in visibilidades)
            {
                cmbNombreVisibilidad.Items.Add(visibilidad.Detalle);  
            }
           
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
        if (false)//estaSeguro())
            {
            //String nombreVisibilidadADarDeBaja = cmbNombreVisibilidad.SelectedValue;
            Dictionary<String,Object> parametros = new Dictionary<String,Object>();
            Object nombreVisibilidadADarDeBaja; //borrar 
            parametros.Add("visi_detalle",nombreVisibilidadADarDeBaja);
            //DBHelper.ExecuteNonQuery("darDeBajaUnaVisibilidadSegunNombre", parametros);
            }
       
        }
        
        /*private Boolean estaSeguro()
        {
           // if (chkEstaSeguro.CheckState == checked){return true} else {return false};
        }*/
    }
}
