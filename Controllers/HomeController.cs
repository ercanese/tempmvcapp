using dockersqlapp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dockersqlapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DemoAppContext context;
        public HomeController(DemoAppContext _context)
        {
            context = _context;
        }

       
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddRequest()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRequest(Request model)
        {
            context.requests.Add(model);
            context.SaveChanges();
            return View("Thanks",model);
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