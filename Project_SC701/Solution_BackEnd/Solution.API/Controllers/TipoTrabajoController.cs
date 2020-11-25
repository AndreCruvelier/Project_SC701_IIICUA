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
    public class TipoTrabajoController : ControllerBase
    {
        private readonly SolutionDBContext _context;

        public TipoTrabajoController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/TipoTrabajo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoTrabajo>>> GetTipoTrabajo()
        {
            return await _context.TipoTrabajo.ToListAsync();
        }

        // GET: api/TipoTrabajo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoTrabajo>> GetTipoTrabajo(int id)
        {
            var TipoTrabajo = await _context.TipoTrabajo.FindAsync(id);

            if (TipoTrabajo == null)
            {
                return NotFound();
            }

            return TipoTrabajo;
        }

        // PUT: api/TipoTrabajo/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoTrabajo(int id, TipoTrabajo TipoTrabajo)
        {
            if (id != TipoTrabajo.TipoTrabajoId)
            {
                return BadRequest();
            }

            _context.Entry(TipoTrabajo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoTrabajoExists(id))
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

        // POST: api/TipoTrabajo
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TipoTrabajo>> PostTipoTrabajo(TipoTrabajo TipoTrabajo)
        {
            _context.TipoTrabajo.Add(TipoTrabajo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoTrabajo", new { id = TipoTrabajo.TipoTrabajoId }, TipoTrabajo);
        }

        // DELETE: api/TipoTrabajo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoTrabajo>> DeleteTipoTrabajo(int id)
        {
            var TipoTrabajo = await _context.TipoTrabajo.FindAsync(id);
            if (TipoTrabajo == null)
            {
                return NotFound();
            }

            _context.TipoTrabajo.Remove(TipoTrabajo);
            await _context.SaveChangesAsync();

            return TipoTrabajo;
        }

        private bool TipoTrabajoExists(int id)
        {
            return _context.TipoTrabajo.Any(e => e.TipoTrabajoId == id);
        }
    }
}
