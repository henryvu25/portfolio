using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webtest_proj.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("home")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        [Route("projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }

        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}