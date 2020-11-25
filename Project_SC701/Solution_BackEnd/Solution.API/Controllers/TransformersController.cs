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
    public class TransformersController : ControllerBase
    {
        private readonly SolutionDBContext _context;

        public TransformersController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Transformers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transformers>>> GetTransformers()
        {
            return await _context.Transformers.ToListAsync();
        }

        // GET: api/Transformers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transformers>> GetTransformers(int id)
        {
            var transformers = await _context.Transformers.FindAsync(id);

            if (transformers == null)
            {
                return NotFound();
            }

            return transformers;
        }

        // PUT: api/Transformers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransformers(int id, Transformers transformers)
        {
            if (id != transformers.Id)
            {
                return BadRequest();
            }

            _context.Entry(transformers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransformersExists(id))
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

        // POST: api/Transformers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Transformers>> PostTransformers(Transformers transformers)
        {
            _context.Transformers.Add(transformers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransformers", new { id = transformers.Id }, transformers);
        }

        // DELETE: api/Transformers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Transformers>> DeleteTransformers(int id)
        {
            var transformers = await _context.Transformers.FindAsync(id);
            if (transformers == null)
            {
                return NotFound();
            }

            _context.Transformers.Remove(transformers);
            await _context.SaveChangesAsync();

            return transformers;
        }

        private bool TransformersExists(int id)
        {
            return _context.Transformers.Any(e => e.Id == id);
        }
    }
}
