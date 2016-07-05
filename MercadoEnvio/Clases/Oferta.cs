using System;
namespace Clases
{
    public class Oferta
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int PublicacionId { get; set; }
        public int ClienteId { get; set; }
    }
}
