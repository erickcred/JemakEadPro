using JemakEadPro.Data;
using Microsoft.AspNetCore.Mvc;

namespace JemakEadPro.Controllers
{
    [Controller]
    [Route("/ao-vivo")]
    public class AoVivoController : Controller
    {
        JemakEadProContext _context;
        public AoVivoController(JemakEadProContext context)
            => _context = context;


        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}