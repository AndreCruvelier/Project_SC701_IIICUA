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
    public class DepartamentoXClienteController : ControllerBase
    {
        private readonly SolutionDBContext _context;

        public DepartamentoXClienteController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/DepartamentoXCliente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Departamento_X_Cliente>>> GetDepartamentoXCliente()
        {
            return await _context.Departamento_X_Cliente.ToListAsync();
        }

        // GET: api/DepartamentoXCliente/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Departamento_X_Cliente>> GetDepartamentoXCliente(int id)
        {
            var DepartamentoXCliente = await _context.Departamento_X_Cliente.FindAsync(id);

            if (DepartamentoXCliente == null)
            {
                return NotFound();
            }

            return DepartamentoXCliente;
        }

        // PUT: api/DepartamentoXCliente/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartamentoXCliente(int id, Departamento_X_Cliente DepartamentoXCliente)
        {
            if (id != DepartamentoXCliente.DepartamentoId)
            {
                return BadRequest();
            }

            _context.Entry(DepartamentoXCliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartamentoXClienteExists(id))
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

        // POST: api/DepartamentoXCliente
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Departamento_X_Cliente>> PostDepartamentoXCliente(Departamento_X_Cliente DepartamentoXCliente)
        {
            _context.Departamento_X_Cliente.Add(DepartamentoXCliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartamentoXCliente", new { id = DepartamentoXCliente.DepartamentoId }, DepartamentoXCliente);
        }

        // DELETE: api/DepartamentoXCliente/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Departamento_X_Cliente>> DeleteDepartamentoXCliente(int id)
        {
            var DepartamentoXCliente = await _context.Departamento_X_Cliente.FindAsync(id);
            if (DepartamentoXCliente == null)
            {
                return NotFound();
            }

            _context.Departamento_X_Cliente.Remove(DepartamentoXCliente);
            await _context.SaveChangesAsync();

            return DepartamentoXCliente;
        }

        private bool DepartamentoXClienteExists(int id)
        {
            return _context.Departamento_X_Cliente.Any(e => e.DepartamentoId == id);
        }
    }
}
