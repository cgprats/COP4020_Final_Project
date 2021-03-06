using COP4020_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace COP4020_Final_Project.Controllers
{
    public class HomeController : Controller
    {
        private static List<Guest> guests = new List<Guest>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult GuestList()
        {
            ViewData["guests"] = guests;
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RSVP()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RSVP(Guest guest)
        {
            if (ModelState.IsValid)
            {
                guests.Add(guest);
                return RedirectToAction("Success");
            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Success()
        {
            ViewData["guest"] = guests[guests.Count - 1].Name;
            return View();
        }
    }
}