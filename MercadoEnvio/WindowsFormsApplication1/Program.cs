using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Clases;

namespace GDD
{
    static class Program
    {
        public static Usuario usuario;
        public static Rol rol;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
    }
}
