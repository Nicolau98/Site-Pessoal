using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Site_Pessoal.Data;
using Site_Pessoal.Models;

namespace Site_Pessoal.Controllers
{
    public class LinguasController : Controller
    {
        private readonly Site_PessoalContext _context;

        public LinguasController(Site_PessoalContext context)
        {
            _context = context;
        }

        // GET: Linguas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Linguas.ToListAsync());
        }

        // GET: Linguas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linguas = await _context.Linguas
                .FirstOrDefaultAsync(m => m.LinguasId == id);
            if (linguas == null)
            {
                return NotFound();
            }

            return View(linguas);
        }

        // GET: Linguas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Linguas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LinguasId,Lingua,Coral,Leitura,Poral,Ioral,Escrita")] Linguas linguas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(linguas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(linguas);
        }

        // GET: Linguas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linguas = await _context.Linguas.FindAsync(id);
            if (linguas == null)
            {
                return NotFound();
            }
            return View(linguas);
        }

        // POST: Linguas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LinguasId,Lingua,Coral,Leitura,Poral,Ioral,Escrita")] Linguas linguas)
        {
            if (id != linguas.LinguasId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(linguas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LinguasExists(linguas.LinguasId))
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
            return View(linguas);
        }

        // GET: Linguas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linguas = await _context.Linguas
                .FirstOrDefaultAsync(m => m.LinguasId == id);
            if (linguas == null)
            {
                return NotFound();
            }

            return View(linguas);
        }

        // POST: Linguas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var linguas = await _context.Linguas.FindAsync(id);
            _context.Linguas.Remove(linguas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LinguasExists(int id)
        {
            return _context.Linguas.Any(e => e.LinguasId == id);
        }
    }
}
