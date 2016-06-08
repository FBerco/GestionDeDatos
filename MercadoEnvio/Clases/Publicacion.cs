using System;
namespace Clases
{
    public class Publicacion
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaInicio { get; set; }
        public int FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioId { get; set; }
        public int RubroId { get; set; }
        public int EstadoId { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
        public int VisibilidadId { get; set; }
    }
}
