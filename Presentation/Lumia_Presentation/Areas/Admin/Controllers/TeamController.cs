using Lumia_Application.Abstractions;
using Lumia_Persistence.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Lumia_Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        AppDbContext _context;
        ITeamService _service;

        public TeamController(AppDbContext context, ITeamService service)
        {
            _context = context;
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_context.TeamSlider.ToList()) ;
        }

        public IActionResult Create()
        {


            return View();
        }
    }
}
