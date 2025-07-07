using Microsoft.AspNetCore.Mvc;
using JonJones.Models;

namespace JonJones.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Sportsman _jonJones = new Sportsman
        {
            Name = "Jon Jones",
            Record = "26-1-0",
            Reach = "84.5 in",
            Style = "Wrestling / BJJ / Striking",
            Biography = "Jonathan Dwight Jones is an American mixed martial artist widely regarded as one of the greatest fighters in MMA history. Born on July 19, 1987, Jones began his professional MMA career in 2008 and quickly rose to prominence due to his unique fighting style, athleticism, and fight IQ. He has held the UFC Light Heavyweight Championship multiple times and is known for his dominant performances and numerous title defenses."
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_jonJones);
        }

        public IActionResult Biography()
        {
            return View(_jonJones);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
