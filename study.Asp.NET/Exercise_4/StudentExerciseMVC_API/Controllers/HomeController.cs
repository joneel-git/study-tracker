using Microsoft.AspNetCore.Mvc;
using StudentExerciseMVC_API.Models;
using System.Diagnostics;

namespace StudentExerciseMVC_API.Controllers
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
            // Simulate fetching data from a database or some other data source
            List<string> items = new List<string>
            {
                "Item 1",
                "Item 2",
                "Item 3"
            };

            return View(items);
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
