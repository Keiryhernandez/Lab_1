using System.Diagnostics;
using Lab_1.DB;
using Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext appDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext _appDbContext)
        {
            _logger = logger;
   
            appDbContext = _appDbContext;
        }

        public IActionResult Index()
        {
           var alumnos= appDbContext.Alumnos.ToList();
            return View(alumnos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
