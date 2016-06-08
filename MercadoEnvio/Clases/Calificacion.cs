using System;
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
