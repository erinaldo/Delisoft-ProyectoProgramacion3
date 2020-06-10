namespace Entity
{
    public class DetalleVenta
    {
        public string IdDetalleVenta { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }
        public string CodigoVenta { get; set; }

        public void CalcularTotal()
        {
            Total = Producto.PrecioProducto * Cantidad;
        }
    }
}
