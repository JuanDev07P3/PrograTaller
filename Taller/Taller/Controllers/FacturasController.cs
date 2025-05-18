using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Taller.Models;

[ApiController]
[Route("api/[controller]")]
public class FacturasController : ControllerBase
{
    private static List<Factura> facturas = new List<Factura>()
    {
        new Factura { Id = 1, Numero = "FAC-001", Fecha = DateTime.Now.AddDays(-10), ClienteNombre = "Juan Perez", Total = 1200, Estado = "Pagada", Servicios = new List<string> { "Cambio de Aceite", "Revision de Frenos" } },
        new Factura { Id = 2, Numero = "FAC-002", Fecha = DateTime.Now.AddDays(-5), ClienteNombre = "Maria Lopez", Total = 800, Estado = "Pendiente", Servicios = new List<string> { "Alineacion y Balanceo" } },
        new Factura { Id = 3, Numero = "FAC-003", Fecha = DateTime.Now.AddDays(-2), ClienteNombre = "Carlos Gomez", Total = 2500, Estado = "Pagada", Servicios = new List<string> { "Reparacion de Motor" } },
        new Factura { Id = 4, Numero = "FAC-004", Fecha = DateTime.Now.AddDays(-1), ClienteNombre = "Ana Rodriguez", Total = 950, Estado = "Pendiente", Servicios = new List<string> { "Revision de Suspension", "Cambio de Aceite" } },
        new Factura { Id = 5, Numero = "FAC-005", Fecha = DateTime.Now.AddDays(-3), ClienteNombre = "Luis Ramirez", Total = 400, Estado = "Pagada", Servicios = new List<string> { "Diagnostico Electrico" } },
        new Factura { Id = 6, Numero = "FAC-006", Fecha = DateTime.Now.AddDays(-7), ClienteNombre = "Sofia Torres", Total = 1500, Estado = "Pendiente", Servicios = new List<string> { "Cambio de Aceite", "Revision de Frenos", "Alineacion y Balanceo" } }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Factura>> Get()
    {
        return Ok(facturas);
    }

   
}
