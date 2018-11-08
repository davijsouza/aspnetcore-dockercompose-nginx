using Microsoft.AspNetCore.Mvc;

namespace AspnetCore.Orders.Controllers
{
    [Route("orders")]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(new[] {
                new {id = 1, clientId = 1, total = 100},
                new {id = 2, clientId = 2, total = 200},
                new {id = 3, clientId = 3, total = 300}
            });
        }
    }
}