using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Oferta
    {
        public int Id { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int PublicacionId { get; set; }
        public int ClienteId { get; set; }
    }
}
