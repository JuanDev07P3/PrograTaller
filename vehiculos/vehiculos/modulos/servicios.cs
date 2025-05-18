namespace Taller.modulos
{
    public class servicios
    {
        public int id { get; set; }
        public required string servicio menor { get; set; }
        public required string servicio mayor { get; set; }
        public required string servicio flushing { get; set; }
        public required string servicio alineacion { get; ISet; }
        public required string servicio balanceo { get; set; }


}
}
