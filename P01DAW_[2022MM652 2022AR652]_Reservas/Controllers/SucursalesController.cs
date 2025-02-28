using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P01DAW__2022MM652_2022AR652__Reservas.Models;

namespace P01DAW__2022MM652_2022AR652__Reservas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucursalesController : ControllerBase
    {
        private readonly ReservasContext _context;

        public SucursalesController(ReservasContext context)
        {
            _context = context;
        }

        //  Obtener todas las sucursales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sucursal>>> GetSucursales()
        {
            return await _context.Sucursales.ToListAsync();
        }

        //  Obtener una sucursal por ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Sucursal>> GetSucursal(int id)
        {
            var sucursal = await _context.Sucursales.FindAsync(id);
            if (sucursal == null)
                return NotFound();
            return sucursal;
        }

        //  Registrar una nueva sucursal
        [HttpPost]
        public async Task<ActionResult<Sucursal>> PostSucursal(Sucursal sucursal)
        {
            _context.Sucursales.Add(sucursal);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSucursal), new { id = sucursal.SucursalId }, sucursal);
        }

        //  Actualizar información de una sucursal
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSucursal(int id, Sucursal sucursal)
        {
            if (id != sucursal.SucursalId)
                return BadRequest();

            _context.Entry(sucursal).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //  Eliminar una sucursal
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSucursal(int id)
        {
            var sucursal = await _context.Sucursales.FindAsync(id);
            if (sucursal == null)
                return NotFound();

            _context.Sucursales.Remove(sucursal);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
