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
    public class PagamentosComCartaoController : Controller
    {
        private readonly LojaContext _context;

        public PagamentosComCartaoController(LojaContext context)
        {
            _context = context;
        }

        // GET: PagamentosComCartao
        public async Task<IActionResult> Index()
        {
            return View(await _context.PagamentosComCartao.ToListAsync());
        }

        // GET: PagamentosComCartao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamentoComCartao = await _context.PagamentosComCartao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pagamentoComCartao == null)
            {
                return NotFound();
            }

            return View(pagamentoComCartao);
        }

        // GET: PagamentosComCartao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PagamentosComCartao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NumeroDoCartao,Bandeira,Id,NomeDoCobrado,InformacoesAdicionais")] PagamentoComCartao pagamentoComCartao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pagamentoComCartao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pagamentoComCartao);
        }

        // GET: PagamentosComCartao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamentoComCartao = await _context.PagamentosComCartao.FindAsync(id);
            if (pagamentoComCartao == null)
            {
                return NotFound();
            }
            return View(pagamentoComCartao);
        }

        // POST: PagamentosComCartao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NumeroDoCartao,Bandeira,Id,NomeDoCobrado,InformacoesAdicionais")] PagamentoComCartao pagamentoComCartao)
        {
            if (id != pagamentoComCartao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pagamentoComCartao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PagamentoComCartaoExists(pagamentoComCartao.Id))
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
            return View(pagamentoComCartao);
        }

        // GET: PagamentosComCartao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamentoComCartao = await _context.PagamentosComCartao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pagamentoComCartao == null)
            {
                return NotFound();
            }

            return View(pagamentoComCartao);
        }

        // POST: PagamentosComCartao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pagamentoComCartao = await _context.PagamentosComCartao.FindAsync(id);
            _context.PagamentosComCartao.Remove(pagamentoComCartao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PagamentoComCartaoExists(int id)
        {
            return _context.PagamentosComCartao.Any(e => e.Id == id);
        }
    }
}
