using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Projeto1.Controllers
{

    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
