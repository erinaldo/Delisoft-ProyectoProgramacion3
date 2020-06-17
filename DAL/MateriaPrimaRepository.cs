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
                Comando.CommandText = "INSERT INTO MateriaPrima (codigomateria, nombre, precio, fechaalmacenamiento, codigocategoria, cantidadtotal) VALUES" +
                    "(codigomateriaprima.NEXTVAL, :nombre, :precio, :fechaalmacenamiento, :codigocategoria, :cantidadtotal)";
                Comando.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = materiaPrima.Nombre;
                Comando.Parameters.Add("precio", OracleDbType.Double).Value = materiaPrima.Precio;
                Comando.Parameters.Add("fechaalmacenamiento", OracleDbType.Varchar2).Value = materiaPrima.FechaAlmacenamiento;
                Comando.Parameters.Add("codigocategoria", OracleDbType.Varchar2).Value = materiaPrima.Categoria.CodigoCategoria;
                Comando.Parameters.Add("cantidadtotal", OracleDbType.Int32).Value = materiaPrima.CantidadTotal;
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
                Comando.CommandText = "SELECT mp.codigomateria, mp.nombre, mp.precio," +
                    "mp.fechaalmacenamiento, mp.codigocategoria, mp.cantidadtotal FROM materiaprima mp JOIN categoria c ON mp.codigocategoria = c.codigocategoria WHERE c.nombre = :categoria";
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
                Precio = dataReader.GetDouble(2),
                FechaAlmacenamiento = dataReader.GetString(3),
                CantidadTotal = dataReader.GetInt32(5)
            };
            return materiaPrima;
        }

        public int Modificar(string codigoMateria, int cantidad)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"UPDATE materiaprima SET cantidadtotal=:cantidad
                                        WHERE codigomateria=:codigomateria";

                command.Parameters.Add("cantidad", OracleDbType.Int32).Value = cantidad;
                command.Parameters.Add("codigomateria", OracleDbType.Varchar2).Value = codigoMateria;
                OracleTransaction transaction = _connection.BeginTransaction();
                var filas = command.ExecuteNonQuery();
                transaction.Commit();
                return filas;
            }

        }
    }
}
