using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CompuestoProductoRepository
    {
        private readonly OracleConnection _connection;
        public CompuestoProductoRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(CompuestoProducto compuesto)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "INSERT INTO compuestoproducto (codigocompuesto, cantidadunitaria, codigoproducto, codigomateria) VALUES" +
                    "(codigocompuesto.NEXTVAL, :cantidadunitaria, codigoproducto.CURRVAL, :codigomateria)";
                Comando.Parameters.Add("cantidadunitaria", OracleDbType.Varchar2).Value = compuesto.CantidadUnitaria;
                Comando.Parameters.Add("codigomateria", OracleDbType.Varchar2).Value = compuesto.MateriaPrima.Codigo;

                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }
    }
}
