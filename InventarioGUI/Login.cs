using BLL;
using System;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        UsuarioService usuarioService = new UsuarioService(ConfigConnection.connectionString);

        public Login()
        {
            InitializeComponent();
            OcultarContraseña();
        }

        public void OcultarContraseña()
        {
            TxtContraseña.UseSystemPasswordChar = true;
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            RespuestaConsultarCredenciales respuesta = new RespuestaConsultarCredenciales();
            try
            {
                string nombreUsuario = TxtUsuario.Text.Trim();
                string contraseña = TxtContraseña.Text.Trim();
                respuesta = usuarioService.ConsultarCredenciales(nombreUsuario, contraseña);
                if (TxtUsuario.Text.Equals(respuesta.Usuario.NombreUsuario) && TxtContraseña.Text.Equals(respuesta.Usuario.Contraseña))
                {
                    Principal fp = new Principal();
                    this.Hide();
                    fp.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ContraseñaOlvidada().Visible = true;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
