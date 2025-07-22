using JWT_authentication_.dotnet_core_demo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_authentication_.dotnet_core_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IUserService _userService;

        public AuthController(ITokenService tokenService, IUserService userService)
        {
            _tokenService = tokenService;
            _userService = userService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            if (_userService.ValidateUser(model.Username, model.Password))
            {
                var token = _tokenService.BuildToken(model.Username);
                return Ok(new { token });
            }
            return Unauthorized();
        }

    }
}
