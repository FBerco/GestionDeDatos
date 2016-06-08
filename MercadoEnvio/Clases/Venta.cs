using System;
namespace Clases
{
    public class Venta
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int PublicacionId { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
    }
}
