using System;
using System.Security.Claims;
using System.Threading.Tasks;
using JemakEadPro.Data;
using JemakEadPro.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JemakEadPro.Areas.Publico.Controllers
{
    [Area("Publico")]
    [Controller]
    [Route("/login/")]
    public class AccountController : Controller
    {
        private JemakEadProContext _context;
        public AccountController([FromServices] JemakEadProContext context)
            => _context = context;

        [HttpGet("")]
        public IActionResult Login() 
           => View("Login");


        [HttpPost("valida-login")]
        public async Task<IActionResult> Login([FromForm] LoginViewModel model)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Email == model.Email);
            if (usuario != null)
            {
                if (usuario.Senha == model.Senha)
                {
                    // HttpContext.Session.SetInt32("UsuarioId", usuario.Id);
                    // HttpContext.Session.SetString("UsuarioNome", usuario.Nome);
                    // HttpContext.Session.SetString("UsuarioImagem", usuario.Imagem);
                    
                    ClaimsIdentity identity = new ClaimsIdentity("CookieUsuarioLiberado");

                    identity.AddClaim(new Claim(ClaimTypes.Sid, Convert.ToString(usuario.Id), "Id"));
                    identity.AddClaim(new Claim(ClaimTypes.Role, usuario.TipoUsuario.ToString()));
                    identity.AddClaim(new Claim(ClaimTypes.Name, usuario.Nome));
                    identity.AddClaim(new Claim(ClaimTypes.Email, usuario.Email));
                    identity.AddClaim(new Claim(ClaimTypes.Spn, usuario.Imagem));

                    ClaimsPrincipal principal = new ClaimsPrincipal(new[] { identity });

                    await HttpContext.SignInAsync(principal);

                    return Redirect("/portal");
                }
            }
            return View("Login");
        }

        [HttpGet("/sair")]
        public IActionResult Sair()
        {
            HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}