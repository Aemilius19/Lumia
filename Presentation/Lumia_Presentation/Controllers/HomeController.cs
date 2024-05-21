
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lumia_Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
