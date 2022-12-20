using System.Linq;
using System.Threading.Tasks;
using JemakEadPro.Data;
using JemakEadPro.Models.Enums.Curso;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JemakEadPro.Areas.Publico.Controllers
{
    [Area("Publico")]
    [Controller]
    [Route("/curta-duracao/")]
    public class CurtaDuracaoController : Controller
    {
        JemakEadProContext _context;
        public CurtaDuracaoController(JemakEadProContext context)
            => _context = context;


        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var cursos = await _context.Cursos
                        .AsNoTracking()
                        .Where(
                            x => x.Situacao == "Liberado" && 
                            x.TipoCurso == ETipoCurso.CurtaDuracao)
                        .ToListAsync();
            return View("Index", cursos);
        }
    }
}