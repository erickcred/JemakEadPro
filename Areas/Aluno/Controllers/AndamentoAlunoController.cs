
using System;
using System.Linq;
using System.Threading.Tasks;
using JemakEadPro.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JemakEadPro.Areas.Aluno.Controllers
{
    [Authorize(Policy = "Aluno")]
    [Area("Aluno")]
    [Controller]
    [Route("/portal/")]
    public class AndamentoAlunoController : Controller
    {
        private JemakEadProContext _context;

        public AndamentoAlunoController([FromServices] JemakEadProContext context)
            => _context = context;

        [HttpPost("inicio")]
        public void InicioAndamamento()
        {

        }

        [HttpPost("curso/finalizado")]
        public async Task<IActionResult> Finalizado([FromForm] int Id, [FromForm] string VideoId, [FromForm] bool finalizado)
        {
            var video = await _context.Videos.FirstOrDefaultAsync(x => x.Curso.Id == Id && x.VideoId == VideoId);

            Console.WriteLine(video.Nome);
            video.Finalizado = true;
            _context.Update(video);
            await _context.SaveChangesAsync();

            return Redirect($"/portal/curso/{1}");
        }
    }
}