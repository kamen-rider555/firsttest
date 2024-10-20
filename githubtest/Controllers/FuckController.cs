using Microsoft.AspNetCore.Mvc;

namespace githubtest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuckController : ControllerBase
    {
       
        private readonly ILogger<FuckController> _logger;

        public FuckController(ILogger<FuckController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "fuckyou";
        }
    }
}
