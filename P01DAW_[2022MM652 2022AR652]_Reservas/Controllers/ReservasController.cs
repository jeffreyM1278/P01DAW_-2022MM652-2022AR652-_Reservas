using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P01DAW__2022MM652_2022AR652__Reservas.Models;

namespace P01DAW__2022MM652_2022AR652__Reservas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private readonly ReservasContext _context;

        public ReservasController(ReservasContext context)
        {
            _context = context;
        }

        // 📌 Obtener todas las reservas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reserva>>> GetReservas()
        {
            return await _context.Reservas.ToListAsync();
        }

        // 📌 Registrar una reserva
        [HttpPost]
        public async Task<ActionResult<Reserva>> PostReserva(Reserva reserva)
        {
            _context.Reservas.Add(reserva);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetReservas), new { id = reserva.ReservaId }, reserva);
        }

        // 📌 Cancelar una reserva antes de su uso
        [HttpDelete("{id}")]
        public async Task<IActionResult> CancelarReserva(int id)
        {
            var reserva = await _context.Reservas.FindAsync(id);
            if (reserva == null || !reserva.Activa)
                return NotFound();

            reserva.Activa = false;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
