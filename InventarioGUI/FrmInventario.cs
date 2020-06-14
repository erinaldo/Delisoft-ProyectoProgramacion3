using System;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            new FrmProducto().Show();
        }

        private void BtnMateriaPrima_Click(object sender, EventArgs e)
        {
            new FrmMateriaPrima().Show();
        }
    }
}
