using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solution.DAL.EF;
using Solution.DO.Objects;

namespace Solution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudeController : ControllerBase
    {
        private readonly SolutionDBContext _context;

        public SolicitudeController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Solicitude
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Solicitudes>>> GetSolicitude()
        {
            return await _context.Solicitudes.ToListAsync();
        }

        // GET: api/Solicitude/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Solicitudes>> GetSolicitude(int id)
        {
            var Solicitude = await _context.Solicitudes.FindAsync(id);

            if (Solicitude == null)
            {
                return NotFound();
            }

            return Solicitude;
        }

        // PUT: api/Solicitude/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSolicitude(int id, Solicitudes Solicitude)
        {
            if (id != Solicitude.SolicitudId)
            {
                return BadRequest();
            }

            _context.Entry(Solicitude).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SolicitudeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Solicitude
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Solicitudes>> PostSolicitude(Solicitudes Solicitude)
        {
            _context.Solicitudes.Add(Solicitude);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSolicitude", new { id = Solicitude.SolicitudId }, Solicitude);
        }

        // DELETE: api/Solicitude/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Solicitudes>> DeleteSolicitude(int id)
        {
            var Solicitude = await _context.Solicitudes.FindAsync(id);
            if (Solicitude == null)
            {
                return NotFound();
            }

            _context.Solicitudes.Remove(Solicitude);
            await _context.SaveChangesAsync();

            return Solicitude;
        }

        private bool SolicitudeExists(int id)
        {
            return _context.Solicitudes.Any(e => e.SolicitudId == id);
        }
    }
}
