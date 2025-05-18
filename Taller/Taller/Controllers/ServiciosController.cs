using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Taller.Models;

[ApiController]
[Route("api/[controller]")]
public class ServiciosController : ControllerBase
{
    private static List<Servicio> servicios = new List<Servicio>()
    {
        new Servicio { Id = 1, Nombre = "Cambio de Aceite", Descripcion = "Cambio de aceite y filtro", Precio = 350, DuracionEstimadaHoras = 1 },
        new Servicio { Id = 2, Nombre = "Revision de Frenos", Descripcion = "Revision y ajuste de frenos", Precio = 500, DuracionEstimadaHoras = 2 },
        new Servicio { Id = 3, Nombre = "Alineacion y Balanceo", Descripcion = "Alineacion y balanceo de ruedas", Precio = 600, DuracionEstimadaHoras = 2 },
        new Servicio { Id = 4, Nombre = "Revision de Suspension", Descripcion = "Revision y reemplazo de amortiguadores", Precio = 800, DuracionEstimadaHoras = 3 },
        new Servicio { Id = 5, Nombre = "Diagnostico Electrico", Descripcion = "Diagnostico de fallas electricas", Precio = 400, DuracionEstimadaHoras = 2 },
        new Servicio { Id = 6, Nombre = "Reparacion de Motor", Descripcion = "Reparacion general del motor", Precio = 2500, DuracionEstimadaHoras = 12 }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Servicio>> Get()
    {
        return Ok(servicios);
    }

    
}