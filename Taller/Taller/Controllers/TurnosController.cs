using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Taller.Models;

[ApiController]
[Route("api/[controller]")]
public class TurnosController : ControllerBase
{
    private static List<Turno> turnos = new List<Turno>()
    {
        new Turno { Id = 1, Fecha = DateTime.Now.AddDays(1), ClienteNombre = "Juan Perez", VehiculoPlaca = "P123ABC", ServicioNombre = "Cambio de Aceite", Estado = "Agendado" },
        new Turno { Id = 2, Fecha = DateTime.Now.AddDays(2), ClienteNombre = "Maria Lopez", VehiculoPlaca = "P456DEF", ServicioNombre = "Revision de Frenos", Estado = "Confirmado" },
        new Turno { Id = 3, Fecha = DateTime.Now.AddDays(3), ClienteNombre = "Carlos Gomez", VehiculoPlaca = "P789GHI", ServicioNombre = "Alineacion y Balanceo", Estado = "Agendado" },
        new Turno { Id = 4, Fecha = DateTime.Now.AddDays(4), ClienteNombre = "Ana Rodriguez", VehiculoPlaca = "P012JKL", ServicioNombre = "Revision de Suspension", Estado = "Confirmado" },
        new Turno { Id = 5, Fecha = DateTime.Now.AddDays(5), ClienteNombre = "Luis Ramirez", VehiculoPlaca = "P345MNO", ServicioNombre = "Diagnostico Electrico", Estado = "Agendado" },
        new Turno { Id = 6, Fecha = DateTime.Now.AddDays(6), ClienteNombre = "Sofia Torres", VehiculoPlaca = "P678PQR", ServicioNombre = "Reparacion de Motor", Estado = "Confirmado" }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Turno>> Get()
    {
        return Ok(turnos);
    }

}
