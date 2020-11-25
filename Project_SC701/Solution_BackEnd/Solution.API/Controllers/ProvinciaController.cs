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
    public class ProvinciaController : ControllerBase
    {
        private readonly SolutionDBContext _context;

        public ProvinciaController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Provincia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provincias>>> GetProvincia()
        {
            return await _context.Provincias.ToListAsync();
        }

        // GET: api/Provincia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Provincias>> GetProvincia(int id)
        {
            var Provincia = await _context.Provincias.FindAsync(id);

            if (Provincia == null)
            {
                return NotFound();
            }

            return Provincia;
        }

        // PUT: api/Provincia/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProvincia(int id, Provincias Provincia)
        {
            if (id != Provincia.ProvinciaId)
            {
                return BadRequest();
            }

            _context.Entry(Provincia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinciaExists(id))
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

        // POST: api/Provincia
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Provincias>> PostProvincia(Provincias Provincia)
        {
            _context.Provincias.Add(Provincia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProvincia", new { id = Provincia.ProvinciaId }, Provincia);
        }

        // DELETE: api/Provincia/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Provincias>> DeleteProvincia(int id)
        {
            var Provincia = await _context.Provincias.FindAsync(id);
            if (Provincia == null)
            {
                return NotFound();
            }

            _context.Provincias.Remove(Provincia);
            await _context.SaveChangesAsync();

            return Provincia;
        }

        private bool ProvinciaExists(int id)
        {
            return _context.Provincias.Any(e => e.ProvinciaId == id);
        }
    }
}
