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
    public class EmpleadoController : ControllerBase
    {
        private readonly SolutionDBContext _context;

        public EmpleadoController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Empleado
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleados>>> GetEmpleado()
        {
            return await _context.Empleados.ToListAsync();
        }

        // GET: api/Empleado/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Empleados>> GetEmpleado(string id)
        {
            var Empleado = await _context.Empleados.FindAsync(id);

            if (Empleado == null)
            {
                return NotFound();
            }

            return Empleado;
        }

        // PUT: api/Empleado/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpleado(String id, Empleados Empleado)
        {
            if (id != Empleado.EmpleadoCedula)
            {
                return BadRequest();
            }

            _context.Entry(Empleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (Empleado == null)
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

        // POST: api/Empleado
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Empleados>> PostEmpleado(Empleados Empleado)
        {
            _context.Empleados.Add(Empleado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpleado", new { id = Empleado.EmpleadoCedula }, Empleado);
        }

        // DELETE: api/Empleado/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Empleados>> DeleteEmpleado(String id)
        {
            var Empleado = await _context.Empleados.FindAsync(id);
            if (Empleado == null)
            {
                return NotFound();
            }

            _context.Empleados.Remove(Empleado);
            await _context.SaveChangesAsync();

            return Empleado;
        }

        private bool EmpleadoExists(String id)
        {
            return _context.Empleados.Any(e => e.EmpleadoCedula == id);
        }
    }
}
