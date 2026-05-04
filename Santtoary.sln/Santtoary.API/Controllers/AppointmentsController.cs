using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Santtoary.API.DATA;
using Santtoary.Shared.Entidades;

namespace Santtoary.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AppointmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 1. GET: Trae todas las citas agendadas
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Appointments.ToListAsync());
        }

        // 2. POST: Agenda una nueva cita
        [HttpPost]
        public async Task<ActionResult> Post(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
            return Ok(appointment);
        }

        // 3. PUT: Actualiza los datos de una cita (ej. cambiar fecha o estado)
        [HttpPut]
        public async Task<ActionResult> Put(Appointment appointment)
        {
            _context.Appointments.Update(appointment);
            await _context.SaveChangesAsync();
            return Ok(appointment);
        }

        // 4. DELETE: Cancela/Borra una cita por su ID
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var appointment = await _context.Appointments.FirstOrDefaultAsync(x => x.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}