using System.Windows.Forms;
using Entity;
using BLL;
using System.Collections.Generic;
using System;

namespace InventarioGUI
{
    public partial class FrmVenta : Form
    {
        List<Vendedor> vendedores;
        List<Producto> productos;
        List<DetalleVenta> detallesVentas;
        DetalleVentaService detalleVentaService;
        VendedorService vendedorService;
        ProductoService productoService;
        VentaService ventaService;
        int indice;
        public FrmVenta()
        {
            vendedorService = new VendedorService(ConfigConnection.connectionString);
            vendedores = new List<Vendedor>();

            productoService = new ProductoService(ConfigConnection.connectionString);
            productos = new List<Producto>();

            detalleVentaService = new DetalleVentaService(ConfigConnection.connectionString);
            detallesVentas = new List<DetalleVenta>();

            ventaService = new VentaService(ConfigConnection.connectionString);

            InitializeComponent();

            LlenarVendedor();
            LlenarProducto();
        }

        private void ChkDescuento_CheckedChanged(object sender, System.EventArgs e)
        {
            if (ChkDescuento.Checked)
            {
                TxtDescuento.Enabled = true;
            }
            else
            {
                TxtDescuento.Enabled = false;
            }
        }

        private void LlenarVendedor()
        {
            CmbVendedor.Items.Clear();

            RespuestaConsultar respuesta = new RespuestaConsultar();
            respuesta = vendedorService.Consultar();
            vendedores = respuesta.Vendedores;

            if (respuesta.Error == false)
            {
                CmbVendedor.Items.Add("VENDEDORES");
                foreach (var vendedor in vendedores)
                {
                    CmbVendedor.Items.Add($"{vendedor.NombreVendedor}");
                }
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarProducto()
        {
            CmbProducto.Items.Clear();

            RespuestaConsultarProducto respuesta = new RespuestaConsultarProducto();
            respuesta = productoService.Consultar();
            productos = respuesta.productos;

            if (respuesta.ErrorProducto == false)
            {
                CmbProducto.Items.Add("PRODUCTOS");
                foreach (var producto in productos)
                {
                    CmbProducto.Items.Add(producto.NombreProducto);
                }
            }
        }

        private void CmbProducto_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            foreach (var producto in productos)
            {
                if (CmbProducto.Text.Equals(producto.NombreProducto))
                {
                    productoService.FiltrarCodigo(producto.IdProducto);
                    TxtCodigo.Text = producto.IdProducto;
                    break;
                }
            }
        }

        private void BtnAgregar_Click(object sender, System.EventArgs e)
        {
            RespuestaFiltroProducto respuesta = new RespuestaFiltroProducto();
            respuesta = productoService.FiltrarCodigo(TxtCodigo.Text);


            DetalleVenta detalleVenta = new DetalleVenta()
            {
                Producto = respuesta.producto,
                Cantidad = Convert.ToInt32(PckCantidad.Value.ToString()),
            };

            detalleVenta.CalcularTotal();

            detallesVentas.Add(detalleVenta);

            indice = DgvProductos.Rows.Add();

            DgvProductos.Rows[indice].Cells[0].Value = detalleVenta.Producto.IdProducto;
            DgvProductos.Rows[indice].Cells[1].Value = detalleVenta.Producto.NombreProducto;
            DgvProductos.Rows[indice].Cells[2].Value = detalleVenta.Cantidad;
            DgvProductos.Rows[indice].Cells[3].Value = detalleVenta.Producto.PrecioProducto;
            DgvProductos.Rows[indice].Cells[4].Value = detalleVenta.Total;            
        }

        public Venta CrearVenta()
        {
            Vendedor vendedor = vendedores.Find(v => v.NombreVendedor.Equals(CmbVendedor.Text));

            foreach (var item in detallesVentas)
            {
                item.CodigoVenta = CodVenta.ToString();
            }

            Venta venta = new Venta()
            {
                IdVenta = CodVenta.ToString(),
                Vendedor = vendedor,
                Descuento = Convert.ToDouble(TxtDescuento.Text),
                DetalleVenta = detallesVentas
            };

            venta.CalcularTotal();

            return venta;
        }

        int CodVenta = 30;

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Venta venta = CrearVenta();

            TxtSubtotal.Text = venta.Subtotal.ToString();
            TxtIva.Text = venta.IvaAplicado.ToString();
            TxtDescuento.Text = venta.DescuentoAplicado.ToString();
            TxtTotal.Text = venta.ValorTotal.ToString();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Venta venta = CrearVenta();

            string mensaje = ventaService.Guardar(venta);

            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (var detalleVenta in venta.DetalleVenta)
            {
                string mensajeDetalleVenta = detalleVentaService.Guardar(detalleVenta);
                MessageBox.Show(mensajeDetalleVenta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
