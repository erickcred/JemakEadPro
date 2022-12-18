using System;
using System.Threading.Tasks;
using JemakEadPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace JemakEadPro.Areas.Administrativo.Controllers
{
    [Area("Administrativo")]
    [Controller]
    [Route("/adm/")]
    public class HomeAdminController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

    }
}