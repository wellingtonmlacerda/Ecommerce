using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Data;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly Contexto _context;

        public ProdutoController(Contexto context)
        {
            _context = context;
        }

        // GET: Produto
        public async Task<IActionResult> Index()
        {
            var contexto = _context.PRODUTOS.Include(p => p.Categoria);
            return View(await contexto.ToListAsync());
        }

        // GET: Produto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoModel = await _context.PRODUTOS
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.PROD_PK_ID == id);
            if (produtoModel == null)
            {
                return NotFound();
            }

            return View(produtoModel);
        }

        // GET: Produto/Create
        public IActionResult Create()
        {
            ViewData["PROD_FK_CATE"] = new SelectList(_context.PRODUTO_CATEGORIAS, "PRCA_PK_ID", "PRCA_DESCRICAO");
            return View();
        }

        // POST: Produto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PROD_DESCRICAO,PROD_VALIDADE,PROD_VALOR,PROD_VOLUME,PROD_QUANTIDADE_ESTOQUE,PROD_FK_CATE,PROD_STATUS")] ProdutoModel produtoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PROD_FK_CATE"] = new SelectList(_context.PRODUTO_CATEGORIAS, "PRCA_PK_ID", "PRCA_DESCRICAO", produtoModel.PROD_FK_CATE);
            return View(produtoModel);
        }

        // GET: Produto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoModel = await _context.PRODUTOS.FindAsync(id);
            if (produtoModel == null)
            {
                return NotFound();
            }
            ViewData["PROD_FK_CATE"] = new SelectList(_context.PRODUTO_CATEGORIAS, "PRCA_PK_ID", "PRCA_DESCRICAO", produtoModel.PROD_FK_CATE);
            return View(produtoModel);
        }

        // POST: Produto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PROD_DESCRICAO,PROD_VALIDADE,PROD_VALOR,PROD_VOLUME,PROD_QUANTIDADE_ESTOQUE,PROD_FK_CATE,PROD_STATUS")] ProdutoModel produtoModel)
        {
            if (id != produtoModel.PROD_PK_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoModelExists(produtoModel.PROD_PK_ID))
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
            ViewData["PROD_FK_CATE"] = new SelectList(_context.PRODUTO_CATEGORIAS, "PRCA_PK_ID", "PRCA_DESCRICAO", produtoModel.PROD_FK_CATE);
            return View(produtoModel);
        }

        // GET: Produto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoModel = await _context.PRODUTOS
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.PROD_PK_ID == id);
            if (produtoModel == null)
            {
                return NotFound();
            }

            return View(produtoModel);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produtoModel = await _context.PRODUTOS.FindAsync(id);
            _context.PRODUTOS.Remove(produtoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoModelExists(int id)
        {
            return _context.PRODUTOS.Any(e => e.PROD_PK_ID == id);
        }
    }
}
