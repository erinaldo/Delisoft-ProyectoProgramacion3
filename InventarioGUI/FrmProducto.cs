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
        MateriaPrimaService materiaPrimaService;
        ProductoService productoService;
        int indice;
        public FrmProducto()
        {
            InitializeComponent();
            materiaPrimaService = new MateriaPrimaService(ConfigConnection.connectionString);
            productoService = new ProductoService(ConfigConnection.connectionString);
            ConsultarMateriaPrima();
        }
        public void ConsultarMateriaPrima()
        {
            RespuestaConsultarMateriaPrima respuestaConsultar = new RespuestaConsultarMateriaPrima();
            respuestaConsultar = materiaPrimaService.Consultar();

            if (respuestaConsultar.ErrorMateriaPrima == false)
            {
                CmbCategoria.Items.Add("CATEGORIAS");
                materiasPrimas = respuestaConsultar.MateriasPrimas;
                foreach (var materiaPrima in materiasPrimas)
                {
                }



            }
        }

        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbMateriaPrima.Items.Clear();


        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            RespuestaFiltroPorCodigo respuestas = new RespuestaFiltroPorCodigo();
            respuestas = materiaPrimaService.ConsultarCodigo(CmbMateriaPrima.Text);

            indice = TblMateriaPrima.Rows.Add();

            if (respuestas.ErrorFiltroCodigo == false)
            {
                try
                {
                    TblMateriaPrima.Rows[indice].Cells[0].Value = respuestas.materiaPrima.Codigo;
                    TblMateriaPrima.Rows[indice].Cells[1].Value = respuestas.materiaPrima.Nombre;
                    TblMateriaPrima.Rows[indice].Cells[2].Value = respuestas.materiaPrima.Cantidad;
                    TblMateriaPrima.Rows[indice].Cells[3].Value = respuestas.materiaPrima.FechaAlmacenamiento;
                    MessageBox.Show(respuestas.MensajeFiltroCodigo, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Algunos de los campos son invalidos, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(respuestas.MensajeFiltroCodigo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto()
            {
                IdProducto = TxtIdeProducto.Text,
                NombreProducto = TxtNombre.Text,
                PrecioProducto = Convert.ToDouble(TxtPrecioUnidad.Text),
            };
            string mensaje = productoService.Guardar(producto);

            MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar();
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

        private List<MateriaPrima> LlenarTabla()
        {
            try
            {
                List<MateriaPrima> materiasPrimasProducto = new List<MateriaPrima>();
                for (int i = 0; i <= indice; i++)
                {
                    MateriaPrima materiaPrima = new MateriaPrima()
                    {
                        Codigo = TblMateriaPrima.Rows[indice].Cells[0].Value.ToString(),
                        Nombre = TblMateriaPrima.Rows[indice].Cells[1].Value.ToString(),
                        Cantidad = Convert.ToInt32(TblMateriaPrima.Rows[indice].Cells[2].Value.ToString()),
                        FechaAlmacenamiento = TblMateriaPrima.Rows[indice].Cells[3].Value.ToString(),
                    };

                    materiasPrimasProducto.Add(materiaPrima);
                }
                return materiasPrimasProducto;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Limpiar()
        {
            TxtIdeProducto.Text = "";
            TxtNombre.Text = "";
            TxtPrecioUnidad.Text = "";
            CmbMateriaPrima.SelectedIndex = 0;
            CmbCategoria.SelectedIndex = 0;
            TblMateriaPrima.DataSource = "";
        }
    }
}
