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
    public class DepartamentoController : ControllerBase
    {
        private readonly SolutionDBContext _context;

        public DepartamentoController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Departamento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Departamentos>>> GetDepartamento()
        {
            return await _context.Departamentos.ToListAsync();
        }

        // GET: api/Departamento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Departamentos>> GetDepartamento(int id)
        {
            var Departamento = await _context.Departamentos.FindAsync(id);

            if (Departamento == null)
            {
                return NotFound();
            }

            return Departamento;
        }

        // PUT: api/Departamento/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartamento(int id, Departamentos Departamento)
        {
            if (id != Departamento.DepartamentoId)
            {
                return BadRequest();
            }

            _context.Entry(Departamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartamentoExists(id))
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

        // POST: api/Departamento
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Departamentos>> PostDepartamento(Departamentos Departamento)
        {
            _context.Departamentos.Add(Departamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartamento", new { id = Departamento.DepartamentoId }, Departamento);
        }

        // DELETE: api/Departamento/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Departamentos>> DeleteDepartamento(int id)
        {
            var Departamento = await _context.Departamentos.FindAsync(id);
            if (Departamento == null)
            {
                return NotFound();
            }

            _context.Departamentos.Remove(Departamento);
            await _context.SaveChangesAsync();

            return Departamento;
        }

        private bool DepartamentoExists(int id)
        {
            return _context.Departamentos.Any(e => e.DepartamentoId == id);
        }
    }
}
