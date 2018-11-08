using Microsoft.AspNetCore.Mvc;

namespace AspnetCore.Orders.Controllers
{
    [Route("")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok(new { message = "Hello from Orders module" });
        }
    }
}