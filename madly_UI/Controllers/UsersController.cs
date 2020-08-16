using Microsoft.AspNetCore.Mvc;
using madly_models;
using madly_BLL;
using Microsoft.Extensions.Logging;
using madly_UI.Models;
using System.Diagnostics;

namespace madly_UI.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserBLL _user;
        private readonly ILogger<UserController> _logger;

        //config para injeção de dependência
        public UsersController(UserBLL user, ILogger<UserController> logger)
        {
            _user = user;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult All()
        {
            var users = _user.GetAll();
            return Json(users);
        }



    }
}