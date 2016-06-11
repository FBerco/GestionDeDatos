using System;
using System.Collections.Generic;
using System.Linq;
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
                    RazonSocial = (string)rdr["empr_razon_social"],
                    Mail = (string)rdr["empr_mail"],
                    Telefono = (string)rdr["empr_telefono"],
                    Direccion = (string)rdr["empr_direccion"],
                    CodigoPostal = (int)rdr["empr_codigoPostal"],
                    Ciudad = (string)rdr["empr_ciudad"],
                    Cuit = (int)rdr["empr_cuit"],
                    NombreContacto = (string)rdr["empr_nombre_contacto"],
                    ReputacionTotal = (int)rdr["empr_reputacion_total"],
                    ReputacionCantVotos = (int)rdr["empr_reputacion_cantidad_votos"],
                    RubroId = (int)rdr["empr_rubro"],
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
                    FacturaId = (int)rdr["item_factura"],
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

        #region PUBLICACION
        public static Publicacion ToPublicacion(this SqlDataReader rdr)
        {
            return rdr.ToPublicaciones().FirstOrDefault();
        }
        public static List<Publicacion> ToPublicaciones(this SqlDataReader rdr)
        {
            List<Publicacion> list = new List<Publicacion>();
            while (rdr.Read())
            {
                list.Add(new Publicacion()
                {
                    Id = (int)rdr["publ_id"],
                    Tipo = (string)rdr["publ_tipo"],
                    FechaInicio = (DateTime)rdr["publ_fecha_inicio"],
                    FechaVencimiento = (DateTime)rdr["publ_fecha_vencimiento"],
                    Descripcion = (string)rdr["publ_descripcion"],
                    UsuarioId = (int)rdr["publ_usuario"],
                    RubroId = (int)rdr["publ_rubro"],
                    EstadoId = (int)rdr["publ_estado"],
                    Stock = (int)rdr["publ_stock"],
                    Precio = (int)rdr["publ_precio"],
                    VisibilidadId = (int)rdr["publ_visibilidad"]
                });
            }
            return list;
        }
        #endregion

        #region ROL
        public static Rol ToRol(this SqlDataReader rdr)
        {
            return rdr.ToRoles().FirstOrDefault();
        }
        public static List<Rol> ToRoles(this SqlDataReader rdr)
        {
            List<Rol> list = new List<Rol>();
            while (rdr.Read())
            {
                list.Add(new Rol()
                {
                    Id = (int)rdr["rol_id"],
                    Nombre =(string)rdr["rol_nombre"]
                });
            }
            return list;
        }
        #endregion

        #region FUNCION
        public static Funcion ToFuncion(this SqlDataReader rdr)
        {
            return rdr.ToFunciones().FirstOrDefault();
        }
        public static List<Funcion> ToFunciones(this SqlDataReader rdr)
        {
            List<Funcion> list = new List<Funcion>();
            while (rdr.Read())
            {
                list.Add(new Funcion()
                {
                    Id = (int)rdr["func_id"],
                    Descripcion = (string)rdr["func_descripcion"]
                });
            }
            return list;
        }
        #endregion

        #region RUBRO
        public static Rubro ToRubro(this SqlDataReader rdr)
        {
            return rdr.ToRubros().FirstOrDefault();
        }
        public static List<Rubro> ToRubros(this SqlDataReader rdr)
        {
            List<Rubro> list = new List<Rubro>();
            while (rdr.Read())
            {
                list.Add(new Rubro()
                {
                    Id = (int)rdr["rubr_id"],
                    DescripcionCorta = (string)rdr["rubr_descripcion_corta"],
                    DescripcionLarga = (string)rdr["rubr_descripcion_larga"]
                });
            }
            return list;
        }
        #endregion

        #region VENTA
        public static Venta ToVenta(this SqlDataReader rdr)
        {
            return rdr.ToVentas().FirstOrDefault();
        }
        public static List<Venta> ToVentas(this SqlDataReader rdr)
        {
            List<Venta> list = new List<Venta>();
            while (rdr.Read())
            {
                list.Add(new Venta()
                {
                    Id = (int)rdr["vent_id"],
                    Cantidad = (int)rdr["vent_cantidad"],
                    PublicacionId = (int)rdr["vent_publicacion"],
                    Fecha = (DateTime)rdr["vent_fecha"],
                    ClienteId = (int)rdr["vent_cliente"],
                });
            }
            return list;
        }
        #endregion

        #region VISIBILIDAD
        public static Visibilidad ToVisibilidad(this SqlDataReader rdr)
        {
            return rdr.ToVisibilidades().FirstOrDefault();
        }
        public static List<Visibilidad> ToVisibilidades(this SqlDataReader rdr)
        {
            List<Visibilidad> list = new List<Visibilidad>();
            while (rdr.Read())
            {
                list.Add(new Visibilidad()
                {
                    Id = (int)rdr["visi_id"],
                    CostoEnvio = (int)rdr["visi_costo_envio"],
                    CostoPublicacion = (int)rdr["visi_costo_publicacion"],
                    Detalle = (string)rdr["visi_detalle"],
                    PorcentajeProducto = (int)rdr["visi_porcentaje_prod"]
                });
            }
            return list;
        }
        #endregion
    }
}
