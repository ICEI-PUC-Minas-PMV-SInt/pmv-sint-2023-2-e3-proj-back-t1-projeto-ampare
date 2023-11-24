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
    public class VoluntariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VoluntariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Voluntarios
        public async Task<IActionResult> Index()
        {
              return View(await _context.CadastroVoluntario.ToListAsync());
        }

        // GET: Voluntarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CadastroVoluntario == null)
            {
                return NotFound();
            }

            var cadastroVoluntario = await _context.CadastroVoluntario
                .FirstOrDefaultAsync(m => m.IdCadastro == id);
            if (cadastroVoluntario == null)
            {
                return NotFound();
            }

            return View(cadastroVoluntario);
        }

        // GET: Voluntarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Voluntarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idade,IdCadastro,Login,Senha,Nome,Email,Telefone,Endereco,Status,Perfil")] CadastroVoluntario cadastroVoluntario)
        {
            if (ModelState.IsValid)
            {
                cadastroVoluntario.Senha = BCrypt.Net.BCrypt.HashPassword(cadastroVoluntario.Senha);
                cadastroVoluntario.Perfil = "Voluntario";
                _context.Add(cadastroVoluntario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroVoluntario);
        }

        // GET: Voluntarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CadastroVoluntario == null)
            {
                return NotFound();
            }

            var cadastroVoluntario = await _context.CadastroVoluntario.FindAsync(id);
            if (cadastroVoluntario == null)
            {
                return NotFound();
            }
            return View(cadastroVoluntario);
        }

        // POST: Voluntarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idade,IdCadastro,Login,Senha,Nome,Email,Telefone,Endereco,Status,Perfil")] CadastroVoluntario cadastroVoluntario)
        {
            if (id != cadastroVoluntario.IdCadastro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Se a senha não for alterada, mantém a senha atual
                    if (cadastroVoluntario.Senha == null)
                    {
                        cadastroVoluntario.Senha = _context.CadastroOng.AsNoTracking().FirstOrDefault(x => x.IdCadastro == cadastroVoluntario.IdCadastro).Senha;
                    }
                    else
                    {
                        cadastroVoluntario.Senha = BCrypt.Net.BCrypt.HashPassword(cadastroVoluntario.Senha);
                    }

                    _context.Update(cadastroVoluntario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroVoluntarioExists(cadastroVoluntario.IdCadastro))
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
            return View(cadastroVoluntario);
        }

        // GET: Voluntarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CadastroVoluntario == null)
            {
                return NotFound();
            }

            var cadastroVoluntario = await _context.CadastroVoluntario
                .FirstOrDefaultAsync(m => m.IdCadastro == id);
            if (cadastroVoluntario == null)
            {
                return NotFound();
            }

            return View(cadastroVoluntario);
        }

        // POST: Voluntarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CadastroVoluntario == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CadastroVoluntario'  is null.");
            }
            var cadastroVoluntario = await _context.CadastroVoluntario.FindAsync(id);
            if (cadastroVoluntario != null)
            {
                _context.CadastroVoluntario.Remove(cadastroVoluntario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroVoluntarioExists(int id)
        {
          return _context.CadastroVoluntario.Any(e => e.IdCadastro == id);
        }
    }
}
