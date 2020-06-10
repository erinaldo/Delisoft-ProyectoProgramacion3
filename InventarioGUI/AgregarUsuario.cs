using BLL;
using Entity;
using System;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class AgregarUsuario : MetroFramework.Forms.MetroForm
    {
        UsuarioService usuarioService = new UsuarioService(ConfigConnection.connectionString);
        Usuario usuario;
        public AgregarUsuario()
        {
            InitializeComponent();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            usuario = new Usuario()
            {
                NombreUsuario = TxtUsuario.Text.Trim(),
                Contraseña = TxtContraseña.Text.Trim(),
                Identificacion = TxtIdentificacion.Text.Trim(),
                Email = TxtEmail.Text.Trim()
            };
            string mensaje = usuarioService.Guardar(usuario);
            if (mensaje.Equals("se guardaron los datos correctamente"))
            {
                MessageBox.Show(mensaje, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RespuestaConsultarIdentificacion respuesta = new RespuestaConsultarIdentificacion();

            respuesta = usuarioService.ConsultarIdentificacion(TxtIdentificacion.Text.Trim());


            if (respuesta.Error == true)
            {
                MessageBox.Show(respuesta.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TxtUsuario.Text = respuesta.Usuario.NombreUsuario;
                TxtContraseña.Text = respuesta.Usuario.Contraseña;
                TxtEmail.Text = respuesta.Usuario.Email;

                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (TxtEmail.Text != "")
            {
                TxtIdentificacion.Enabled = false;
                BtnEliminar.Enabled = true;
                BtnEditar.Enabled = true;
                BtnAgregar.Enabled = false;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = usuarioService.Eliminar(usuario);
            if (mensaje.Equals("se ha eliminado correctamente"))
            {
                MessageBox.Show(mensaje, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
