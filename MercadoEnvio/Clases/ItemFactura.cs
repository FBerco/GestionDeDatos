namespace Clases
{
    public class ItemFactura
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Detalle { get; set; }
    }
}
