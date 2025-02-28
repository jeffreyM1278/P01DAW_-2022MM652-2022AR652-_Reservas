using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P01DAW__2022MM652_2022AR652__Reservas.Models;

namespace P01DAW__2022MM652_2022AR652__Reservas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspaciosParqueoController : ControllerBase
    {
        private readonly ReservasContext _context;

        public EspaciosParqueoController(ReservasContext context)
        {
            _context = context;
        }

        //  Obtener todos los espacios de parqueo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EspacioParqueo>>> GetEspacios()
        {
            return await _context.EspaciosParqueo.ToListAsync();
        }

        //  Obtener un espacio por ID
        [HttpGet("{id}")]
        public async Task<ActionResult<EspacioParqueo>> GetEspacio(int id)
        {
            var espacio = await _context.EspaciosParqueo.FindAsync(id);
            if (espacio == null)
                return NotFound();
            return espacio;
        }

        //  Registrar un nuevo espacio de parqueo
        [HttpPost]
        public async Task<ActionResult<EspacioParqueo>> PostEspacio(EspacioParqueo espacio)
        {
            _context.EspaciosParqueo.Add(espacio);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEspacio), new { id = espacio.EspacioId }, espacio);
        }

        //  Actualizar un espacio de parqueo
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEspacio(int id, EspacioParqueo espacio)
        {
            if (id != espacio.EspacioId)
                return BadRequest();

            _context.Entry(espacio).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //  Eliminar un espacio de parqueo
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEspacio(int id)
        {
            var espacio = await _context.EspaciosParqueo.FindAsync(id);
            if (espacio == null)
                return NotFound();

            _context.EspaciosParqueo.Remove(espacio);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
