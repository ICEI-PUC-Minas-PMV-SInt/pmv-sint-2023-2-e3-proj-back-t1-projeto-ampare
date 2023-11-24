using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ampare_backend.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ampare_backend.Controllers
{
    public class OngsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OngsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ongs
        public async Task<IActionResult> Index()
        {
              return View(await _context.CadastroOng.ToListAsync());
        }

        // GET: Ongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CadastroOng == null)
            {
                return NotFound();
            }

            var cadastroOng = await _context.CadastroOng
                .FirstOrDefaultAsync(m => m.IdCadastro == id);
            if (cadastroOng == null)
            {
                return NotFound();
            }

            return View(cadastroOng);
        }

        // GET: Ongs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCadastro,Login,Senha,Nome,Email,Telefone,Endereco,Status,Perfil")] CadastroOng cadastroOng)
        {
            if (ModelState.IsValid)
            {
                cadastroOng.Senha = BCrypt.Net.BCrypt.HashPassword(cadastroOng.Senha);
                cadastroOng.Perfil = "Ong";
                _context.Add(cadastroOng);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroOng);
        }

        // GET: Ongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CadastroOng == null)
            {
                return NotFound();
            }

            var cadastroOng = await _context.CadastroOng.FindAsync(id);
            if (cadastroOng == null)
            {
                return NotFound();
            }
            return View(cadastroOng);
        }

        // POST: Ongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCadastro,Login,Senha,Nome,Email,Telefone,Endereco,Status,Perfil")] CadastroOng cadastroOng)
        {
            ModelState.Remove("Senha");

            if (id != cadastroOng.IdCadastro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Se a senha não for alterada, mantém a senha atual
                     if (cadastroOng.Senha == null)
                    {
                            cadastroOng.Senha = _context.CadastroOng.AsNoTracking().FirstOrDefault(x => x.IdCadastro == cadastroOng.IdCadastro).Senha;
                        }
                        else
                    {
                            cadastroOng.Senha = BCrypt.Net.BCrypt.HashPassword(cadastroOng.Senha);
                        }

                    _context.Update(cadastroOng);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroOngExists(cadastroOng.IdCadastro))
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

        // GET: Ongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CadastroOng == null)
            {
                return NotFound();
            }

            var cadastroOng = await _context.CadastroOng
                .FirstOrDefaultAsync(m => m.IdCadastro == id);
            if (cadastroOng == null)
            {
                return NotFound();
            }

            return View(cadastroOng);
        }

        // POST: Ongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CadastroOng == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CadastroOng'  is null.");
            }
            var cadastroOng = await _context.CadastroOng.FindAsync(id);
            if (cadastroOng != null)
            {
                _context.CadastroOng.Remove(cadastroOng);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroOngExists(int id)
        {
          return _context.CadastroOng.Any(e => e.IdCadastro == id);
        }
    }
}
