using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Santtoary.API.DATA;
using Santtoary.Shared.Entidades;

namespace Santtoary.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DesignsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DesignsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 1. GET: Ver todos los diseños del catálogo
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Designs.ToListAsync());
        }

        // 2. POST: Subir un diseño nuevo al portafolio
        [HttpPost]
        public async Task<ActionResult> Post(Design design)
        {
            _context.Designs.Add(design);
            await _context.SaveChangesAsync();
            return Ok(design);
        }

        // 3. PUT: Editar información de un diseño (ej. cambiar el precio o la descripción)
        [HttpPut]
        public async Task<ActionResult> Put(Design design)
        {
            _context.Designs.Update(design);
            await _context.SaveChangesAsync();
            return Ok(design);
        }

        // 4. DELETE: Eliminar un diseño del catálogo
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var design = await _context.Designs.FirstOrDefaultAsync(x => x.Id == id);
            if (design == null)
            {
                return NotFound();
            }

            _context.Designs.Remove(design);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}