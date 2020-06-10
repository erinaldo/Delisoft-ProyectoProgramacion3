using Entity;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace DAL
{
    public class UsuarioRepository
    {
        private readonly OracleConnection _connection;
        List<Usuario> usuarios = new List<Usuario>();
        public UsuarioRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(Usuario usuario)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "INSERT INTO Usuario (NombreUsuario, Contraseña, Identificacion, Email) VALUES" +
                    "(:NombreUsuario, :Contraseña, :Identificacion, :Email)";
                Comando.Parameters.Add("NombreUsuario", OracleDbType.Varchar2).Value = usuario.NombreUsuario;
                Comando.Parameters.Add("Contraseña", OracleDbType.Varchar2).Value = usuario.Contraseña;
                Comando.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = usuario.Identificacion;
                Comando.Parameters.Add("Email", OracleDbType.Varchar2).Value = usuario.Email;
                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }
        public Usuario ConsultarCredenciales(string nombreUsuario, string contraseña)
        {
            OracleDataReader dataReader;
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM Usuario WHERE NombreUsuario = :NombreUsuario AND Contraseña = :Contraseña";
                Comando.Parameters.Add("NombreUsuario", OracleDbType.Varchar2).Value = nombreUsuario;
                Comando.Parameters.Add("contraseña", OracleDbType.Varchar2).Value = contraseña;
                dataReader = Comando.ExecuteReader();
                dataReader.Read();
                Usuario usuario = Mapear(dataReader);
                return usuario;
            }
        }
        private Usuario Mapear(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Usuario usuario = new Usuario()
            {
                NombreUsuario = dataReader.GetString(0),
                Contraseña = dataReader.GetString(1),
                Identificacion = dataReader.GetString(2),
                Email = dataReader.GetString(3)
            };
            return usuario;
        }
        public Usuario ConsultarIdentificacion(string identificacion)
        {
            OracleDataReader dataReader;
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM Usuario WHERE Identificacion = :Identificacion";
                Comando.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = identificacion;
                dataReader = Comando.ExecuteReader();
                dataReader.Read();
                Usuario usuario = Mapear(dataReader);
                return usuario;
            }
        }
        public Usuario ConsultarEmail(string email)
        {
            OracleDataReader dataReader;
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM Usuario WHERE Email = :Email";
                Comando.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;
                dataReader = Comando.ExecuteReader();
                dataReader.Read();
                Usuario usuario = Mapear(dataReader);
                return usuario;
            }
        }
        public int Eliminar(Usuario usuario)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "DELETE FROM Usuario WHERE Identificacion = :Identificacion";
                Comando.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = usuario.Identificacion;
                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }

        public int CambiarContraseña(Usuario usuario)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "UPDATE Usuario SET Contraseña = :Contraseña WHERE NombreUsuario = :NombreUsuario";
                Comando.Parameters.Add("Contraseña", OracleDbType.Varchar2).Value = usuario.Contraseña;
                Comando.Parameters.Add("NombreUsuario", OracleDbType.Varchar2).Value = usuario.NombreUsuario;
                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }
    }
}
