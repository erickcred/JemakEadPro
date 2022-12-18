using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JemakEadPro.Data;
using JemakEadPro.Models;
using JemakEadPro.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JemakEadPro.Areas.Administrativo.Controllers
{
    [Area("Administrativo")]
    [Controller]
    [Route("/adm/")]
    public class VideoAdminController  : Controller
    {
        private JemakEadProContext _context;

        public VideoAdminController ([FromServices] JemakEadProContext context)
            => _context = context;


        [HttpGet("videos")]
        public async Task<IActionResult> Index()
        {
            var videos = await _context.Videos
                        .AsNoTracking()
                        .Include(x => x.Curso)
                        .ToListAsync<Video>();

            return View("Index", videos);
        }

        // [HttpPost("videos")]
        // public async Task<IActionResult> Index([FromForm] string pesquisa)
        // {
        //     var videos = await _context.Videos.FromSqlRaw("SELECT * FROM Curso WHERE Nome like {0}", $"%{pesquisa}%").ToListAsync();

        //     if (pesquisa != null)
        //         return View("Index", videos);

        //     return Redirect("/adm/videos");
        // }

        

        [HttpPost("videos/criar")]
        public async Task<IActionResult> Criar([FromForm] int CursoId, [FromForm] Video model)
        {
            var curso =  await _context.Cursos.FirstOrDefaultAsync(x => x.Id == CursoId);
            model.Curso = curso;

            Console.WriteLine(@$"
                Curso: {curso.Id}
                Nome: {model.Nome}
                ProjetoId: {model.ProjetoId}
                VideoId: {model.VideoId}
                Url: {model.Url}
                Id: {model.Duracao}
                VideoCurso: {model.Curso}
            ");

            var video = new Video();
            if (model.Nome != null)
            {
                video = model;
                await _context.Videos.AddAsync(video);
                await _context.SaveChangesAsync();
            }

            return Redirect($"/adm/cursos/editar/{CursoId}");
        }

        [HttpGet("videos/editar/{id:int}")]
        public async Task<IActionResult> Editar([FromRoute] int id)
        {
            var video = await _context.Videos
                            .Include(x => x.Curso)
                            .FirstOrDefaultAsync(x => x.Id == id);
            return View("EditarVideo", video);
        }

        [HttpPost("videos/editar")]
        public async Task<IActionResult> Editar([FromForm] Video model)
        {
            var video = await _context.Videos
                            .Include(x => x.Curso)
                            .FirstOrDefaultAsync(x => x.Id == model.Id);
            
            if (video == null)
                return Redirect($"/adm/videos/editar/{model.Id}");
            
            
            video.Nome = model.Nome;
            video.Ordem = model.Ordem;

            _context.Videos.Update(video);
            await _context.SaveChangesAsync();

            return Redirect($"/adm/cursos/editar/{video.Curso.Id}");
            
        }


    }
}