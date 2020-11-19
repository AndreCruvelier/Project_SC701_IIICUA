using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaprisMedica.DAL.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using data = CaprisMedica.DO.Objects;

namespace CaprisMedica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        private readonly SolutionDBContext _context;

        public EquiposController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/data.Equipos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Equipos>>> GetEquipos()
        {
            return new CaprisMedica.BS.Equipos(_context).GetAll().ToList();
        }

        // GET: api/data.Equipos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.Equipos>> GetEquipos(int id)
        {
            var equipo = new CaprisMedica.BS.Equipos(_context).GetOneById(id);

            if (equipo == null)
            {
                return NotFound();
            }

            return equipo;
        }

        // PUT: api/data.Equipos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipo(int id, data.Equipos equipo)
        {
            if (id != equipo.EquipoId)
            {
                return BadRequest();
            }
            try
            {
                new CaprisMedica.BS.Equipos(_context).Update(equipo);
            }
            catch (Exception)
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

        // POST: api/data.Equipos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<data.Equipos>> PostEquipo(data.Equipos equipos)
        {
            new CaprisMedica.BS.Equipos(_context).Insert(equipos);

            return CreatedAtAction("GetPaís", new { id = equipos.EquipoId }, equipos);
        }

        // DELETE: api/data.Equipos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Equipos>> DeletePaises(int id)
        {
            var equipo = await _context.Equipos.FindAsync(id);
            if (equipo == null)
            {
                return NotFound();
            }

            new CaprisMedica.BS.Equipos(_context).Delete(equipo);

            return equipo;
        }

        private bool EquipoExists(int id)
        {
            return (new CaprisMedica.BS.Equipos(_context).GetOneById(id) != null);
        }
    }
}
