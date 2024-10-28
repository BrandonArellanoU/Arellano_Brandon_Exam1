using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Arellano_Brandon_Exam1.Data;
using Arellano_Brandon_Exam1.Models;

namespace Arellano_Brandon_Exam1.Controllers
{
    public class ArellanoBsController : Controller
    {
        private readonly Arellano_Brandon_Exam1Context _context;

        public ArellanoBsController(Arellano_Brandon_Exam1Context context)
        {
            _context = context;
        }

        // GET: ArellanoBs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ArellanoB.ToListAsync());
        }

        // GET: ArellanoBs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arellanoB = await _context.ArellanoB
                .FirstOrDefaultAsync(m => m.nombre == id);
            if (arellanoB == null)
            {
                return NotFound();
            }

            return View(arellanoB);
        }

        // GET: ArellanoBs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArellanoBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("edad,altura,nombre,esHombre,fechaNacimiento")] ArellanoB arellanoB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arellanoB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(arellanoB);
        }

        // GET: ArellanoBs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arellanoB = await _context.ArellanoB.FindAsync(id);
            if (arellanoB == null)
            {
                return NotFound();
            }
            return View(arellanoB);
        }

        // POST: ArellanoBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("edad,altura,nombre,esHombre,fechaNacimiento")] ArellanoB arellanoB)
        {
            if (id != arellanoB.nombre)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arellanoB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArellanoBExists(arellanoB.nombre))
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
            return View(arellanoB);
        }

        // GET: ArellanoBs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arellanoB = await _context.ArellanoB
                .FirstOrDefaultAsync(m => m.nombre == id);
            if (arellanoB == null)
            {
                return NotFound();
            }

            return View(arellanoB);
        }

        // POST: ArellanoBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var arellanoB = await _context.ArellanoB.FindAsync(id);
            if (arellanoB != null)
            {
                _context.ArellanoB.Remove(arellanoB);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArellanoBExists(string id)
        {
            return _context.ArellanoB.Any(e => e.nombre == id);
        }
    }
}
