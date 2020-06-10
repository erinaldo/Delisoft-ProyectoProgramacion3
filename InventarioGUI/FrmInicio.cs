using System;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
