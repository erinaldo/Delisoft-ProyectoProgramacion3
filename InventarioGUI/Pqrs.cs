using BLL;
using System;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class Pqrs : MetroFramework.Forms.MetroForm
    {
        PqrsService pqrsService = new PqrsService(ConfigConnection.connectionString);
        public Pqrs()
        {
            InitializeComponent();
        }
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Entity.Pqrs pqrs = new Entity.Pqrs()
            {
                Asunto = TxtAsunto.Text.Trim(),
                Contenido = TxtCuerpo.Text.Trim()
            };

            string mensaje = pqrsService.Guardar(pqrs);

            if (mensaje.Contains("se guardaron los datos correctamente"))
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Limpiar()
        {
            TxtAsunto.Text = "";
            TxtCuerpo.Text = "";
        }
    }
}
