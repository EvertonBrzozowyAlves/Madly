using Microsoft.AspNetCore.Mvc;
using madly_BLL;
using madly_UI.Models;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace madly_UI.Controllers
{
    public class AnnotationController : Controller
    {
        private readonly AnnotationBLL _annotation;
        private readonly ILogger<AnnotationController> _logger;

        public AnnotationController(AnnotationBLL annotation, ILogger<AnnotationController> logger)
        {
            _annotation = annotation;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(string userId)
        {
            var annotations = _annotation.GetAllByUserId(userId);
            return View(annotations);
        }

        public IActionResult Delete()
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