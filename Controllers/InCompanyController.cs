using JemakEadPro.Data;
using Microsoft.AspNetCore.Mvc;

namespace JemakEadPro.Controllers
{
    [Controller]
    [Route("/in-company")]
    public class InCompanyController : Controller
    {
        JemakEadProContext _context;
        public InCompanyController(JemakEadProContext context)
            => _context = context;


        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}