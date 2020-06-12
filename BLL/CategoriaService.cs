using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class CategoriaService
    {
        private readonly ConnectionManager conexion;
        private readonly CategoriaRepository categoriaRepository;

        public CategoriaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            categoriaRepository = new CategoriaRepository(conexion);
        }

        public RespuestaConsultaCategorias Consultar()
        {
            RespuestaConsultaCategorias respuesta = new RespuestaConsultaCategorias();
            try
            {
                conexion.Open();
                respuesta.Categorias = categoriaRepository.Consultar();
                conexion.Close();
                if (respuesta.Categorias.Count > 0)
                {
                    respuesta.Mensaje = "Se consultaron los datos";
                }
                else
                {
                    respuesta.Mensaje = "Los datos no existen";
                }
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Error de la aplicación: " + e.Message;
                return respuesta;
            }
            finally
            {
                conexion.Close();
            }

        }

    }
    public class RespuestaConsultaCategorias
    {
        public string Mensaje;
        public bool Error;
        public List<Categoria> Categorias;
    }
}
