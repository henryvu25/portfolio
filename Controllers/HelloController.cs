using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace webtest_proj.Controllers
{
    public class HelloController : Controller
    {
        [HttpGetAttribute]
        public string Index()
        {
            return "Hello World!";
        }
    }
}