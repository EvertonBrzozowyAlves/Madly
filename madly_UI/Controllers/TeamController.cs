using Microsoft.AspNetCore.Mvc;
using madly_models;
using madly_BLL;
using Microsoft.Extensions.Logging;
using madly_UI.Models;
using System.Diagnostics;

namespace madly_UI.Controllers
{
    public class TeamController : Controller
    {
        //config para injeção de dependência
        private readonly UserBLL _user;
        private readonly ILogger<TeamController> _logger;

        //config para injeção de dependência
        public TeamController(UserBLL user, ILogger<TeamController> logger)
        {
            _user = user;
            _logger = logger;
        }

        // GET
        public IActionResult Index()
        {
            var users = _user.GetAll();
            return View(users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}