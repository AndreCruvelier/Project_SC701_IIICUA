using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution.DAL.EF;
using data = Solution.DO.Objects;

namespace Solution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : Controller
    {
        private readonly SolutionDBContext _context;

        public PaisController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Pais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Pais>>> GetPais()
        {
            return new Solution.BS.Pais(_context).GetAll().ToList();
        }

        // GET: api/Pais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.Pais>> GetPais(int id)
        {
            var paise = new Solution.BS.Pais(_context).GetOneById(id);

            if (paise == null)
            {
                return NotFound();
            }

            return paise;
        }

        // PUT: api/Paises/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPais(int id, data.Pais paise)
        {
            if (id != paise.Id)
            {
                return BadRequest();
            }
           
            try
            {
                new Solution.BS.Pais(_context).Update(paise);
            }
            catch (Exception)
            {
                if (!PaiseExists(id))
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

        // POST: api/Paises
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<data.Pais>> PostPaise(data.Pais paise)
        {
            new Solution.BS.Pais(_context).Insert(paise);

            return CreatedAtAction("GetPais", new { id = paise.Id }, paise);
        }

        // DELETE: api/Paises/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Pais>> DeletePaise(int id)
        {
            var paise = new Solution.BS.Pais(_context).GetOneById(id);
            if (paise == null)
            {
                return NotFound();
            }

            new Solution.BS.Pais(_context).Delete(paise);

            return paise;
        }

        private bool PaiseExists(int id)
        {
            return (new Solution.BS.Pais(_context).GetOneById(id) != null);
        }
    }
}
