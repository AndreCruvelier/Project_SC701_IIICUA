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
    public class RoleController : ControllerBase
    {
        private readonly SolutionDBContext _context;

        public RoleController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Role
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Roles>>> GetRole()
        {
            return await _context.Roles.ToListAsync();
        }

        // GET: api/Role/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Roles>> GetRole(int id)
        {
            var Role = await _context.Roles.FindAsync(id);

            if (Role == null)
            {
                return NotFound();
            }

            return Role;
        }

        // PUT: api/Role/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRole(int id, Roles Role)
        {
            if (id != Role.RolId)
            {
                return BadRequest();
            }

            _context.Entry(Role).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoleExists(id))
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

        // POST: api/Role
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Roles>> PostRole(Roles Role)
        {
            _context.Roles.Add(Role);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRole", new { id = Role.RolId }, Role);
        }

        // DELETE: api/Role/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Roles>> DeleteRole(int id)
        {
            var Role = await _context.Roles.FindAsync(id);
            if (Role == null)
            {
                return NotFound();
            }

            _context.Roles.Remove(Role);
            await _context.SaveChangesAsync();

            return Role;
        }

        private bool RoleExists(int id)
        {
            return _context.Roles.Any(e => e.RolId == id);
        }
    }
}
