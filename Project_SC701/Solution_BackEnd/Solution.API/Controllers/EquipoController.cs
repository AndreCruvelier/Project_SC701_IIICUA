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
    public class EquipoController : ControllerBase
    {
        private readonly SolutionDBContext _context;

        public EquipoController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Equipo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipos>>> GetEquipo()
        {
            return await _context.Equipos.ToListAsync();
        }

        // GET: api/Equipo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Equipos>> GetEquipo(int id)
        {
            var Equipo = await _context.Equipos.FindAsync(id);

            if (Equipo == null)
            {
                return NotFound();
            }

            return Equipo;
        }

        // PUT: api/Equipo/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipo(int id, Equipos Equipo)
        {
            if (id != Equipo.EquipoId)
            {
                return BadRequest();
            }

            _context.Entry(Equipo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipoExists(id))
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

        // POST: api/Equipo
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Equipos>> PostEquipo(Equipos Equipo)
        {
            _context.Equipos.Add(Equipo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEquipo", new { id = Equipo.EquipoId }, Equipo);
        }

        // DELETE: api/Equipo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Equipos>> DeleteEquipo(int id)
        {
            var Equipo = await _context.Equipos.FindAsync(id);
            if (Equipo == null)
            {
                return NotFound();
            }

            _context.Equipos.Remove(Equipo);
            await _context.SaveChangesAsync();

            return Equipo;
        }

        private bool EquipoExists(int id)
        {
            return _context.Equipos.Any(e => e.EquipoId == id);
        }
    }
}
