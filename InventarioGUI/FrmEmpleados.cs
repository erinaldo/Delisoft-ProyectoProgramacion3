using BLL;
using Entity;
using System;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class FrmEmpleados : Form
    {
        VendedorService vendedorService;
        public FrmEmpleados()
        {
            InitializeComponent();
            vendedorService = new VendedorService(ConfigConnection.connectionString);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor()
            {
                IdVendedor = TxtIdentificacion.Text.Trim(),
                NombreVendedor = TxtNombres.Text.Trim()
            };

            string mensaje = vendedorService.Guardar(vendedor);
            if (mensaje.Equals("se guardaron los datos correctamente"))
            {
                MessageBox.Show(mensaje, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            new ConsultarEmpleado().Show();
        }
    }
}
