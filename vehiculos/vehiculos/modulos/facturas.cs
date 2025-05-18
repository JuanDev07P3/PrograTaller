namespace Taller.modulos
{
    public class facturas
    {
        public int id { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string cliente { get; set; }
        public string vehiculo { get; set; }
        public string servicio { get; set; }
        public decimal total { get; set; }
        public string estado { get; set; }
    }
}
