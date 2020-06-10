using BLL;
using System;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class CabiarContraseña : MetroFramework.Forms.MetroForm
    {
        UsuarioService usuarioService = new UsuarioService(ConfigConnection.connectionString);
        public CabiarContraseña()
        {
            InitializeComponent();
            OcultarContraseña();
        }

        private void OcultarContraseña()
        {
            TxtContraseniaActual.UseSystemPasswordChar = true;
            TxtContraseniaNueva.UseSystemPasswordChar = true;
            TxtConfirmacionContrasenia.UseSystemPasswordChar = true;
        }
        private void MostrarContraseña()
        {
            if (ChkMostrarContraseña.Checked)
            {
                TxtContraseniaActual.UseSystemPasswordChar = false;
                TxtContraseniaNueva.UseSystemPasswordChar = false;
                TxtConfirmacionContrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                OcultarContraseña();
            }
        }

        private void ChkMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            MostrarContraseña();
        }
        private void BtnCambioContrasenia_Click(object sender, EventArgs e)
        {
            RespuestaConsultarCredenciales respuesta = new RespuestaConsultarCredenciales();
            string nombreUsuario = TxtNombreUsuario.Text.Trim();
            string contraseñaActual = TxtContraseniaActual.Text.Trim();


            if (respuesta.Error == true)
            {
                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (TxtContraseniaNueva.Text.Equals(TxtConfirmacionContrasenia.Text))
                {
                    respuesta = usuarioService.ConsultarCredenciales(nombreUsuario, contraseñaActual);
                    string contraseñaNueva = TxtConfirmacionContrasenia.Text.Trim();
                    respuesta.Usuario.Contraseña = contraseñaNueva;
                    string mensaje = usuarioService.CambiarContraseña(respuesta.Usuario);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
