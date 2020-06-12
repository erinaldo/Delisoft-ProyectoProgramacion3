using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class CategoriaRepository
    {
        List<Categoria> categorias = new List<Categoria>();
        private readonly OracleConnection _connection;
        public CategoriaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public List<Categoria> Consultar()
        {
            OracleDataReader dataReader;
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM categoria";
                dataReader = Comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Categoria categoria = Mapear(dataReader);
                        categorias.Add(categoria);
                    }
                }
            }
            return categorias;
        }

        private Categoria Mapear(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Categoria categoria = new Categoria()
            {
                CodigoCategoria = dataReader.GetString(0),
                Nombre = dataReader.GetString(1)
            };
            return categoria;
        }
    }
}
