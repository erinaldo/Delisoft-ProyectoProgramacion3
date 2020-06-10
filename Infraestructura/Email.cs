using Entity;
using System;
using System.Net.Mail;

namespace Infraestructura
{
    public class Email
    {
        private MailMessage email;
        private SmtpClient smtp;
        public Email()
        {
            smtp = new SmtpClient();
        }
        private void ConfigurarSmt()
        {
            ;
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("menriquemendoza@unicesar.edu.co", "MarioMendoza#02");
        }
        private void ConfigurarEmail(Usuario usuario)
        {
            email = new MailMessage();
            email.To.Add(usuario.Email);
            email.From = new MailAddress("menriquemendoza@unicesar.edu.co");
            email.Subject = "Mario Mendoza, Registro de usuario  " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            email.Body = $"Sr <b> {usuario.NombreUsuario} </b> <br>" +
                $"Se ha realizado su registro satisfactoriamente";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }
        public string EnviarEmail(Usuario usuario)
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmail(usuario);
                smtp.Send(email);
                return ("Correo enviado satisfactoriamente");
            }
            catch (Exception e)
            {

                return ("Error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }

        public void ConfigurarEmailContraseña(Usuario usuario)
        {
            email = new MailMessage();
            email.To.Add(usuario.Email);
            email.From = new MailAddress("menriquemendoza@unicesar.edu.co");
            email.Subject = $"Contraseña DELISOFT de {usuario.NombreUsuario}  " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            email.Body = $"Sr <b> {usuario.NombreUsuario} </b> <br>" +
                $"Su contraseña es {usuario.Contraseña} <br><br><br>" +
                $"Si desea cambiar su contraseña debe diirgirse a las configuraciones de la aplicación DELISOFT e ingresar al apartado de" +
                $"<b> CAMBIO DE CONTRASEÑA </b> <br><br><br> Atentamente, grupo de desarrollo de DELISOFT";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }

        public string EnviarEmailContraseña(Usuario usuario)
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmailContraseña(usuario);
                smtp.Send(email);
                return ("Correo enviado satisfactoriamente");
            }
            catch (Exception e)
            {

                return ("Error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }

        private void ConfigurarEmailPqrs(Pqrs pqrs)
        {
            email = new MailMessage();
            email.To.Add("marioereme12@gmail.com");
            email.From = new MailAddress("menriquemendoza@unicesar.edu.co");
            email.Subject = $"{pqrs.Asunto} " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            email.Body = $"Sr <b> Señores desarrolladores, este correo es enviado desde DELISOFT </b> <br><br><br>" +
                $"{pqrs.Contenido}";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }
        public string EnviarEmailPqrs(Pqrs pqrs)
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmailPqrs(pqrs);
                smtp.Send(email);
                return ("Correo enviado satisfactoriamente");
            }
            catch (Exception e)
            {
                return ("Error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }

        private void ConfigurarEmailVendedor(string filename)
        {
            email = new MailMessage();
            email.To.Add("marioereme12@gmail.com");
            email.From = new MailAddress("menriquemendoza@unicesar.edu.co");
            email.Subject = $"PDF Vendedores " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            email.Body = $"<b> este correo es enviado desde DELISOFT </b> <br><br><br>";
            email.Attachments.Add(new Attachment(filename));
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }

        public string EnviarEmailVendedor(string filename)
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmailVendedor(filename);
                smtp.Send(email);
                return ("Correo enviado satisfactoriamente");
            }
            catch (Exception e)
            {
                return ("Error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }
    }
}
