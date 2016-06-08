using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ItemFactura
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
    }
}
