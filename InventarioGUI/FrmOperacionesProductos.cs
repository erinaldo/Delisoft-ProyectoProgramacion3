using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class FrmOperacionesProductos : MetroFramework.Forms.MetroForm
    {
        public FrmOperacionesProductos(Producto producto)
        {
            InitializeComponent();

            LlenarDatos(producto);
        }

        private void LlenarDatos(Producto producto)
        {
            TxtCodigo.Text = producto.IdProducto;
            TxtNombre.Text = producto.NombreProducto;
            TxtPrecio.Text = producto.PrecioProducto.ToString();

            DgvContenido.DataSource = producto.Compuestos;
        }
    }
}
