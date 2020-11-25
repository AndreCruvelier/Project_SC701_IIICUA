using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Solution.DAL.EF;
using Solution.DO.Objects;

namespace Solution.API.Controllers
{
    public class Transformers1Controller : Controller
    {
        private readonly SolutionDBContext _context;

        public Transformers1Controller(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: Transformers1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transformers.ToListAsync());
        }

        // GET: Transformers1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transformers = await _context.Transformers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transformers == null)
            {
                return NotFound();
            }

            return View(transformers);
        }

        // GET: Transformers1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transformers1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,SobreNombre,Fallecio,Raza,Sociedad,FechaNacimiento,Edad,Especialidad")] Transformers transformers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transformers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transformers);
        }

        // GET: Transformers1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transformers = await _context.Transformers.FindAsync(id);
            if (transformers == null)
            {
                return NotFound();
            }
            return View(transformers);
        }

        // POST: Transformers1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,SobreNombre,Fallecio,Raza,Sociedad,FechaNacimiento,Edad,Especialidad")] Transformers transformers)
        {
            if (id != transformers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transformers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransformersExists(transformers.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(transformers);
        }

        // GET: Transformers1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transformers = await _context.Transformers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transformers == null)
            {
                return NotFound();
            }

            return View(transformers);
        }

        // POST: Transformers1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transformers = await _context.Transformers.FindAsync(id);
            _context.Transformers.Remove(transformers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransformersExists(int id)
        {
            return _context.Transformers.Any(e => e.Id == id);
        }
    }
}
