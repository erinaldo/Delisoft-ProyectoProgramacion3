using BLL;
using System;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class Bodega : MetroFramework.Forms.MetroForm
    {
        MateriaPrimaService materiaPrimaService;
        ProductoService productoService;
        public Bodega()
        {
            InitializeComponent();
            materiaPrimaService = new MateriaPrimaService(ConfigConnection.connectionString);
            productoService = new ProductoService(ConfigConnection.connectionString);
        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblProductos.DataSource = null;

            if (CmbTipo.Text.Equals("Materia Prima"))
            {
                RespuestaConsultarMateriaPrima respuestaConsultar = new RespuestaConsultarMateriaPrima();
                respuestaConsultar = materiaPrimaService.Consultar();

                if (respuestaConsultar.ErrorMateriaPrima == false)
                {
                    
                    tblProductos.DataSource = respuestaConsultar.MateriasPrimas;
                    MessageBox.Show(respuestaConsultar.MensajeMateriaPrima, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuestaConsultar.MensajeMateriaPrima, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                RespuestaConsultarProducto respuesta = new RespuestaConsultarProducto();
                respuesta = productoService.Consultar();

                if (respuesta.ErrorProducto == false)
                {
                    tblProductos.DataSource = respuesta.productos;
                    MessageBox.Show(respuesta.MensajeProducto, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta.MensajeProducto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
