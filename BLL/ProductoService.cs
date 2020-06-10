using DAL;
using Entity;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class ProductoService
    {
        private readonly ConnectionManager conexion;
        private readonly ProductoRepository productoRepository;

        public ProductoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            productoRepository = new ProductoRepository(conexion);
        }

        public string Guardar(Producto producto)
        {

            try
            {
                conexion.Open();

                productoRepository.Guardar(producto);

                conexion.Close();

                conexion.Open();

                productoRepository.GuardarIntercepta(producto);

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

        public RespuestaConsultarProducto Consultar()
        {
            RespuestaConsultarProducto respuesta = new RespuestaConsultarProducto();
            try
            {
                conexion.Open();
                respuesta.productos = productoRepository.Consultar();
                conexion.Close();
                if (respuesta.productos.Count > 0)
                {
                    respuesta.MensajeProducto = "Se consultaron los datos";
                }
                else
                {
                    respuesta.MensajeProducto = "Los datos no existen";
                }
                respuesta.ErrorProducto = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.ErrorProducto = true;
                respuesta.MensajeProducto = $"Error de la aplicación: " + e.Message;
                return respuesta;
            }
            finally
            {
                conexion.Close();
            }

        }

        public RespuestaFiltroProducto FiltrarCodigo(string codigo)
        {
            RespuestaFiltroProducto respuesta = new RespuestaFiltroProducto();
            try
            {
                respuesta.producto = productoRepository.FiltrarCodigo(codigo);
                respuesta.ErrorProductoCodigo = false;
                respuesta.MensajeProductoCodigo = "Se buscaron satisfactoriamente";

                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.ErrorProductoCodigo = true;
                respuesta.MensajeProductoCodigo = "Error de aplicacion" + e.Message;
                return respuesta;
            }
        }
    }

    public class RespuestaFiltroProducto
    {
        public string MensajeProductoCodigo;
        public Producto producto;
        public bool ErrorProductoCodigo;
    }
    public class RespuestaConsultarProducto
    {
        public string MensajeProducto;
        public List<Producto> productos;
        public bool ErrorProducto;
    }
}
