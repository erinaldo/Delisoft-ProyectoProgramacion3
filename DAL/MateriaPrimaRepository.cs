using Entity;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class MateriaPrimaRepository
    {
        List<MateriaPrima> materiasPrimas = new List<MateriaPrima>();
        private readonly OracleConnection _connection;
        public MateriaPrimaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(MateriaPrima materiaPrima)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "INSERT INTO MateriaPrima (CodigoMateriaPrima, Nombre, Cantidad, FechaAlmacenamiento, Categoria) VALUES" +
                    "(CodigoMateriaPrima.NEXTVAL, :Nombre, :Cantidad, :FechaAlmacenamiento, :Categoria)";
                Comando.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = materiaPrima.Nombre;
                Comando.Parameters.Add("Cantidad", OracleDbType.Varchar2).Value = materiaPrima.Cantidad;
                Comando.Parameters.Add("FechaAlmacenamiento", OracleDbType.Varchar2).Value = materiaPrima.FechaAlmacenamiento;
                Comando.Parameters.Add("Categoria", OracleDbType.Varchar2).Value = materiaPrima.Categoria;
                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }

        public List<MateriaPrima> Consultar()
        {
            OracleDataReader dataReader;
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM MateriaPrima";
                dataReader = Comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        MateriaPrima materiaPrima = Mapear(dataReader);
                        materiasPrimas.Add(materiaPrima);
                    }
                }
            }
            return materiasPrimas;
        }
        public MateriaPrima ConsultarCodigo(string codigo)
        {
            OracleDataReader dataReader;
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM MateriaPrima WHERE CodigoMateriaPrima = :CodigoMateriaPrima";
                Comando.Parameters.Add("CodigoMateriaPrima", OracleDbType.Varchar2).Value = codigo;
                dataReader = Comando.ExecuteReader();
                dataReader.Read();
                MateriaPrima materiaPrima = Mapear(dataReader);
                return materiaPrima;
            }
        }

        private MateriaPrima Mapear(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            MateriaPrima materiaPrima = new MateriaPrima()
            {
                Codigo = dataReader.GetString(0),
                Nombre = dataReader.GetString(1),
                Cantidad = dataReader.GetInt32(2),
                FechaAlmacenamiento = dataReader.GetString(3),
                Categoria = dataReader.GetString(4)
            };
            return materiaPrima;
        }

        public List<MateriaPrima> FiltroPorCaragoria(List<MateriaPrima> materiasPrimas, string categoria)
        {
            return materiasPrimas.Where(m => m.Categoria.Equals(categoria)).ToList();
        }
    }
}
