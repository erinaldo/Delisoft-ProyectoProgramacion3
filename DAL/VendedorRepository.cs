using Entity;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class VendedorRepository
    {
        List<Vendedor> vendedores = new List<Vendedor>();
        private readonly OracleConnection _connection;
        public VendedorRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(Vendedor vendedor)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "INSERT INTO Vendedor (Identificacion, Nombre) VALUES" +
                    "(:Identificacion, :Nombre)";
                Comando.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = vendedor.IdVendedor;
                Comando.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = vendedor.NombreVendedor;
                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }

        public List<Vendedor> Consultar()
        {
            OracleDataReader dataReader;
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM Vendedor";
                dataReader = Comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Vendedor vendedor = Mapear(dataReader);
                        vendedores.Add(vendedor);
                    }
                }
            }
            return vendedores;
        }

        private Vendedor Mapear(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Vendedor vendedor = new Vendedor()
            {
                IdVendedor = dataReader.GetString(0),
                NombreVendedor = dataReader.GetString(1)
            };
            return vendedor;
        }

        public List<Vendedor> FiltroPorNombre(string nombre)
        {
            return vendedores.Where(v => v.NombreVendedor.Contains(nombre)).ToList();
        }

        public List<Vendedor> FiltroPorIdentificacion(string identificacion)
        {
            return vendedores.Where(v => v.IdVendedor.Contains(identificacion)).ToList();
        }

        public int Eliminar(Vendedor vendedor)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "DELETE FROM Vendedor WHERE Identificacion = :Identificacion";
                Comando.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = vendedor.IdVendedor;
                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }

        public int Editar(Vendedor vendedor)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "UPDATE Vendedor SET Nombre = :Nombre WHERE Identificacion = :Identificaicon";
                Comando.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = vendedor.IdVendedor;
                Comando.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = vendedor.NombreVendedor;
                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }
    }
}
