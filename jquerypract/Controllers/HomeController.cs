using jquerypract.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace jquerypract.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index1()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }public IActionResult abc()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult list()
        {
            return View();
        }
        public IActionResult griddynamic()
        {
            return View();
        }

        public IActionResult grid()
        {
            return View();
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
