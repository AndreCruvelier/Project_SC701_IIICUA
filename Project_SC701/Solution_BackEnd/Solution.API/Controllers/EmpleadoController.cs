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
    public class EmpleadoController : Controller
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
            return new Solution.BS.Empleado(_context).GetAll().ToList();//Este cambia
        }

        // GET: api/Empleado/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Empleados>> GetEmpleado(string id)
        {
            var Empleado = new Solution.BS.Empleado(_context).GetOneById(id);//Este cambia

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
        public async Task<IActionResult> PutEmpleado(string id, Empleados Empleado)
        {
            if (id != Empleado.EmpleadoCedula)
            {
                return BadRequest();
            }

            new Solution.BS.Empleado(_context).Update(Empleado);//Este cambia

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                if (!EmpleadoExists(id))
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
        public async Task<ActionResult<Empleados>> PostEmpleado(Empleados empleado)
        {
            new Solution.BS.Empleado(_context).Insert(empleado);//Este cambia

            return CreatedAtAction("GetEmpleado", new { id = empleado.EmpleadoCedula }, empleado);
        }

        // DELETE: api/Empleado/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Empleados>> DeleteEmpleado(string id)
        {
            var Empleado = new Solution.BS.Empleado(_context).GetOneById(id);//Este cambia
            if (Empleado == null)
            {
                return NotFound();
            }

            new Solution.BS.Empleado(_context).Delete(Empleado);//Este cambia

            return Empleado;
        }

        private bool EmpleadoExists(string id)
        {
            return (new Solution.BS.Empleado(_context).GetOneById(id) != null);//Este cambia
        }
    }
}
