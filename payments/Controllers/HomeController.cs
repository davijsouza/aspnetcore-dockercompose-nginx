using Microsoft.AspNetCore.Mvc;

namespace AspnetCore.Payments.Controllers
{
    [Route("")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok(new { message = "Hello from Payments module" });
        }
    }
}
