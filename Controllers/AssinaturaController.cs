using System.Linq;
using System.Threading.Tasks;
using JemakEadPro.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JemakEadPro.Controllers
{
    [Controller]
    [Route("/assinaturas/")]
    public class AssinaturaController : Controller
    {
        JemakEadProContext _context;
        public AssinaturaController(JemakEadProContext context)
            => _context = context;


        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var cursos = await _context.Cursos.AsNoTracking().Where(x => x.Situacao == "Liberado").ToListAsync();
            return View("Index", cursos);
        }

        [HttpGet("curso/{id:int}")]
        public async Task<IActionResult> Curso([FromRoute] int id, [FromRoute] string nome)
        {
            var curso = await _context.Cursos
                                .AsNoTracking()
                                .FirstOrDefaultAsync(x => x.Id == id);

            return View("Curso", curso);
        }
    }
}