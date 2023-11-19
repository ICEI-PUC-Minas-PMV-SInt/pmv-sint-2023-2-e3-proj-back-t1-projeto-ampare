using ampare_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ampare_backend.Controllers
{
    public class CadastroVoluntariosController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CadastroVoluntariosController(ApplicationDbContext context)
        {
        }

        public  async Task<IActionResult>  Index()
        {
            var dados = await _context.CadastroVoluntarios.ToListAsync();
            return View(dados);
        }






}    }  
