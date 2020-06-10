using Entity;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class DetalleVentaRepository
    {
        private readonly OracleConnection _connection;
        public DetalleVentaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(DetalleVenta detalleVenta)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "INSERT INTO DetalleVenta (CodigoDetalleVenta, Cantidad, Total, CodigoProducto, CodigoVenta) VALUES" +
                    "(CodigoDetalleVenta.NEXTVAL, :Cantidad, :Total, :CodigoProducto, :CodigoVenta)";
                Comando.Parameters.Add("Cantidad", OracleDbType.Varchar2).Value = detalleVenta.Cantidad;
                Comando.Parameters.Add("Total", OracleDbType.Varchar2).Value = detalleVenta.Total;
                Comando.Parameters.Add("CodigoProducto", OracleDbType.Varchar2).Value = detalleVenta.Producto.IdProducto;
                Comando.Parameters.Add("CodigoVenta", OracleDbType.Varchar2).Value = detalleVenta.CodigoVenta;
                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }
    }
}
