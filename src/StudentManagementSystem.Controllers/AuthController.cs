using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Services;
using StudentManagementSystem.DTOs;
using StudentManagementSystem.Domain;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLoginDTO loginDTO)
        {
            if (loginDTO == null)
            {
                return BadRequest(new { Message = "Invalid login data." });
            }

            if (string.IsNullOrWhiteSpace(loginDTO.Username) || string.IsNullOrWhiteSpace(loginDTO.Password))
            {
                return BadRequest(new { Message = "Username and password are required." });
            }

            var token = _authService.Authenticate(loginDTO.Username, loginDTO.Password);
            if (token == null)
            {
                return Unauthorized(new { Message = "Invalid credentials." });
            }

            return Ok(new { Token = token });
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserRegistrationDTO registrationDTO)
        {
            if (registrationDTO == null)
            {
                return BadRequest(new { Message = "Invalid registration data." });
            }

            if (string.IsNullOrWhiteSpace(registrationDTO.Username) ||
                string.IsNullOrWhiteSpace(registrationDTO.Password) ||
                string.IsNullOrWhiteSpace(registrationDTO.Email))
            {
                return BadRequest(new { Message = "Username, password, and email are required." });
            }

            if (!new EmailAddressAttribute().IsValid(registrationDTO.Email))
            {
                return BadRequest(new { Message = "Invalid email format." });
            }

            _authService.RegisterUser(registrationDTO.Username, registrationDTO.Password, registrationDTO.Email);
            return Ok(new { Message = "Registration successful" });
        }
    }
}