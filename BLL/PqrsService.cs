using DAL;
using Entity;
using Infraestructura;

namespace BLL
{
    public class PqrsService
    {
        private readonly ConnectionManager conexion;
        private readonly PqrsRepository pqrsRepository;
        Email email = new Email();
        string mensajeEmail = string.Empty;
        public PqrsService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            pqrsRepository = new PqrsRepository(conexion);
        }

        public string Guardar(Pqrs pqrs)
        {
            try
            {
                conexion.Open();

                pqrsRepository.Guardar(pqrs);

                mensajeEmail = email.EnviarEmailPqrs(pqrs);
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
    }
}
