using Microsoft.AspNetCore.Mvc;

namespace AspnetCore.Payments.Controllers
{
    [Route("payments")]
    public class PaymentsController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult GetOrderPayments()
        {
            return Ok(new
            {
                id = 1,
                payments = new[]
                {
                    new {type = "cash", total = 50},
                    new {type = "check", total = 50}
                }
            });
        }
    }
}
