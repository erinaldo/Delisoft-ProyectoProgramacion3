using Entity;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace DAL
{
    public class ProductoRepository
    {
        List<Producto> productos = new List<Producto>();
        private readonly OracleConnection _connection;
        public ProductoRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(Producto producto)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "INSERT INTO producto (CodigoProducto, NombreProducto, PrecioProducto) VALUES" +
                    "(:CodigoProducto, :NombreProducto, :PrecioProducto)";
                Comando.Parameters.Add("CodigoProducto", OracleDbType.Varchar2).Value = producto.IdProducto;
                Comando.Parameters.Add("NombreProducto", OracleDbType.Varchar2).Value = producto.NombreProducto;
                Comando.Parameters.Add("PrecioProducto", OracleDbType.Varchar2).Value = producto.PrecioProducto;

                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }

        public List<Producto> Consultar()
        {
            OracleDataReader dataReader;
            using(var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM Producto";
                dataReader = Comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = Mapear(dataReader);
                        productos.Add(producto);
                    }
                }
            }
            return productos;
        }

        private Producto Mapear(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Producto producto = new Producto()
            {
                IdProducto = dataReader.GetString(0),
                NombreProducto = dataReader.GetString(1),
                PrecioProducto = dataReader.GetDouble(2)
            };
            return producto;
        }

        public Producto FiltrarCodigo(string codigo)
        {
            return productos.Find(p => p.IdProducto.Equals(codigo));
        }
    }
}
