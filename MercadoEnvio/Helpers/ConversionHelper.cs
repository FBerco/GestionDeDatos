using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Clases;

namespace Helpers
{
    public static class ConversionHelper
    {

        #region USUARIO
        public static Usuario ToUsuario(this SqlDataReader rdr) {
            return rdr.ToUsuarios().FirstOrDefault();
        }
        public static List<Usuario> ToUsuarios(this SqlDataReader rdr) {
            List<Usuario> list = new List<Usuario>();
            while (rdr.Read()) {
                list.Add(new Usuario() {
                    Username = (string)rdr["usua_username"],
                    Activo = (bool)rdr["usua_activo"],
                    Password = (string)rdr["usua_password"]
                });
            }
            return list;
        }
        #endregion

        #region CLIENTE
        public static Cliente ToCliente(this SqlDataReader rdr)
        {
            return rdr.ToClientes().FirstOrDefault();
        }
        public static List<Cliente> ToClientes(this SqlDataReader rdr)
        {
            List<Cliente> list = new List<Cliente>();
            while (rdr.Read())
            {
                list.Add(new Cliente()
                {
                    //Username = (string)rdr["usua_username"],
                    //Activo = (bool)rdr["usua_activo"],
                    //Password = (string)rdr["usua_password"],
                    Nombre = (string)rdr["clie_nombre"],
                    Apellido = (string)rdr["clie_apellido"],
                    Dni = (int)rdr["clie_dni"],
                    TipoDocumento = (string)rdr["clie_tipo_documento"],
                    Mail = (string)rdr["clie_mail"],
                    Direccion = (string)rdr["clie_direccion"],
                    CodigoPostal = (int)rdr["clie_codigo_postal"],
                    FechaNacimiento = (DateTime)rdr["clie_fecha_nacimiento"],
                    Id = (int)rdr["clie_id"],
                });
            }
            return list;
        }
        #endregion

        #region EMPRESA
        public static Empresa ToEmpresa(this SqlDataReader rdr)
        {
            return rdr.ToEmpresas().FirstOrDefault();
        }
        public static List<Empresa> ToEmpresas(this SqlDataReader rdr)
        {
            List<Empresa> list = new List<Empresa>();
            while (rdr.Read())
            {
                list.Add(new Empresa()
                {
                    //Username = (string)rdr["usua_username"],
                    //Activo = (bool)rdr["usua_activo"],
                    //Password = (string)rdr["usua_password"],
                    RazonSocial = (string)rdr["empr_razonSocial"],
                    Mail = (string)rdr["empr_mail"],
                    Telefono = (string)rdr["empr_telefono"],
                    Direccion = (string)rdr["empr_direccion"],
                    CodigoPostal = (int)rdr["empr_codigoPostal"],
                    Ciudad = (string)rdr["empr_ciudad"],
                    Cuit = (int)rdr["empr_cuit"],
                    NombreContacto = (string)rdr["empr_nombreContacto"],
                    ReputacionTotal = (int)rdr["empr_reputacion_total"],
                    ReputacionCantVotos = (int)rdr["empr_reputacion_cantidadVotos"],
                    RubroId = (int)rdr["empr_rubroId"],
                    Id= (int)rdr["empr_id"],
                });
            }
            return list;
        }
        #endregion

        #region CALIFICACION
        public static Calificacion ToCalificacion(this SqlDataReader rdr)
        {
            return rdr.ToCalificaciones().FirstOrDefault();
        }
        public static List<Calificacion> ToCalificaciones(this SqlDataReader rdr)
        {
            List<Calificacion> list = new List<Calificacion>();
            while (rdr.Read())
            {
                list.Add(new Calificacion()
                {
                    Id = (int)rdr["cali_id"],
                    Estrellas = (int)rdr["cali_estrellas"],
                    Detalle = (string)rdr["cali_detalle"],
                    Fecha = (DateTime)rdr["cali_fecha"],
                    VentaId = (int)rdr["cali_venta"],
                });
            }
            return list;
        }
        #endregion

        #region ESTADO
        public static Estado ToEstado(this SqlDataReader rdr)
        {
            return rdr.ToEstados().FirstOrDefault();
        }
        public static List<Estado> ToEstados(this SqlDataReader rdr)
        {
            List<Estado> list = new List<Estado>();
            while (rdr.Read())
            {
                list.Add(new Estado()
                {
                    Id = (int)rdr["esta_id"],
                    Descripcion = (string)rdr["esta_detalle"],
                });
            }
            return list;
        }
        #endregion

        #region FACTURA
        public static Factura ToFactura(this SqlDataReader rdr)
        {
            return rdr.ToFacturas().FirstOrDefault();
        }
        public static List<Factura> ToFacturas(this SqlDataReader rdr)
        {
            List<Factura> list = new List<Factura>();
            while (rdr.Read())
            {
                list.Add(new Factura()
                {
                    Numero = (int)rdr["fact_id"],
                    Fecha = (DateTime)rdr["fact_fecha"],
                    Total = (int)rdr["fact_total"],
                    PublicacionId = (int)rdr["fact_publicacion"],
                });
            }
            return list;
        }
        #endregion

        #region ITEMFACTURA
        public static ItemFactura ToItemFactura(this SqlDataReader rdr)
        {
            return rdr.ToItemFacturas().FirstOrDefault();
        }
        public static List<ItemFactura> ToItemFacturas(this SqlDataReader rdr)
        {
            List<ItemFactura> list = new List<ItemFactura>();
            while (rdr.Read())
            {
                list.Add(new ItemFactura()
                {
                    FacturaId = (int)rdr["item_numeroFactura"],
                    Id = (int)rdr["item_id"],
                    Cantidad = (int)rdr["item_cantidad"],
                    PrecioUnitario = (int)rdr["item_precioUnitario"],
                });
            }
            return list;
        }
        #endregion

        #region OFERTA
        public static Oferta ToOferta(this SqlDataReader rdr)
        {
            return rdr.ToOfertas().FirstOrDefault();
        }
        public static List<Oferta> ToOfertas(this SqlDataReader rdr)
        {
            List<Oferta> list = new List<Oferta>();
            while (rdr.Read())
            {
                list.Add(new Oferta()
                {
                    Id = (int)rdr["ofer_id"],
                    Monto = (int)rdr["ofer_monto"],
                    Fecha = (DateTime)rdr["ofer_fecha"],
                    PublicacionId = (int)rdr["ofer_publid"],
                    ClienteId = (int)rdr["ofer_cliente"],
                });
            }
            return list;
        }
        #endregion
    }
}
