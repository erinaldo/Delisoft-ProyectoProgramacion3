using System.Collections.Generic;
using System.Linq;

namespace Entity
{
    public class Venta
    {
        public string IdVenta { get; set; }
        public Vendedor Vendedor { get; set; }
        public double ValorTotal { get; set; }
        public double Descuento { get; set; }
        public double DescuentoAplicado { get; set; }
        public double Subtotal { get; set; }
        public List<DetalleVenta> DetalleVenta { get; set; }
        public double IvaAplicado { get; set; }
        public const float IVA = 19;

        public void CalcularTotal()
        {
            CalcularIVA();
            CalcularDescuento();
            ValorTotal = ((Subtotal + IvaAplicado) - DescuentoAplicado);
        }
        public void CalcularDescuento()
        {
            DescuentoAplicado = (Subtotal * Descuento) / 100d;
        }
        public void CalcularSubtotal()
        {
            Subtotal = DetalleVenta.Sum(v => v.Total);
        }
        public void CalcularIVA()
        {
            CalcularSubtotal();
            IvaAplicado = (Subtotal * IVA) / 100d;
        }
    }
}
