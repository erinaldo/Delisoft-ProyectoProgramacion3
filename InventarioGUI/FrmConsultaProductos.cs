using BLL;
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
    public partial class FrmConsultaProductos : MetroFramework.Forms.MetroForm
    {
        ProductoService productoService;
        public FrmConsultaProductos()
        {
            InitializeComponent();

            productoService = new ProductoService(ConfigConnection.connectionString);

            LlenarTabla();
        }

        private void LlenarTabla()
        {
            RespuestaConsultarProducto respuesta = productoService.Consultar();

            if (respuesta.ErrorProducto == false)
            {
                DgvProductos.DataSource = respuesta.productos;
                MessageBox.Show(respuesta.MensajeProducto, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta.MensajeProducto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto producto = (Producto)DgvProductos.CurrentRow.DataBoundItem;
            new FrmOperacionesProductos(producto).Show();
        }
    }
}
