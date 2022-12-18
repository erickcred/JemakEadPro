using System.Threading.Tasks;
using JemakEadPro.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JemakEadPro.Controllers
{
    [Controller]
    [Route("/capacitacao/")]
    public class CapacitacaoController : Controller
    {
        JemakEadProContext _context;
        public CapacitacaoController (JemakEadProContext context)
            => _context = context;


        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}