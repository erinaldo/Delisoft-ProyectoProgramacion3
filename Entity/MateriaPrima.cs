namespace Entity
{
    public class MateriaPrima
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int CantidadEnvase { get; set; }
        public int Cantidad { get; set; }
        public int CantidadTotal { get; set; }
        public string FechaAlmacenamiento { get; set; }
        public double Precio { get; set; }
        public Categoria Categoria { get; set; }
        
        public void CalcularCantidadTotal()
        {
            CantidadTotal = CantidadEnvase * Cantidad;
        }
    }
}
