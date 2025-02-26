using System.Diagnostics;
using DataAccesslayer;
using Microsoft.AspNetCore.Mvc;
using SimpleWebCRUDApp.Models;

namespace SimpleWebCRUDApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Test1 _test;

        public HomeController(ILogger<HomeController> logger, Test1 test)
        {
            _logger = logger;
            _test = test;
        }

        public IActionResult Index()
        {
            _test.method1();
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
