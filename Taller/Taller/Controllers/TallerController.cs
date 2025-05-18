using Microsoft.AspNetCore.Mvc;
using Taller.Models;

[ApiController]
[Route("api/[controller]")]
public class TallerController : ControllerBase
{
    private static TallerInfo tallerInfo = new TallerInfo()
    {
        Nombre = "Taller El Rapido",
        Direccion = "12 Calle 3-45, Zona 1, Guatemala",
        Telefono = "2222-3333",
        Email = "info@tallerelrapido.com",
        HorarioAtencion = "Lunes a Viernes de 8:00 a 17:00",
        NIT = "1234567-8"
    };

    [HttpGet]
    public ActionResult<TallerInfo> Get()
    {
        return Ok(tallerInfo);
    }
}