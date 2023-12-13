using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cibelle.Context;
using cibelle.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace cibelle.Controllers
{
    public class NotasDeVendaController : Controller
    {
        private readonly LojaContext _context;

        public NotasDeVendaController(LojaContext context)
        {
            _context = context;
        }

        // GET: NotasDeVenda
        public async Task<IActionResult> Index()
        {
            // Carregar notas de venda com informações relacionadas
            var notasComRelacionamentos = await _context.NotasDeVenda
                .Include(n => n.Cliente)
                .Include(n => n.Vendedor)
                .Include(n => n.Transportadora)
                .ToListAsync();

            return View(notasComRelacionamentos);
        }


        // GET: NotasDeVenda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotasDeVenda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notaDeVenda == null)
            {
                return NotFound();
            }

            return View(notaDeVenda);
        }

        // GET: NotasDeVenda/Create
        public IActionResult Create()
        {
            ViewBag.Vendedores = new SelectList(_context.Vendedores, "Id", "Nome");
            ViewBag.Clientes = new SelectList(_context.Clientes, "Id", "Nome");
            ViewBag.Transportadoras = new SelectList(_context.Transportadoras, "Id", "Nome");
            ViewBag.Produtos = new SelectList(_context.Produtos, "Id", "Nome");

            return View();
        }

        // POST: NotasDeVenda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,Tipo,IdCliente,IdVendedor,IdTransportadora")] NotaDeVenda notaDeVenda)
        {
            if (ModelState.IsValid)
            {
                // Recupere os objetos vendedor, cliente e transportadora com base nos IDs
                notaDeVenda.Cliente = await _context.Clientes.FindAsync(notaDeVenda.IdCliente);
                notaDeVenda.Vendedor = await _context.Vendedores.FindAsync(notaDeVenda.IdVendedor);
                notaDeVenda.Transportadora = await _context.Transportadoras.FindAsync(notaDeVenda.IdTransportadora);

                // Alteração: Carregue os produtos associados aos IDs fornecidos
                var produtosSelecionados = await _context.Produtos.Where(p => notaDeVenda.IdsItems.Contains(p.Id)).ToListAsync();

                // Alteração: Associe produtos à nota de venda com quantidades
                notaDeVenda.AssociarProdutos(produtosSelecionados/*, quantidades*/);
                // Adicione a notaDeVenda ao contexto
                _context.Add(notaDeVenda);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Vendedores = new SelectList(_context.Vendedores, "Id", "Nome");
            ViewBag.Clientes = new SelectList(_context.Clientes, "Id", "Nome");
            ViewBag.Transportadoras = new SelectList(_context.Transportadoras, "Id", "Nome");

            return View(notaDeVenda);
        }


        // GET: NotasDeVenda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotasDeVenda.FindAsync(id);
            if (notaDeVenda == null)
            {
                return NotFound();
            }
            return View(notaDeVenda);
        }

        // POST: NotasDeVenda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Data,Tipo")] NotaDeVenda notaDeVenda)
        {
            if (id != notaDeVenda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notaDeVenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotaDeVendaExists(notaDeVenda.Id))
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
            return View(notaDeVenda);
        }

        // GET: NotasDeVenda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotasDeVenda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notaDeVenda == null)
            {
                return NotFound();
            }

            return View(notaDeVenda);
        }

        // POST: NotasDeVenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notaDeVenda = await _context.NotasDeVenda.FindAsync(id);
            _context.NotasDeVenda.Remove(notaDeVenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotaDeVendaExists(int id)
        {
            return _context.NotasDeVenda.Any(e => e.Id == id);
        }
    }
}
