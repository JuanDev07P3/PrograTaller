namespace Taller.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string ClienteNombre { get; set; }
        public string VehiculoPlaca { get; set; }
        public string ServicioNombre { get; set; }
        public string Estado { get; set; }
    }
}
