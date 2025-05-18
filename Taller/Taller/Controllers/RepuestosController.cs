using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Taller.Models;

[ApiController]
[Route("api/[controller]")]
public class RepuestosController : ControllerBase
{
    private static List<Repuesto> repuestos = new List<Repuesto>()
    {
        new Repuesto { Id = 1, Nombre = "Filtro de Aceite", Marca = "Fram", Precio = 50, Stock = 100, Categoria = "Filtros" },
        new Repuesto { Id = 2, Nombre = "Pastillas de Freno", Marca = "Brembo", Precio = 250, Stock = 50, Categoria = "Frenos" },
        new Repuesto { Id = 3, Nombre = "Amortiguador Delantero", Marca = "Monroe", Precio = 400, Stock = 30, Categoria = "Suspension" },
        new Repuesto { Id = 4, Nombre = "Bateria para Auto", Marca = "Bosch", Precio = 800, Stock = 20, Categoria = "Baterias" },
        new Repuesto { Id = 5, Nombre = "Bujia de Encendido", Marca = "NGK", Precio = 30, Stock = 150, Categoria = "Encendido" },
        new Repuesto { Id = 6, Nombre = "Liquido de Frenos", Marca = "ATE", Precio = 120, Stock = 80, Categoria = "Frenos" }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Repuesto>> Get()
    {
        return Ok(repuestos);
    }


}