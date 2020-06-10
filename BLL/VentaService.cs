using DAL;
using Entity;

namespace BLL
{
    public class VentaService
    {
        private readonly ConnectionManager conexion;
        private readonly VentaRepository ventaRepository;

        public VentaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            ventaRepository = new VentaRepository(conexion);
        }

        public string Guardar(Venta venta)
        {

            try
            {
                conexion.Open();

                ventaRepository.Guardar(venta);

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
