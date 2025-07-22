using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController : ControllerBase
    {
        [HttpGet("account")]
        public IActionResult GetAccountDetails()
        {
            Log.Information("Account details requested by user: {User}", User.Identity?.Name);
            return Ok(new { balance = 1000.00, currency = "USD" });
        }
    }
}