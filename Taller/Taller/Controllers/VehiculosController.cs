using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Taller.Models;

[ApiController]
[Route("api/[controller]")]
public class VehiculosController : ControllerBase
{
    private static List<Vehiculo> vehiculos = new List<Vehiculo>()
    {
        new Vehiculo { Id = 1, Placa = "P123ABC", Marca = "Toyota", Modelo = "Corolla", Anio = 2010, Color = "Rojo", PropietarioNombre = "Juan Perez" },
        new Vehiculo { Id = 2, Placa = "P456DEF", Marca = "Honda", Modelo = "Civic", Anio = 2015, Color = "Azul", PropietarioNombre = "Maria Lopez" },
        new Vehiculo { Id = 3, Placa = "P789GHI", Marca = "Nissan", Modelo = "Sentra", Anio = 2018, Color = "Gris", PropietarioNombre = "Carlos Gomez" },
        new Vehiculo { Id = 4, Placa = "P012JKL", Marca = "Mazda", Modelo = "3", Anio = 2020, Color = "Blanco", PropietarioNombre = "Ana Rodriguez" },
        new Vehiculo { Id = 5, Placa = "P345MNO", Marca = "Hyundai", Modelo = "Elantra", Anio = 2016, Color = "Negro", PropietarioNombre = "Luis Ramirez" },
        new Vehiculo { Id = 6, Placa = "P678PQR", Marca = "Kia", Modelo = "Rio", Anio = 2019, Color = "Plateado", PropietarioNombre = "Sofia Torres" }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Vehiculo>> Get()
    {
        return Ok(vehiculos);
    }

  
}