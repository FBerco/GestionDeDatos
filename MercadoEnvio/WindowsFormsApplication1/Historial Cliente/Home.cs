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

namespace GDD.Historial_Cliente
{
    public partial class frmHome : Form
    {
        private Usuario usuario;
        public frmHome(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }
    }
}
