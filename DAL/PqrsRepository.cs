using Entity;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class PqrsRepository
    {
        private readonly OracleConnection _connection;
        public PqrsRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(Pqrs pqrs)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "INSERT INTO Pqrs (CodigoPQRS, Asunto, Contenido) VALUES" +
                    "(CodigoPQRS.NEXTVAL, :Asunto, :Contenido)";
                Comando.Parameters.Add("Asunto", OracleDbType.Varchar2).Value = pqrs.Asunto;
                Comando.Parameters.Add("Contenido", OracleDbType.Varchar2).Value = pqrs.Contenido;
                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }
    }
}
