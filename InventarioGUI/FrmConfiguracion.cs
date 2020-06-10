using System;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void BtnCrearModificar_Click(object sender, EventArgs e)
        {
            new AgregarUsuario().Show();
        }

        private void BtnPqrs_Click(object sender, EventArgs e)
        {
            new Pqrs().Show();
        }

        private void BtnCambiarContraseña_Click(object sender, EventArgs e)
        {
            new CabiarContraseña().Show();
        }
    }
}
