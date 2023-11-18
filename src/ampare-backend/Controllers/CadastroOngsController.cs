using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ampare_backend.Models;

namespace ampare_backend.Controllers
{
    public class CadastroOngsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CadastroOngsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CadastroOngs
        public async Task<IActionResult> Index()
        {
              return View(await _context.CadastroOngs.ToListAsync());
        }

        // GET: CadastroOngs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CadastroOngs == null)
            {
                return NotFound();
            }

            var cadastroOng = await _context.CadastroOngs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroOng == null)
            {
                return NotFound();
            }

            return View(cadastroOng);
        }

        // GET: CadastroOngs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroOngs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Endereço,Telefone,Senha")] CadastroOng cadastroOng)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastroOng);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroOng);
        }

        // GET: CadastroOngs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CadastroOngs == null)
            {
                return NotFound();
            }

            var cadastroOng = await _context.CadastroOngs.FindAsync(id);
            if (cadastroOng == null)
            {
                return NotFound();
            }
            return View(cadastroOng);
        }

        // POST: CadastroOngs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Endereço,Telefone,Senha")] CadastroOng cadastroOng)
        {
            if (id != cadastroOng.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroOng);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroOngExists(cadastroOng.Id))
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
            return View(cadastroOng);
        }

        // GET: CadastroOngs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CadastroOngs == null)
            {
                return NotFound();
            }

            var cadastroOng = await _context.CadastroOngs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroOng == null)
            {
                return NotFound();
            }

            return View(cadastroOng);
        }

        // POST: CadastroOngs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CadastroOngs == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CadastroOngs'  is null.");
            }
            var cadastroOng = await _context.CadastroOngs.FindAsync(id);
            if (cadastroOng != null)
            {
                _context.CadastroOngs.Remove(cadastroOng);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroOngExists(int id)
        {
          return _context.CadastroOngs.Any(e => e.Id == id);
        }
    }
}
