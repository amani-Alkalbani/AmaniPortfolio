using System.Diagnostics;
using AmaniPortfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmaniPortfolio.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult DownloadCV()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(),
                                       "wwwroot",
                                     
                                       "Amani_alkalbani_CV.pdf");

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            return PhysicalFile(filePath, "application/pdf", "Amani_alkalbani_CV.pdf");
        }
    }
}
