using System;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class Principal : MetroFramework.Forms.MetroForm
    {
        public Principal()
        {
            InitializeComponent();
            AbrirFormularios(new FrmInicio());
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmInicio());
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmInventario());

        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmVenta());
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmEmpleados());
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmConfiguracion());
        }

        private void AbrirFormularios(object formhijo)
        {
            if (this.PnlPrincipal.Controls.Count > 0)
                this.PnlPrincipal.Controls.RemoveAt(0);

            Form frm = formhijo as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.PnlPrincipal.Controls.Add(frm);
            this.PnlPrincipal.Tag = frm;
            frm.Show();

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea cerrar la sesion actual", "Desea cerrar la sesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                new Login().Visible = true;
                this.Visible = false;
            }
        }
    }
}
