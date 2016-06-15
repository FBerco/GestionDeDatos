using System;
namespace Clases
{
    public class Publicacion
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public int Rubro { get; set; }
        public int Estado { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
        public int VisibilidadId { get; set; }
    }
}
