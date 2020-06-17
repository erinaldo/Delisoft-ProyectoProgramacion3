using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CompuestoProductoService
    {
        private readonly ConnectionManager conexion;
        private readonly CompuestoProductoRepository compuestoProductoRepository;

        public CompuestoProductoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            compuestoProductoRepository = new CompuestoProductoRepository(conexion);
        }

        public string Guardar(CompuestoProducto compuestoProducto)
        {

            try
            {
                conexion.Open();

                compuestoProductoRepository.Guardar(compuestoProducto);

                conexion.Close();

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

        public RespuestaConsultaCompuestos Consulta(string codigoproducto)
        {
            RespuestaConsultaCompuestos respuesta = new RespuestaConsultaCompuestos();
            try
            {
                conexion.Open();

                respuesta.compuestos = compuestoProductoRepository.Consultar(codigoproducto);

                conexion.Close();

                respuesta.Error = false;
                respuesta.Mensaje = "Consulta realizada";

                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = "Error de aplicación " + e.Message;
                return respuesta;
            }
        }
    }

    public class RespuestaConsultaCompuestos
    {
        public List<CompuestoProducto> compuestos;
        public string Mensaje;
        public bool Error;
    }
}
