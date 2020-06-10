using DAL;
using Entity;
using Infraestructura;
using System;

namespace BLL
{
    public class UsuarioService
    {

        Email email = new Email();
        string mensajeEmail = string.Empty;
        private readonly ConnectionManager conexion;
        private readonly UsuarioRepository usuarioRepository;

        public UsuarioService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            usuarioRepository = new UsuarioRepository(conexion);
        }

        public string Guardar(Usuario usuario)
        {

            try
            {
                conexion.Open();

                usuarioRepository.Guardar(usuario);

                mensajeEmail = email.EnviarEmail(usuario);
                return $"se guardaron los datos correctamente " + mensajeEmail;
            }
            catch (System.Exception eg)
            {

                return "Error de Datos " + eg.Message;
            }
            finally
            {
                conexion.Close();
            }
        }

        public RespuestaConsultarCredenciales ConsultarCredenciales(string nombreUsuario, string contraseña)
        {
            RespuestaConsultarCredenciales respuesta = new RespuestaConsultarCredenciales();
            try
            {
                conexion.Open();
                respuesta.Usuario = usuarioRepository.ConsultarCredenciales(nombreUsuario, contraseña);
                conexion.Close();
                if (respuesta.Usuario == null)
                {
                    respuesta.Mensaje = "Existe un error con las credenciales, verifiquelas e intente nuevamente";
                }
                respuesta.Error = false;
                return respuesta;

            }
            catch (Exception e)
            {
                respuesta.Mensaje = "Error de aplicación " + e.Message;
                respuesta.Error = true;
                return respuesta;
            }
            finally
            {
                conexion.Close();
            }

        }
        public RespuestaConsultarIdentificacion ConsultarIdentificacion(string identificacion)
        {
            RespuestaConsultarIdentificacion respuesta = new RespuestaConsultarIdentificacion();
            try
            {
                conexion.Open();
                respuesta.Usuario = usuarioRepository.ConsultarIdentificacion(identificacion);
                respuesta.Error = false;
                if (respuesta.Usuario == null)
                {
                    respuesta.Mensaje = "El usuario no existe";
                }
                else
                {
                    respuesta.Mensaje = "Buscando";
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = "Error de aplicación " + e.Message;
                return respuesta;
            }
            finally
            {
                conexion.Close();
            }

        }

        public RespuestaConsultarEmail ConsultarEmail(string Email)
        {
            RespuestaConsultarEmail respuesta = new RespuestaConsultarEmail();
            try
            {
                conexion.Open();
                respuesta.Usuario = usuarioRepository.ConsultarEmail(Email);
                conexion.Close();
                respuesta.Error = false;
                if (respuesta.Usuario == null)
                {
                    respuesta.Mensaje = "El correo es incorrecto, verifiquelo";
                }
                else
                {
                    respuesta.Mensaje = "Se ha enviado un mensaje a su correo con la contraseña de la cuenta";
                }

                mensajeEmail = email.EnviarEmailContraseña(respuesta.Usuario);

                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = "Erro de aplicación " + e.Message;
                return respuesta;
            }
            finally
            {
                conexion.Close();
            }
        }

        public string Eliminar(Usuario usuario)
        {
            try
            {
                conexion.Open();

                usuarioRepository.Eliminar(usuario);

                return $"se ha eliminado correctamente";
            }
            catch (System.Exception eg)
            {

                return "Error de Datos " + eg.Message;
            }
            finally
            {
                conexion.Close();
            }
        }

        public string CambiarContraseña(Usuario usuario)
        {
            try
            {
                conexion.Open();
                usuarioRepository.CambiarContraseña(usuario);
                return $"se ha modificado la contraseña";
            }
            catch (System.Exception eg)
            {

                return "Error de Datos" + eg.Message;
            }
            finally
            {
                conexion.Close();
            }
        }


    }
    public class RespuestaConsultarCredenciales
    {
        public bool Error;
        public string Mensaje;
        public Usuario Usuario;
    }
    public class RespuestaConsultarIdentificacion
    {
        public bool Error;
        public string Mensaje;
        public Usuario Usuario;
    }
    public class RespuestaConsultarEmail
    {
        public bool Error;
        public string Mensaje;
        public Usuario Usuario;
    }
}
