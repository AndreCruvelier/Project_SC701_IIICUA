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
    public class EquipoXDepartamentoController : ControllerBase
    {
        private readonly SolutionDBContext _context;

        public EquipoXDepartamentoController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/EquipoXDepartamento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipo_X_Departamento>>> GetEquipoXDepartamento()
        {
            return await _context.Equipo_X_Departamento.ToListAsync();
        }

        // GET: api/EquipoXDepartamento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Equipo_X_Departamento>> GetEquipoXDepartamento(int id)
        {
            var EquipoXDepartamento = await _context.Equipo_X_Departamento.FindAsync(id);

            if (EquipoXDepartamento == null)
            {
                return NotFound();
            }

            return EquipoXDepartamento;
        }

        // PUT: api/EquipoXDepartamento/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipoXDepartamento(int id, Equipo_X_Departamento EquipoXDepartamento)
        {
            if (id != EquipoXDepartamento.DepartamentoId)
            {
                return BadRequest();
            }

            _context.Entry(EquipoXDepartamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipoXDepartamentoExists(id))
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

        // POST: api/EquipoXDepartamento
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Equipo_X_Departamento>> PostEquipoXDepartamento(Equipo_X_Departamento EquipoXDepartamento)
        {
            _context.Equipo_X_Departamento.Add(EquipoXDepartamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEquipoXDepartamento", new { id = EquipoXDepartamento.DepartamentoId }, EquipoXDepartamento);
        }

        // DELETE: api/EquipoXDepartamento/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Equipo_X_Departamento>> DeleteEquipoXDepartamento(int id)
        {
            var EquipoXDepartamento = await _context.Equipo_X_Departamento.FindAsync(id);
            if (EquipoXDepartamento == null)
            {
                return NotFound();
            }

            _context.Equipo_X_Departamento.Remove(EquipoXDepartamento);
            await _context.SaveChangesAsync();

            return EquipoXDepartamento;
        }

        private bool EquipoXDepartamentoExists(int id)
        {
            return _context.Equipo_X_Departamento.Any(e => e.DepartamentoId == id);
        }
    }
}
