using System;
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
    public class UsuarioAdminController : Controller
    {
        private JemakEadProContext _context;
        public UsuarioAdminController([FromServices] JemakEadProContext context)
            => _context = context;


        [HttpGet("usuarios")]
        public async Task<IActionResult> Index()
        {
            var usuarios = await _context.Usuarios.AsNoTracking().ToListAsync();
            return View("Index", usuarios);
        }

        [HttpGet("usuarios/cadastro")]
        public IActionResult CadatroUsuario()
        {
            return View("CadastroUsuario");
        }

        [HttpPost("usuarios/criar")]
        public async Task<IActionResult> Criar(IFormFile file, [FromForm] Usuario model)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.CPF == model.CPF);
            if (usuario == null)
            {
                var newPath = "image/usuarios/usuario-default.png";
                if (file == null)
                {
                    model.Imagem = newPath;
                    Console.WriteLine("Nome caminho Imagem: " + model.Imagem);
                }
                else
                {
                    newPath = await SalvarArquivo.Salvar(file, "image/usuarios");
                    SalvarArquivo.Deletar(model.Imagem, "image/usuarios/usuario-default.png");
                    model.Imagem = newPath;
                }

                _context.Usuarios.Update(model);
                await _context.SaveChangesAsync();
            }
            return Redirect("/adm/usuarios");
        }

        [HttpGet("usuarios/editar/{id:int}")]
        public async Task<IActionResult> Editar([FromRoute] int id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            return View("EditarUsuario", usuario);
        }

        [HttpPost("usuarios/editar")]
        public async Task<IActionResult> Editart(IFormFile file, [FromForm] Usuario model)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == model.Id);

            usuario.Nome = model.Nome;
            usuario.Email = model.Email;
            usuario.CPF = model.CPF;
            usuario.RG = model.RG;
            usuario.Telefone = model.Telefone;
            usuario.Celular = model.Celular;
            usuario.TelefoneTrabalho = model.TelefoneTrabalho;
            usuario.Sexo = model.Sexo;
            usuario.DataNascimento = model.DataNascimento;
            usuario.CarteiraProfissional = model.CarteiraProfissional;
            usuario.TipoUsuario = model.TipoUsuario;
            // usuario.Senha = model.Senha;
            // usuario.Perfil = model.Perfil;
            // usuario.DataCadastro = model.DataCadastro;
            // usuario.Imagem = model.Imagem;
            // usuario. Ativo = model. Ativo;
            usuario.CEP = model.CEP;
            usuario.Endereco = model.Endereco;
            usuario.Numero = model.Numero;
            usuario.Complemento = model.Complemento;
            usuario.Estado = model.Estado;
            usuario.Cidade = model.Cidade;
            usuario.Bairro = model.Bairro;
            usuario.NomeResponsavel = model.NomeResponsavel;
            usuario.CpfCnpj = model.CpfCnpj;
            usuario.ResponsavelTelefone = model.ResponsavelTelefone;

            if (usuario != null)
            {
                var newPath = "image/usuarios/usuario-default.png";
                if (file == null)
                {
                    usuario.Imagem = usuario.Imagem;
                    Console.WriteLine("Nome caminho Imagem: " + usuario.Imagem);
                }
                else
                {
                    newPath = await SalvarArquivo.Salvar(file, "image/usuarios");
                    SalvarArquivo.Deletar(usuario.Imagem, "image/usuarios/usuario-default.png");
                    usuario.Imagem = newPath;
                }
            }

            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
            return Redirect("/adm/usuarios");
        }



        [HttpGet("usuarios/ativar/{id:int}")]
        public async Task<IActionResult> Ativar([FromRoute] int id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            if (usuario == null)
                return Redirect("/adm/usuarios");
            
            usuario.Ativo = true;
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
            return Redirect("/adm/usuarios");
        }

        [HttpGet("usuarios/inativar/{id:int}")]
        public async Task<IActionResult> Inativar([FromRoute] int id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            if (usuario == null)
                return Redirect("/adm/usuarios");
            
            usuario.Ativo = false;
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
            return Redirect("/adm/usuarios");
        }
        
    }
}