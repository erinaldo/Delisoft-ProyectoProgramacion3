using DAL;
using Entity;
using Infraestructura;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class VendedorService
    {
        Email email = new Email();
        string mensajeEmail = string.Empty;
        private readonly ConnectionManager conexion;
        private readonly VendedorRepository vendedorRepository;

        public VendedorService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            vendedorRepository = new VendedorRepository(conexion);
        }

        public string Guardar(Vendedor vendedor)
        {
            try
            {
                conexion.Open();

                vendedorRepository.Guardar(vendedor);

                return $"se guardaron los datos correctamente";
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

        public RespuestaConsultar Consultar()
        {
            RespuestaConsultar respuesta = new RespuestaConsultar();
            try
            {
                conexion.Open();
                respuesta.Vendedores = vendedorRepository.Consultar();
                conexion.Close();
                if (respuesta.Vendedores.Count > 0)
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

        public RespuestaFiltrosVendedor FiltroPorNombre(string nombre)
        {
            RespuestaFiltrosVendedor respuesta = new RespuestaFiltrosVendedor();
            try
            {
                respuesta.vendedores = vendedorRepository.FiltroPorNombre(nombre);
                respuesta.Error = false;
                respuesta.Mensaje = "Se ha realizado el filtro";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = "Error de aplicacion: " + e.Message;
                return respuesta;
            }
        }

        public RespuestaFiltrosVendedor FiltroPorIdentificacion(string identificacion)
        {
            RespuestaFiltrosVendedor respuesta = new RespuestaFiltrosVendedor();
            try
            {
                respuesta.vendedores = vendedorRepository.FiltroPorIdentificacion(identificacion);
                respuesta.Error = false;
                respuesta.Mensaje = "Se ha realizado el filtro";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = "Error de aplicacion: " + e.Message;
                return respuesta;
            }
        }

        public string Eliminar(Vendedor vendedor)
        {
            try
            {
                conexion.Open();

                vendedorRepository.Eliminar(vendedor);

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

        public string Editar(Vendedor vendedor)
        {
            try
            {
                conexion.Open();
                vendedorRepository.Editar(vendedor);
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

        public string GenerarPdf(List<Vendedor> vendedores, string filename)
        {
            DocumentoPdf documentoPdf = new DocumentoPdf();
            try
            {
                documentoPdf.GuardarPdf(vendedores, filename);
                mensajeEmail = email.EnviarEmailVendedor(filename);
                return "Se genero el documento satisfactoriamente " + mensajeEmail;
            }
            catch (Exception e)
            {
                return "Error al crear documento" + e.Message;
            }
        }
    }
    public class RespuestaConsultar
    {
        public bool Error;
        public string Mensaje;
        public List<Vendedor> Vendedores;
    }

    public class RespuestaFiltrosVendedor
    {
        public bool Error;
        public string Mensaje;
        public List<Vendedor> vendedores;
    }
}
