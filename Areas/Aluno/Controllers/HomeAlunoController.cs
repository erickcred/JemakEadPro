using System.Linq;
using System.Threading.Tasks;
using JemakEadPro.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JemakEadpro.Areas.Aluno.Controllers
{
    [Area("Aluno")]
    [Controller]
    [Route("/portal/")]
    public class HomeAlunoController : Controller
    {
        private JemakEadProContext _context;

        public HomeAlunoController(JemakEadProContext context)
            => _context = context;

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("cursos")]
        public async Task<IActionResult> Cursos()
        {
            var cursos = await _context.Cursos
                                .AsNoTracking()
                                .Where(x => x.Situacao == "Liberado" || x.Situacao == "Portal")
                                .ToListAsync();
            return View("Cursos", cursos);
        }

        [HttpGet("curso/{id:int}")]
        public async Task<IActionResult> Cursos([FromRoute] int id)
        {
            var curso = await _context.Cursos
                                .AsNoTracking()
                                .Where(x => x.Situacao == "Liberado" || x.Situacao == "Portal")
                                .Include(x => x.Videos)
                                .FirstOrDefaultAsync(x => x.Id == id);
                                
            if (curso != null)
                return View("Curso", curso);
            
            return Redirect("/portal/cursos");
                
        }
    }
}