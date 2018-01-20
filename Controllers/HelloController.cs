using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webtest_proj.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

    }
}