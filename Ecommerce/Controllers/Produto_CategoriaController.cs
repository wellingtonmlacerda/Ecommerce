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
    public class Produto_CategoriaController : Controller
    {
        private readonly Contexto _context;

        public Produto_CategoriaController(Contexto context)
        {
            _context = context;
        }

        // GET: Produto_Categoria
        public async Task<IActionResult> Index()
        {
            return View(await _context.PRODUTO_CATEGORIAS.ToListAsync());
        }

        // GET: Produto_Categoria/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto_CategoriaModel = await _context.PRODUTO_CATEGORIAS
                .FirstOrDefaultAsync(m => m.PRCA_PK_ID == id);
            if (produto_CategoriaModel == null)
            {
                return NotFound();
            }

            return View(produto_CategoriaModel);
        }

        // GET: Produto_Categoria/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produto_Categoria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PRCA_DESCRICAO,PRCA_STATUS")] Produto_CategoriaModel produto_CategoriaModel)
        {
            if (ModelState.IsValid)
            {
                produto_CategoriaModel.PRCA_DATA_CADASTRO = DateTime.Now;
                _context.Add(produto_CategoriaModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produto_CategoriaModel);
        }

        // GET: Produto_Categoria/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto_CategoriaModel = await _context.PRODUTO_CATEGORIAS.FindAsync(id);
            if (produto_CategoriaModel == null)
            {
                return NotFound();
            }
            return View(produto_CategoriaModel);
        }

        // POST: Produto_Categoria/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PRCA_DESCRICAO,PRCA_STATUS")] Produto_CategoriaModel produto_CategoriaModel)
        {
            if (id != produto_CategoriaModel.PRCA_PK_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produto_CategoriaModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Produto_CategoriaModelExists(produto_CategoriaModel.PRCA_PK_ID))
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
            return View(produto_CategoriaModel);
        }

        // GET: Produto_Categoria/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto_CategoriaModel = await _context.PRODUTO_CATEGORIAS
                .FirstOrDefaultAsync(m => m.PRCA_PK_ID == id);
            if (produto_CategoriaModel == null)
            {
                return NotFound();
            }

            return View(produto_CategoriaModel);
        }

        // POST: Produto_Categoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto_CategoriaModel = await _context.PRODUTO_CATEGORIAS.FindAsync(id);
            _context.PRODUTO_CATEGORIAS.Remove(produto_CategoriaModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Produto_CategoriaModelExists(int id)
        {
            return _context.PRODUTO_CATEGORIAS.Any(e => e.PRCA_PK_ID == id);
        }
    }
}
