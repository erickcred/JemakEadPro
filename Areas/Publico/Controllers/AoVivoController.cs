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
    [Route("/ao-vivo")]
    public class AoVivoController : Controller
    {
        JemakEadProContext _context;
        public AoVivoController(JemakEadProContext context)
            => _context = context;


        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var cursos = await _context.Cursos
                        .AsNoTracking()
                        .Where(
                            x => x.Situacao == "Liberado" &&
                            x.TipoCurso == ETipoCurso.AoVivo)
                        .ToListAsync();
            return View("Index", cursos);
        }
    }
}