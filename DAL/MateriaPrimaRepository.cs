using Entity;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Data;
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
                Comando.CommandText = "INSERT INTO MateriaPrima (codigomateria, nombre, cantidadenvase, cantidad, precio, fechaalmacenamiento, codigocategoria) VALUES" +
                    "(codigomateriaprima.NEXTVAL, :nombre, :cantidadenvase, :cantidad, :precio, :fechaalmacenamiento, :codigocategoria)";
                Comando.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = materiaPrima.Nombre;
                Comando.Parameters.Add("cantidadenvase", OracleDbType.Varchar2).Value = materiaPrima.CantidadEnvase;
                Comando.Parameters.Add("Cantidad", OracleDbType.Varchar2).Value = materiaPrima.Cantidad;
                Comando.Parameters.Add("precio", OracleDbType.Varchar2).Value = materiaPrima.Precio;
                Comando.Parameters.Add("fechaalmacenamiento", OracleDbType.Varchar2).Value = materiaPrima.FechaAlmacenamiento;
                Comando.Parameters.Add("codigocategoria", OracleDbType.Varchar2).Value = materiaPrima.Categoria.CodigoCategoria;
                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }

        public List<MateriaPrima> Consultar()
        {
            OracleDataReader dataReader;
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM materiaprima";
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

        public List<MateriaPrima> ConsultarCategoria(string categoria)
        {
            OracleDataReader dataReader;
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "SELECT mp.codigomateria, mp.nombre, mp.cantidadenvase, mp.cantidad," +
                    "mp.precio, mp.fechaalmacenamiento FROM materiaprima mp JOIN categoria c ON mp.codigocategoria = c.codigocategoria WHERE c.nombre = :categoria";
                Comando.Parameters.Add("categoria", OracleDbType.Varchar2).Value = categoria;
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

        private MateriaPrima Mapear(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            MateriaPrima materiaPrima = new MateriaPrima()
            {
                Codigo = dataReader.GetString(0),
                Nombre = dataReader.GetString(1),
                CantidadEnvase = dataReader.GetInt32(2),
                Cantidad = dataReader.GetInt32(3),
                Precio = dataReader.GetDouble(4),
                FechaAlmacenamiento = dataReader.GetString(5)
            };
            return materiaPrima;
        }

    }
}
