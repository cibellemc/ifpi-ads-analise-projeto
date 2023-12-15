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
    public class TiposDePagamentoController : Controller
    {
        private readonly LojaContext _context;

        public TiposDePagamentoController(LojaContext context)
        {
            _context = context;
        }

        // GET: TiposDePagamento
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposDePagamento.ToListAsync());
        }

        // GET: TiposDePagamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDePagamento = await _context.TiposDePagamento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoDePagamento == null)
            {
                return NotFound();
            }

            return View(tipoDePagamento);
        }

        // GET: TiposDePagamento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposDePagamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeDoCobrado,InformacoesAdicionais")] TipoDePagamento tipoDePagamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoDePagamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoDePagamento);
        }

        // GET: TiposDePagamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDePagamento = await _context.TiposDePagamento.FindAsync(id);
            if (tipoDePagamento == null)
            {
                return NotFound();
            }
            return View(tipoDePagamento);
        }

        // POST: TiposDePagamento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeDoCobrado,InformacoesAdicionais")] TipoDePagamento tipoDePagamento)
        {
            if (id != tipoDePagamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoDePagamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoDePagamentoExists(tipoDePagamento.Id))
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
            return View(tipoDePagamento);
        }

        // GET: TiposDePagamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDePagamento = await _context.TiposDePagamento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoDePagamento == null)
            {
                return NotFound();
            }

            return View(tipoDePagamento);
        }

        // POST: TiposDePagamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoDePagamento = await _context.TiposDePagamento.FindAsync(id);
            _context.TiposDePagamento.Remove(tipoDePagamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoDePagamentoExists(int id)
        {
            return _context.TiposDePagamento.Any(e => e.Id == id);
        }
    }
}
