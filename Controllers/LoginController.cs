using JemakEadPro.Data;
using Microsoft.AspNetCore.Mvc;
using JemakEadPro.ViewModels;

namespace JemakEadPro.Controllers
{
    [Controller]
    [Route("/login/")]
    public class LoginController : Controller
    {
        private JemakEadProContext _context;
        public LoginController(JemakEadProContext context)
            => _context = context;

        public IActionResult Login([FromForm] LoginViewModel login)
        {
            
            return View("Login");
        }
    }
}