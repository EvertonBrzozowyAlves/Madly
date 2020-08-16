using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using madly_BLL;
using madly_models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace madly_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnnotationsController : ControllerBase
    {
        private readonly ILogger<AnnotationsController> _logger;
        private readonly AnnotationBLL _bll;

        public AnnotationsController(ILogger<AnnotationsController> logger, AnnotationBLL bll)
        {
            _logger = logger;
            _bll = bll;

        }

        [HttpGet("{id}", Name = "GetAllByUserId")]
        public IEnumerable<Annotation> GetAllByUserId(string userId)
        {
            return _bll.GetAllByUserId(userId);
        }
    }
}
