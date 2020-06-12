using System.Collections.Generic;

namespace Entity
{
    public class Producto
    {
        public string IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public double PrecioProducto { get; set; }
        public List<CompuestoProducto> Compuestos { get; set; }
    }
}
