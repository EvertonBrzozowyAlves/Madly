using System.Collections.Generic;
using madly_BLL;
using madly_models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace madly_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnnotationsController : ControllerBase
    {
        private readonly ILogger<AnnotationsController> _logger;
        private readonly AnnotationBLL _bll;

        public AnnotationsController(ILogger<AnnotationsController> logger, AnnotationBLL bll)
        {
            _logger = logger;
            _bll = bll;

        }
        [Route("[Action]/{id}")]
        [HttpGet]
        public IEnumerable<Annotation> GetAllByUserId(string userId)
        {
            return _bll.GetAllByUserId(userId);
        }
    }
}
