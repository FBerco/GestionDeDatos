namespace Clases
{
    public class ItemFactura
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public string Detalle { get; set; }
    }
}
