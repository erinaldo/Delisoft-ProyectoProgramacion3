using Entity;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class VentaRepository
    {
        private readonly OracleConnection _connection;
        public VentaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(Venta venta)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "INSERT INTO Venta (CodigoVenta, ValorTotal, ValorDescuento, Subtotal, CodigoVendedor) VALUES" +
                    "(VENTACODIGO.nextval, :ValorTotal, :ValorDescuento, :Subtotal, :CodigoVendedor)";
                Comando.Parameters.Add("ValorTotal", OracleDbType.Varchar2).Value = venta.ValorTotal;
                Comando.Parameters.Add("ValorDescuento", OracleDbType.Varchar2).Value = venta.DescuentoAplicado;
                Comando.Parameters.Add("Subtotal", OracleDbType.Varchar2).Value = venta.Subtotal;
                Comando.Parameters.Add("CodigoVendedor", OracleDbType.Varchar2).Value = venta.Vendedor.IdVendedor;
                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }
    }
}
