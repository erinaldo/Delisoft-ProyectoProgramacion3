using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CompuestoProducto
    {
        public string Codigo { get; set; }
        public MateriaPrima MateriaPrima { get; set; }
        public Producto Producto { get; set; }
        public int CantidadUnitaria { get; set; }
    }
}
