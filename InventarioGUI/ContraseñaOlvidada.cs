using BLL;
using System;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class ContraseñaOlvidada : MetroFramework.Forms.MetroForm
    {
        UsuarioService usuarioService = new UsuarioService(ConfigConnection.connectionString);
        public ContraseñaOlvidada()
        {
            InitializeComponent();
        }
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            RespuestaConsultarEmail respuesta = new RespuestaConsultarEmail();
            string email = TxtEmail.Text.Trim();
            respuesta = usuarioService.ConsultarEmail(email);
            if (respuesta.Error == true)
            {
                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
