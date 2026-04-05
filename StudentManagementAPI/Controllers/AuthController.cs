using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Helpers;

namespace StudentManagementAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IConfiguration _config;

		public AuthController(IConfiguration config)
		{
			_config = config;
		}

		[HttpPost("login")]
		public IActionResult Login()
		{
			var token = JwtHelper.GenerateToken(
				_config["Jwt:Key"],
				_config["Jwt:Issuer"]);

			return Ok(new { Token = token });
		}
	}
}
