using DAL;
using Entity;

namespace BLL
{
    public class DetalleVentaService
    {
        private readonly ConnectionManager conexion;
        private readonly DetalleVentaRepository detalleVentaRepository;

        public DetalleVentaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            detalleVentaRepository = new DetalleVentaRepository(conexion);
        }

        public string Guardar(DetalleVenta detalleVenta)
        {

            try
            {
                conexion.Open();

                detalleVentaRepository.Guardar(detalleVenta);

                return $"se guardaron los datos correctamente ";
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
