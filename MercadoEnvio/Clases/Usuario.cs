using System;
namespace Clases
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
    }

    public class Empresa : Usuario
    {
        public int Id { get; set; }
        public int RazonSocial { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int CodigoPostal { get; set; }
        public string Ciudad { get; set; }
        public string Cuit { get; set; }
        public string NombreContacto { get; set; }
        public int ReputacionTotal { get; set; }
        public int ReputacionCantVotos { get; set; }
        public int RubroId { get; set; }
    }

    public class Cliente : Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string TipoDocumento { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int CodigoPostal { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
