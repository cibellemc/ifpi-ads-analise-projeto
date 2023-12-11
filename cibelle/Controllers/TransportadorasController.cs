using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cibelle.Context;
using cibelle.Models;

namespace cibelle.Controllers
{
    public class TransportadorasController : Controller
    {
        private readonly LojaContext _context;

        public TransportadorasController(LojaContext context)
        {
            _context = context;
        }

        // GET: Transportadoras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transportadoras.ToListAsync());
        }

        // GET: Transportadoras/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transportadora = await _context.Transportadoras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transportadora == null)
            {
                return NotFound();
            }

            return View(transportadora);
        }

        // GET: Transportadoras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transportadoras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Transportadora transportadora)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transportadora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transportadora);
        }

        // GET: Transportadoras/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transportadora = await _context.Transportadoras.FindAsync(id);
            if (transportadora == null)
            {
                return NotFound();
            }
            return View(transportadora);
        }

        // POST: Transportadoras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Nome")] Transportadora transportadora)
        {
            if (id != transportadora.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transportadora);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransportadoraExists(transportadora.Id))
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
            return View(transportadora);
        }

        // GET: Transportadoras/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transportadora = await _context.Transportadoras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transportadora == null)
            {
                return NotFound();
            }

            return View(transportadora);
        }

        // POST: Transportadoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var transportadora = await _context.Transportadoras.FindAsync(id);
            _context.Transportadoras.Remove(transportadora);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransportadoraExists(string id)
        {
            return _context.Transportadoras.Any(e => e.Id == id);
        }
    }
}
