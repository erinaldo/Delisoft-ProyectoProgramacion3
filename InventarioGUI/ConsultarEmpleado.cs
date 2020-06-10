using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class ConsultarEmpleado : MetroFramework.Forms.MetroForm
    {
        VendedorService vendedorService = new VendedorService(ConfigConnection.connectionString);
        List<Vendedor> ListaVendedores = new List<Vendedor>();
        public ConsultarEmpleado()
        {
            InitializeComponent();
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            RespuestaConsultar Respuesta = new RespuestaConsultar();
            Respuesta = vendedorService.Consultar();
            if (Respuesta.Error == false)
            {
                TblEmpleados.DataSource = Respuesta.Vendedores;
                MessageBox.Show(Respuesta.Mensaje, "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            RespuestaFiltrosVendedor respuesta = vendedorService.FiltroPorNombre(TxtNombre.Text.Trim());

            if (respuesta.Error == false)
            {
                TblEmpleados.DataSource = respuesta.vendedores;
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtIdentificaicon_KeyPress(object sender, KeyPressEventArgs e)
        {
            RespuestaFiltrosVendedor respuesta = vendedorService.FiltroPorIdentificacion(TxtIdentificaicon.Text.Trim());

            if(respuesta.Error == false)
            {
                TblEmpleados.DataSource = respuesta.vendedores;
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TblEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Vendedor vendedor = (Vendedor)TblEmpleados.CurrentRow.DataBoundItem;
            TxtIdentificaicon.Text = vendedor.IdVendedor;
            TxtNombre.Text = vendedor.NombreVendedor;

            if (!(TxtIdentificaicon.Text.Equals("") && TxtNombre.Text.Equals("")))
            {
                BtnEliminar.Enabled = true;
                BtnEditar.Enabled = true;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor()
            {
                IdVendedor = TxtIdentificaicon.Text.Trim(),
                NombreVendedor = TxtNombre.Text.Trim()
            };
            string mensaje = vendedorService.Eliminar(vendedor);

            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor()
            {
                IdVendedor = TxtIdentificaicon.Text.Trim(),
                NombreVendedor = TxtNombre.Text.Trim()
            };

            string mensaje = vendedorService.Editar(vendedor);

            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGenerarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Guardar Informe";

            saveFileDialog.InitialDirectory = @"c:/document";

            saveFileDialog.DefaultExt = "pdf";

            string filename = "";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                filename = saveFileDialog.FileName;

                if (filename != "" && ListaVendedores.Count > 0)

                {

                    string mensaje = vendedorService.GenerarPdf(ListaVendedores, filename);

                    MessageBox.Show(mensaje, "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else

                {

                    MessageBox.Show("No se especifico una ruta o No hay datos para generar el reporte", "Generar Pdf", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                }

            }
        }
    }
}
