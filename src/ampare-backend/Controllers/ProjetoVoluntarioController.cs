using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ampare_backend.Models;
using Microsoft.AspNetCore.Authorization;

namespace ampare_backend.Controllers
{
	[Authorize]
	public class ProjetoVoluntarioController : Controller
	{
		private readonly ApplicationDbContext _context;

		public ProjetoVoluntarioController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: ProjetoVoluntario
		public async Task<IActionResult> Index()
		{
			var applicationDbContext = _context.ProjetoVoluntarios.Include(p => p.Projeto).Include(p => p.Voluntario);
			return View(await applicationDbContext.ToListAsync());
		}

		// GET: ProjetoVoluntario/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null || _context.ProjetoVoluntarios == null)
			{
				return NotFound();
			}

			var projetoVoluntario = await _context.ProjetoVoluntarios
				.Include(p => p.Projeto)
				.Include(p => p.Voluntario)
				.FirstOrDefaultAsync(m => m.ProjetoVoluntarioId == id);
			if (projetoVoluntario == null)
			{
				return NotFound();
			}

			return View(projetoVoluntario);
		}

		// GET: ProjetoVoluntario/Create
		public IActionResult Create()
		{
			ViewData["IdProjeto"] = new SelectList(_context.Projetos, "IdProjeto", "CidadeProjeto");
			ViewData["IdVoluntario"] = new SelectList(_context.CadastroVoluntario, "IdCadastro", "Login");
			return View();
		}

		// POST: ProjetoVoluntario/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("ProjetoVoluntarioId,IdProjeto,IdVoluntario,Status")] ProjetoVoluntario projetoVoluntario)
		{
			if (ModelState.IsValid)
			{
				_context.Add(projetoVoluntario);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			ViewData["IdProjeto"] = new SelectList(_context.Projetos, "IdProjeto", "CidadeProjeto", projetoVoluntario.IdProjeto);
			ViewData["IdVoluntario"] = new SelectList(_context.CadastroVoluntario, "IdCadastro", "Login", projetoVoluntario.IdVoluntario);
			return View(projetoVoluntario);
		}

		// GET: ProjetoVoluntario/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null || _context.ProjetoVoluntarios == null)
			{
				return NotFound();
			}

			var projetoVoluntario = await _context.ProjetoVoluntarios.FindAsync(id);
			if (projetoVoluntario == null)
			{
				return NotFound();
			}
			ViewData["IdProjeto"] = new SelectList(_context.Projetos, "IdProjeto", "CidadeProjeto", projetoVoluntario.IdProjeto);
			ViewData["IdVoluntario"] = new SelectList(_context.CadastroVoluntario, "IdCadastro", "Login", projetoVoluntario.IdVoluntario);
			return View(projetoVoluntario);
		}

		// POST: ProjetoVoluntario/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("ProjetoVoluntarioId,IdProjeto,IdVoluntario,Status")] ProjetoVoluntario projetoVoluntario)
		{
			if (id != projetoVoluntario.ProjetoVoluntarioId)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(projetoVoluntario);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!ProjetoVoluntarioExists(projetoVoluntario.ProjetoVoluntarioId))
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
			ViewData["IdProjeto"] = new SelectList(_context.Projetos, "IdProjeto", "CidadeProjeto", projetoVoluntario.IdProjeto);
			ViewData["IdVoluntario"] = new SelectList(_context.CadastroVoluntario, "IdCadastro", "Login", projetoVoluntario.IdVoluntario);
			return View(projetoVoluntario);
		}

		// GET: ProjetoVoluntario/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null || _context.ProjetoVoluntarios == null)
			{
				return NotFound();
			}

			var projetoVoluntario = await _context.ProjetoVoluntarios
				.Include(p => p.Projeto)
				.Include(p => p.Voluntario)
				.FirstOrDefaultAsync(m => m.ProjetoVoluntarioId == id);
			if (projetoVoluntario == null)
			{
				return NotFound();
			}

			return View(projetoVoluntario);
		}

		// POST: ProjetoVoluntario/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			if (_context.ProjetoVoluntarios == null)
			{
				return Problem("Entity set 'ApplicationDbContext.ProjetoVoluntarios'  is null.");
			}
			var projetoVoluntario = await _context.ProjetoVoluntarios.FindAsync(id);
			if (projetoVoluntario != null)
			{
				_context.ProjetoVoluntarios.Remove(projetoVoluntario);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool ProjetoVoluntarioExists(int id)
		{
			return _context.ProjetoVoluntarios.Any(e => e.ProjetoVoluntarioId == id);
		}
	}
}
