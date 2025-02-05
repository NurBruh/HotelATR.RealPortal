using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using HotelATR.RealPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelATR.RealPortal.Controllers
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

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMessage(Message userMessage)
        {
            return View();
            //var data = Request.Form;
        }

        [HttpPost]
        public IActionResult Subscribe(string email)
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
