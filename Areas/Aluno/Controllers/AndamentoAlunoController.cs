using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JemakEadPro.Areas.Aluno.Controllers
{
    [Authorize(Policy = "Aluno")]
    [Area("Aluno")]
    [Controller]
    [Route("/portal/")]
    public class AndamentoAlunoController : Controller
    {
        [HttpPost("inicio")]
        public void InicioAndamamento()
        {

        }
    }
}