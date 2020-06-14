using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class FrmProducto : MetroFramework.Forms.MetroForm
    {
        List<MateriaPrima> materiasPrimas;
        List<CompuestoProducto> compuestosProducto = new List<CompuestoProducto>();

        CompuestoProductoService compuestoProductoService;
        MateriaPrimaService materiaPrimaService;
        ProductoService productoService;
        int indice;
        public FrmProducto()
        {
            InitializeComponent();
            materiaPrimaService = new MateriaPrimaService(ConfigConnection.connectionString);
            productoService = new ProductoService(ConfigConnection.connectionString);
            compuestoProductoService = new CompuestoProductoService(ConfigConnection.connectionString);
            LlenarMateriaPrima();
        }
        public void LlenarMateriaPrima()
        {
            RespuestaConsultarMateriaPrima respuesta = materiaPrimaService.Consultar();
            materiasPrimas = respuesta.MateriasPrimas;

            if (respuesta.ErrorMateriaPrima == false)
            {
                foreach (var materiaPrima in respuesta.MateriasPrimas)
                {
                    CmbMateria.Items.Add(materiaPrima.Nombre);
                }
            }
            else
            {
                MessageBox.Show(respuesta.MensajeMateriaPrima, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MateriaPrima materiaPrima = materiasPrimas.Find(m => m.Nombre.Equals(CmbMateria.Text));

            CompuestoProducto compuesto = new CompuestoProducto()
            {
                CantidadUnitaria = Convert.ToInt32(NumCantidad.Value),
                MateriaPrima = materiaPrima
            };

            compuestosProducto.Add(compuesto);

            indice = TblMateriaPrima.Rows.Add();

            try
            {
                TblMateriaPrima.Rows[indice].Cells[0].Value = materiaPrima.Codigo;
                TblMateriaPrima.Rows[indice].Cells[1].Value = materiaPrima.Nombre;
                TblMateriaPrima.Rows[indice].Cells[2].Value = NumCantidad.Value.ToString();
                TblMateriaPrima.Rows[indice].Cells[3].Value = materiaPrima.FechaAlmacenamiento;
            }
            catch (Exception)
            {
                MessageBox.Show("Algunos de los campos son invalidos, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (indice != -1)
            {
                TblMateriaPrima.Rows.RemoveAt(indice);
            }
        }

        private void TblMateriaPrima_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        public void Limpiar()
        {
            TxtIdeProducto.Text = "";
            TxtNombre.Text = "";
            TxtPrecioUnidad.Text = "";
            CmbMateria.SelectedIndex = 0;
            CmbMateria.SelectedIndex = 0;
            TblMateriaPrima.DataSource = "";
        }

        private void BtnGuardarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto()
            {
                NombreProducto = TxtNombre.Text,
                PrecioProducto = Convert.ToDouble(TxtPrecioUnidad.Text),
                Compuestos = compuestosProducto
            };

            string mensaje1 = productoService.Guardar(producto);
            MessageBox.Show(mensaje1, "Mensaje");

            foreach (var compuesto in compuestosProducto)
            {
                string mensaje2 = compuestoProductoService.Guardar(compuesto);
                MessageBox.Show(mensaje2, "Mensaje");
            }

            
            
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            new FrmConsultaProductos().Show();
        }
    }
}
