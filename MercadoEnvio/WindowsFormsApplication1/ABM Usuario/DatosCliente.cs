using Clases;
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
        public frmCliente(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }
    }
}
