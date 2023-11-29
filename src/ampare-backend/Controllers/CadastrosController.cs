using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ampare_backend.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ampare_backend.Controllers
{
    [Authorize(Roles = "Administrador, Voluntario, Ong")]
    public class CadastrosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CadastrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cadastros
        public async Task<IActionResult> Index()
        {
              return View(await _context.Cadastros.ToListAsync());
        }

        // GET: Cadastros/Login
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Cadastros/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Cadastro cadastro)
        {
            if (ModelState.IsValid) { 
                var cadastroDb = await _context.Cadastros
                    .FirstOrDefaultAsync(m => m.Login == cadastro.Login);
                if (cadastroDb == null)
                {
                    ModelState.AddModelError("Login", "Login não encontrado");
                    return View(cadastro);
                }
                if (!BCrypt.Net.BCrypt.Verify(cadastro.Senha, cadastroDb.Senha))
                {
                    ModelState.AddModelError("Senha", "Senha incorreta");
                    return View(cadastro);
                }
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, cadastroDb.Login),
                    new Claim(ClaimTypes.Role, cadastroDb.Perfil.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddHours(8)
                };

                await HttpContext.SignInAsync(principal, props);

                return RedirectToAction(nameof(Index));
            }
            {
               
                return View(cadastro);
            }
        }

        // GET: Cadastros/Logout
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Cadastros/AccessDenied
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        // GET: Cadastros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cadastros == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastros
                .FirstOrDefaultAsync(m => m.IdCadastro == id);
            if (cadastro == null)
            {
                return NotFound();
            }

            return View(cadastro);
        }

      /* comentado pois usuários devem ser cadastrados como ONG ou voluntário
        GET: Cadastros/Create - 
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cadastros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCadastro,Login,Senha,Nome,Email,Telefone,Endereco,Status,Perfil")] Cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastro);
        }
        */


        // GET: Cadastros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cadastros == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastros.FindAsync(id);
            if (cadastro == null)
            {
                return NotFound();
            }
            return View(cadastro);
        }

        // POST: Cadastros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCadastro,Login,Senha,Nome,Email,Telefone,Endereco,Status,Perfil")] Cadastro cadastro)
        {
            ModelState.Remove("Senha");

            if (id != cadastro.IdCadastro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Se a senha não for alterada, mantém a senha atual
                    if (cadastro.Senha == null)
                    {
                        var cadastroDb = await _context.Cadastros
                            .FirstOrDefaultAsync(m => m.IdCadastro == id);
                        cadastro.Senha = cadastroDb.Senha;
                    }
                    else
                    {
                        cadastro.Senha = BCrypt.Net.BCrypt.HashPassword(cadastro.Senha);
                    }


                   
                    _context.Update(cadastro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroExists(cadastro.IdCadastro))
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
            return View(cadastro);
        }

        // GET: Cadastros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cadastros == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastros
                .FirstOrDefaultAsync(m => m.IdCadastro == id);
            if (cadastro == null)
            {
                return NotFound();
            }

            return View(cadastro);
        }

        // POST: Cadastros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cadastros == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Cadastros'  is null.");
            }
            var cadastro = await _context.Cadastros.FindAsync(id);
            if (cadastro != null)
            {
                _context.Cadastros.Remove(cadastro);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroExists(int id)
        {
          return _context.Cadastros.Any(e => e.IdCadastro == id);
        }
    }
}
