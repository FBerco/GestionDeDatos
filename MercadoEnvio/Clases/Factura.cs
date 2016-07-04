using System;
namespace Clases
{
    public class Factura
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int PublicacionId { get; set; }
    }
}
