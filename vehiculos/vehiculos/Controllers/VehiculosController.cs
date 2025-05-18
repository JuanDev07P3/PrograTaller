using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Taller.Controllers.Taller.Controllers;
using Taller.modulos;

namespace Taller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculosController : ControllerBase
    {
        private readonly TallerContext _context;

        // Constructor principal actualizado para IDE0290
        public VehiculosController(TallerContext context) => _context = context;

        // GET: api/vehiculos
        [HttpGet]
        public IActionResult GetVehiculos()
        {
            var vehiculos = _context.Vehiculos.ToList();
            return Ok(vehiculos);
        }

        // GET: api/vehiculos/{id}
        [HttpGet("{id}")]
        public IActionResult GetVehiculo(int id)
        {
            var vehiculo = _context.Vehiculos.Find(id);
            if (vehiculo == null)
            {
                return NotFound();
            }
            return Ok(vehiculo);
        }

    using Taller.modulos; // Asegúrate de que esta directiva using esté presente y correcta

    namespace Taller.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class VehiculosController : ControllerBase
        {
            private readonly TallerContext _context;

            // Constructor principal actualizado para IDE0290  
            public VehiculosController(TallerContext context) => _context = context;

            // GET: api/vehiculos  
            [HttpGet]
            public IActionResult GetVehiculos()
            {
                var vehiculos = _context.Vehiculos.ToList();
                return Ok(vehiculos);
            }

            // GET: api/vehiculos/{id}  
            [HttpGet("{id}")]
            public IActionResult GetVehiculo(int id)
            {
                var vehiculo = _context.Vehiculos.Find(id);
                if (vehiculo == null)
                {
                    return NotFound();
                }
                return Ok(vehiculo);
            }

            // POST: api/vehiculos  
            [HttpPost]
            public IActionResult CreateVehiculo([FromBody] Vehiculo vehiculo)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _context.Vehiculos.Add(vehiculo);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetVehiculo), new { id = vehiculo.Id }, vehiculo);
            }

            // PUT: api/vehiculos/{id}  
            [HttpPut("{id}")]
            public IActionResult UpdateVehiculo(int id, [FromBody] Vehiculo vehiculo)
            {
                if (id != vehiculo.Id || !ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _context.Entry(vehiculo).State = EntityState.Modified;
                _context.SaveChanges();
                return NoContent();
            }

            // DELETE: api/vehiculos/{id}  
            [HttpDelete("{id}")]
            public IActionResult DeleteVehiculo(int id)
            {
                var vehiculo = _context.Vehiculos.Find(id);
                if (vehiculo == null)
                {
                    return NotFound();
                }
                _context.Vehiculos.Remove(vehiculo);
                _context.SaveChanges();
                return NoContent();
            }
        }

        // Asegúrate de que la clase Vehiculo esté definida en el espacio de nombres correcto
        public class Vehiculo
        {
            public int Id { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Año { get; set; }
        }

        // Cambiar la clase TallerContext a public para resolver CS0051
        public class TallerContext : DbContext
        {
            public DbSet<Vehiculo> Vehiculos { get; set; }
        }
    }

    // PUT: api/vehiculos/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateVehiculo(int id, [FromBody] Vehiculo vehiculo)
    {
        if (id != vehiculo.Id || !ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        _context.Entry(vehiculo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        _context.SaveChanges();
        return NoContent();
    }

    // DELETE: api/vehiculos/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteVehiculo(int id)
    {
        var vehiculo = _context.Vehiculos.Find(id);
        if (vehiculo == null)
        {
            return NotFound();
        }
        _context.Vehiculos.Remove(vehiculo);
        _context.SaveChanges();
        return NoContent();
    }
}
// Cambiar la clase TallerContext a public para resolver CS0051
public class TallerContext : DbContext
{
    public DbSet<Vehiculo> Vehiculos { get; set; }
}
}
}
