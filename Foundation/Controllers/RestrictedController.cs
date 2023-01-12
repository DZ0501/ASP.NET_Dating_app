using Foundation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Foundation.Controllers
{
    [Authorize]
    public class RestrictedController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public RestrictedController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Restricted_1()
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