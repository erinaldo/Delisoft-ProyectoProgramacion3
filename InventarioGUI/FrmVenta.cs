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
        List<MateriaPrima> materiaPrimas;
        DetalleVentaService detalleVentaService;
        VendedorService vendedorService;
        ProductoService productoService;
        VentaService ventaService;
        CompuestoProductoService compuestoProductoService;
        MateriaPrimaService materiaPrimaService;
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

            compuestoProductoService = new CompuestoProductoService(ConfigConnection.connectionString);
            materiaPrimaService = new MateriaPrimaService(ConfigConnection.connectionString);
            materiaPrimas = new List<MateriaPrima>();

            InitializeComponent();

            LlenarVendedor();
            LlenarProducto();

            Limpiar();
        }

        private void ChkDescuento_CheckedChanged(object sender, System.EventArgs e)
        {
            if (ChkDescuento.Checked)
            {
                TxtDescuento.Enabled = true;
                TxtDescuento.Text = "";
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

            RespuestaConsultarProducto respuesta = productoService.Consultar();
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
            RespuestaFiltroProducto respuesta = productoService.FiltrarCodigo(TxtCodigo.Text);


            DetalleVenta detalleVenta = new DetalleVenta()
            {
                Producto = respuesta.producto,
                Cantidad = Convert.ToInt32(PckCantidad.Value.ToString())
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

            Venta venta = new Venta()
            {
                Vendedor = vendedor,
                Descuento = Convert.ToDouble(TxtDescuento.Text),
                DetalleVenta = detallesVentas
            };

            venta.CalcularTotal();

            return venta;
        }

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

            if (mensaje.Equals("Se guardaron los datos correctamente"))
            {
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (var detalleVenta in venta.DetalleVenta)
            {
                string mensajeDetalleVenta = detalleVentaService.Guardar(detalleVenta);
                MessageBox.Show(mensajeDetalleVenta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DescuentoMateriaPrima();
        }

        public void Limpiar()
        {
            CmbVendedor.SelectedIndex = 0;
            CmbProducto.SelectedIndex = 0;
            TxtCodigo.Text = "";
            PckCantidad.Value = 1;
            DgvProductos.DataSource = null;
            TxtSubtotal.Text = "";
            TxtIva.Text = "";
            TxtDescuento.Text = "";
            TxtTotal.Text = "";
            ChkDescuento.Checked = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(indice != -1)
            {
                DgvProductos.Rows.RemoveAt(indice);
            }
        }

        private void DescuentoMateriaPrima()
        {
            RespuestaConsultarMateriaPrima respuestaMateria = materiaPrimaService.Consultar();

            RespuestaConsultaCompuestos respuesta;
            foreach (var detalleVenta in detallesVentas)
            {
                respuesta = compuestoProductoService.Consulta(detalleVenta.Producto.IdProducto);
                foreach (var compuestoProducto in respuesta.compuestos)
                {
                    MateriaPrima materia = respuestaMateria.MateriasPrimas.Find(mp => mp.Codigo.Equals(compuestoProducto.MateriaPrima.Codigo));
                    string mensaje = materiaPrimaService.Modificar(compuestoProducto.MateriaPrima.Codigo, (materia.CantidadTotal - (compuestoProducto.CantidadUnitaria * detalleVenta.Cantidad)));
                    MessageBox.Show(mensaje);
                }
            }
        }
    }
}
