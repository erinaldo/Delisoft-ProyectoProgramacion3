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
        List<CompuestoProducto> compuestosProductos = new List<CompuestoProducto>();
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

        public List<CompuestoProducto> Consultar(string categoria)
        {
            OracleDataReader dataReader;
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM compuestoproducto WHERE codigoproducto = :codigoproducto";
                Comando.Parameters.Add("codigoproducto", OracleDbType.Varchar2).Value = categoria;
                dataReader = Comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        CompuestoProducto compuestoProducto = Mapear(dataReader);
                        compuestosProductos.Add(compuestoProducto);
                    }
                }
            }
            return compuestosProductos;
        }
        private CompuestoProducto Mapear(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Producto producto = new Producto();
            MateriaPrima materiaPRima = new MateriaPrima();

            producto.IdProducto = dataReader.GetString(2);
            materiaPRima.Codigo = dataReader.GetString(3);

            CompuestoProducto compuestoProducto = new CompuestoProducto()
            {
                Codigo = dataReader.GetString(0),
                CantidadUnitaria = dataReader.GetInt32(1),
                Producto = producto,
                MateriaPrima = materiaPRima
            };

            
            return compuestoProducto;
        }
    }
}
