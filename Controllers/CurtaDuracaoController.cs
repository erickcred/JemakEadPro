using System.Threading.Tasks;
using JemakEadPro.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JemakEadPro.Controllers
{
    [Controller]
    [Route("/curta-duracao/")]
    public class CurtaDuracaoController : Controller
    {
        JemakEadProContext _context;
        public CurtaDuracaoController(JemakEadProContext context)
            => _context = context;


        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}