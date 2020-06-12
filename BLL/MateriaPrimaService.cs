using DAL;
using Entity;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class MateriaPrimaService
    {
        private readonly ConnectionManager conexion;
        private readonly MateriaPrimaRepository materiaPrimaRepository;
        public MateriaPrimaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            materiaPrimaRepository = new MateriaPrimaRepository(conexion);
        }
        public string Guardar(MateriaPrima materiaPrima)
        {
            try
            {
                conexion.Open();

                materiaPrimaRepository.Guardar(materiaPrima);

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

        public RespuestaConsultarMateriaPrima Consultar()
        {
            RespuestaConsultarMateriaPrima respuesta = new RespuestaConsultarMateriaPrima();
            try
            {
                conexion.Open();
                respuesta.MateriasPrimas = materiaPrimaRepository.Consultar();
                conexion.Close();
                if (respuesta.MateriasPrimas.Count > 0)
                {
                    respuesta.MensajeMateriaPrima = "Se consultaron los datos";
                }
                else
                {
                    respuesta.MensajeMateriaPrima = "Los datos no existen";
                }
                respuesta.ErrorMateriaPrima = false;
                return respuesta;

            }
            catch (Exception e)
            {
                respuesta.ErrorMateriaPrima = true;
                respuesta.MensajeMateriaPrima = $"Error de la aplicación: " + e.Message;
                return respuesta;
            }
            finally
            {
                conexion.Close();
            }

        }

        public RespuestaFiltroPorCodigo ConsultarCodigo(string codigo)
        {
            RespuestaFiltroPorCodigo respuesta = new RespuestaFiltroPorCodigo();
            try
            {
                conexion.Open();
                respuesta.materiaPrima = materiaPrimaRepository.ConsultarCodigo(codigo);
                conexion.Close();
                respuesta.MensajeFiltroCodigo = "Se ha consultado satisfactoriamente";
                respuesta.ErrorFiltroCodigo = false;
                return respuesta;

            }
            catch (Exception e)
            {
                respuesta.ErrorFiltroCodigo = true;
                respuesta.MensajeFiltroCodigo = $"Error de la aplicación: " + e.Message;
                return respuesta;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
    public class RespuestaConsultarMateriaPrima
    {
        public bool ErrorMateriaPrima;
        public string MensajeMateriaPrima;
        public List<MateriaPrima> MateriasPrimas;
    }
    public class RespuestaFiltroPorCodigo
    {
        public bool ErrorFiltroCodigo;
        public string MensajeFiltroCodigo;
        public MateriaPrima materiaPrima;
    }
}
