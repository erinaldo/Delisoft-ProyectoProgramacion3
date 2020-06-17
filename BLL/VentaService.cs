using DAL;
using Entity;
using Infraestructura;
using System;
using System.Collections.Generic;

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

        public string GuardarVentas(List<Venta> vendedores, string filename)
        {
            DocumentoPdf documentoPdf = new DocumentoPdf();
            try
            {
                documentoPdf.GuardarVentas(vendedores, filename);
                return "Se genero el documento satisfactoriamente ";
            }
            catch (Exception  e)
            {
                return "Error al crear documento" + e.Message;
            }
        }
    }
}
