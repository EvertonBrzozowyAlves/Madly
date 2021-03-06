using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using madly_BLL;
using madly_UI.Models;

namespace madly_UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserBLL _user;

        public HomeController(ILogger<HomeController> logger, UserBLL user)
        {
            _logger = logger;
            _user = user;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var users = _user.GetAll();
            return View(users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}