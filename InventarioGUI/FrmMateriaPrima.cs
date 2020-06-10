using BLL;
using Entity;
using System;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class FrmMateriaPrima : MetroFramework.Forms.MetroForm
    {
        MateriaPrimaService materiaPrimaService;
        public FrmMateriaPrima()
        {
            InitializeComponent();
            materiaPrimaService = new MateriaPrimaService(ConfigConnection.connectionString);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MateriaPrima materiaPrima = new MateriaPrima()
            {
                Nombre = TxtNombre.Text.Trim(),
                Cantidad = Convert.ToInt32(NumCantidad.Text),
                Categoria = CmbCategorias.Text,
                FechaAlmacenamiento = DateTime.Now.ToString("dd/MM/yyyy")
            };
            string mensaje = materiaPrimaService.Guardar(materiaPrima);
            MessageBox.Show(mensaje, "error");
        }
    }
}
