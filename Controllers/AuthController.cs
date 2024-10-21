using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Services;
using StudentManagementSystem.DTOs;

namespace StudentManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(UserLoginDTO loginDTO)
        {
            var token = _authService.Authenticate(loginDTO.Username, loginDTO.Password);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(new { Token = token });
        }

        [HttpPost("register")]
        public IActionResult Register(UserRegistrationDTO registrationDTO)
        {
            _authService.RegisterUser(registrationDTO.Username, registrationDTO.Password, registrationDTO.Email);
            return Ok();
        }
    }
}
