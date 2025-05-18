using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Taller.Models;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private static List<Cliente> clientes = new List<Cliente>()
    {
        new Cliente { Id = 1, Nombre = "Juan Perez", Telefono = "5555-4321", Direccion = "Zona 2, Guatemala", Email = "juan.perez@example.com", DPI = "1234567890123" },
        new Cliente { Id = 2, Nombre = "Maria Lopez", Telefono = "5555-8765", Direccion = "Zona 6, Guatemala", Email = "maria.lopez@example.com", DPI = "9876543210987" },
        new Cliente { Id = 3, Nombre = "Carlos Gomez", Telefono = "5555-2109", Direccion = "Zona 9, Guatemala", Email = "carlos.gomez@example.com", DPI = "4567890123456" },
        new Cliente { Id = 4, Nombre = "Ana Rodriguez", Telefono = "5555-6543", Direccion = "Zona 14, Guatemala", Email = "ana.rodriguez@example.com", DPI = "6543210987654" },
        new Cliente { Id = 5, Nombre = "Luis Ramirez", Telefono = "5555-0987", Direccion = "Zona 15, Guatemala", Email = "luis.ramirez@example.com", DPI = "3210987654321" },
        new Cliente { Id = 6, Nombre = "Sofia Torres", Telefono = "5555-4321", Direccion = "Zona 16, Guatemala", Email = "sofia.torres@example.com", DPI = "7890123456789" }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Cliente>> Get()
    {
        return Ok(clientes);
    }

    
}