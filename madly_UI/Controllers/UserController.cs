using Microsoft.AspNetCore.Mvc;
using madly_models.Models;
using madly_BLL;
using Microsoft.Extensions.Logging;
using madly_UI.Models;
using System.Diagnostics;

namespace madly_UI.Controllers
{
    public class UserController : Controller
    {
        //config para injeção de dependência
        private readonly UserBLL _user;
        private readonly ILogger<UserController> _logger;

        //config para injeção de dependência
        public UserController(UserBLL user, ILogger<UserController> logger)
        {
            _user = user;
            _logger = logger;

        }

        // GET
        [HttpGet]
        [Route("User")]
        public IActionResult Index()
        {
            var users = _user.GetAll();
            return View(users);
        }

        [HttpGet]
        [Route("User/Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("User/Register")]
        public IActionResult Register(User user)
        {
            _user.Create(user);
            return RedirectToAction("Index", "Team");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}