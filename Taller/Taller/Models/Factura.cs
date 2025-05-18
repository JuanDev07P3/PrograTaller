namespace Taller.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string ClienteNombre { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public List<string> Servicios { get; set; }
    }
}
