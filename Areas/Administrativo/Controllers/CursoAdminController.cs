using System;
using System.Linq;
using System.Threading.Tasks;
using JemakEadPro.Data;
using JemakEadPro.Models;
using JemakEadPro.Models.Enums.Curso;
using JemakEadPro.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JemakEadPro.Areas.Administrativo.Controllers
{
    [Area("Administrativo")]
    [Controller]
    [Route("/adm/")]
    public class CursoAdminController : Controller
    {
        private JemakEadProContext _context;

        public CursoAdminController([FromServices] JemakEadProContext context)
            => _context = context;


        [HttpGet("cursos")]
        public async Task<IActionResult> Index()
        {
            var cursos =  await _context.Cursos.AsNoTracking().ToListAsync();
            return View("Index", cursos);
        }

        [HttpPost("cursos")]
        public async Task<IActionResult> Index([FromForm] string pesquisa)
        {
            //EF.Functions.Like(x.Name, queryName)
            // var cursos = await _context.Cursos
            //                 .FromSqlRaw("SELECT * FROM Curso WHERE Nome like {0}", $"%{pesquisa}%").ToListAsync();

            var cursos = await _context.Cursos
                            .Where(x => EF.Functions.Like(x.Nome, pesquisa)).ToListAsync();

            if (pesquisa != null)
                return View("Index", cursos);

            return Redirect("/adm/cursos");
        }

        [HttpGet("cursos/cadastro")]
        public  IActionResult CadastroCurso()
        {
            
            return View("CadastroCurso");
        }

        [HttpPost("cursos/criar")]
        public async Task<IActionResult> Criar(IFormFile file, [FromForm] Curso model)
        {
            var curso = new Curso();   
            curso = model;

            var newPath = "image/cursos/curso-default.png";
            if (file == null)
            {
                curso.Imagem = newPath;
            }
            else
            {
                newPath = await SalvarArquivo.Salvar(file, "image/cursos");
                SalvarArquivo.Deletar(curso.Imagem, "image/cursos/curso-default.png");
                curso.Imagem = newPath;
            }

            await _context.Cursos.AddAsync(curso);
            await _context.SaveChangesAsync();
            return Redirect("/adm/cursos");
        }

        [HttpGet("cursos/editar/{id:int}")]
        public async Task<IActionResult> EditarCurso([FromRoute] int id)
        {
            var curso = await _context.Cursos
                            .AsNoTracking()
                            .Include(x => x.Videos)
                            .FirstOrDefaultAsync<Curso>(x => x.Id == id);
            return View("EditarCurso", curso);
        }

        [HttpPost("cursos/editar")]
        public async Task<IActionResult> Editar(IFormFile file, [FromForm] Curso model)
        {
            var curso = await _context.Cursos.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (curso == null)
                return Redirect($"/adm/cursos/editar/{model.Id}");

            curso.ProjetoToken = model.ProjetoToken;
            curso.ProjetoId = model.ProjetoId;
            curso.ProjetoPlayerKey = model.ProjetoPlayerKey;
            curso.Nome = model.Nome;
            curso.Situacao = model.Situacao;
            curso.Categoria = model.Categoria;
            curso.TipoCurso = model.TipoCurso;
            curso.CargaHoraria = model.CargaHoraria;
            curso.Descricao = model.Descricao;
            curso.Objetivo = model.Objetivo;
            curso.ParaQuem = model.ParaQuem;
            curso.EstruturaDoCurso = model.EstruturaDoCurso;
            curso.AcessoIlimitado = model.AcessoIlimitado;
            curso.Metodologia = model.Metodologia;
            curso.Excelencia = model.Excelencia;
            curso.Atencao = model.Atencao;
            curso.Professor = model.Professor;
            curso.DataSubmicaoCRC = model.DataSubmicaoCRC;
            curso.DataVencimentoCRC = model.DataVencimentoCRC;
            curso.TurmaCRC = model.TurmaCRC;
            curso.CodigoCursoCRC = model.CodigoCursoCRC;
            curso.CategoriasPontuacao = model.CategoriasPontuacao;
            curso.Pontos = model.Pontos;
            curso.DataAtualizacao = model.DataAtualizacao;         
            
            var newPath = "";
            if (file == null)
            {
                newPath = curso.Imagem;
                Console.WriteLine("Nome caminho Imagem: " + curso.Imagem);
            }
            else
            {
                newPath = await SalvarArquivo.Salvar(file, "image/cursos");
                SalvarArquivo.Deletar(curso.Imagem, "image/cursos/curso-default.png");
                curso.Imagem = newPath;
            }


            _context.Cursos.Update(curso);
            await _context.SaveChangesAsync();
            return Redirect("/adm/cursos");
        }

        [HttpGet("cursos/ativar/{id:int}")]
        public async Task<IActionResult> Ativar([FromRoute] int id)
        {
            var curso = await _context.Cursos.FirstOrDefaultAsync(x => x.Id == id);
            curso.Ativo = true;
            _context.Cursos.Update(curso);
            await _context.SaveChangesAsync();
            return Redirect("/adm/cursos");
        }

        [HttpGet("cursos/inativar/{id:int}")]
        public async Task<IActionResult> Inativar([FromRoute] int id)
        {
            var curso = await _context.Cursos.FirstOrDefaultAsync(x => x.Id == id);
            curso.Ativo = false;
            _context.Cursos.Update(curso);
            await _context.SaveChangesAsync();
            return Redirect("/adm/cursos");
        }

    }
}