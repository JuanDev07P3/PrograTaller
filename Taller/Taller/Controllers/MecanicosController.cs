using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Taller.Models;

[ApiController]
[Route("api/[controller]")]
public class MecanicosController : ControllerBase
{
    private static List<Mecanico> mecanicos = new List<Mecanico>()
    {
        new Mecanico { Id = 1, Nombre = "Jose Morales", Especialidad = "Motor", Telefono = "5555-1234", Direccion = "Zona 1, Guatemala", AniosExperiencia = 10 },
        new Mecanico { Id = 2, Nombre = "Ana Garcia", Especialidad = "Frenos", Telefono = "5555-5678", Direccion = "Zona 5, Guatemala", AniosExperiencia = 5 },
        new Mecanico { Id = 3, Nombre = "Carlos Perez", Especialidad = "Suspension", Telefono = "5555-9012", Direccion = "Zona 10, Guatemala", AniosExperiencia = 8 },
        new Mecanico { Id = 4, Nombre = "Luisa Ramirez", Especialidad = "Electricidad", Telefono = "5555-3456", Direccion = "Zona 11, Guatemala", AniosExperiencia = 12 },
        new Mecanico { Id = 5, Nombre = "Pedro Alvarez", Especialidad = "Transmision", Telefono = "5555-7890", Direccion = "Zona 12, Guatemala", AniosExperiencia = 7 },
        new Mecanico { Id = 6, Nombre = "Sofia Castro", Especialidad = "Alineacion", Telefono = "5555-2345", Direccion = "Zona 13, Guatemala", AniosExperiencia = 9 }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Mecanico>> Get()
    {
        return Ok(mecanicos);
    }

   
    }
