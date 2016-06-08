using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Calificacion
    {
        public int Id { get; set; }
        public int Estrellas { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
        public int VentaId { get; set; }
    }
}
