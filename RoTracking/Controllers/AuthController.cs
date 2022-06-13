using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoTracking.BusinessLogic.DTOs;
using RoTracking.BusinessLogic.IServices;
using RoTracking.BusinessLogic.Services;
using RoTracking.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RoTracking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        public IPersonService _personService;
        private JwtService _jwtService;
        public AuthController(IPersonService readerService, JwtService jwtService)
        {
            _personService = readerService;
            _jwtService = jwtService;
        }

        [HttpPost("Register")]
        public async Task<PersonDto> Register(PersonDto registerDto)
        {
            try
            {
                return await _personService.PersonRegister(registerDto);
            }
            catch (ArgumentException e)
            {
                return null;
            }
        }

        [HttpGet("GetAllPersons")]
        public async Task<IEnumerable<PersonDto>> GetAllPersons()
        {
            try
            {
                return await _personService.GetAllPersons();
            }
            catch (ArgumentException e)
            {
                return null;
            }
        }

        [HttpPost("Login")]
        public async Task<PersonDto> Login(LoginDto loginDto)
        {

            if (loginDto is not null)
            {
                var userToLogin = _personService.PersonLogin(loginDto);
                if (BCrypt.Net.BCrypt.Verify(loginDto.Password, userToLogin.Password))
                {
                    var jwtValue = _jwtService.GenerateToken(userToLogin.Id);
                    Response.Cookies.Append("jwt", jwtValue, new CookieOptions { HttpOnly = true });
                    return new PersonDto(userToLogin);
                }
            }

            return new PersonDto();
        }

        [HttpGet("GetUser")]
        public PersonDto GetUser()
        {
            var jwt = Request.Cookies["jwt"];
            var token = _jwtService.Verify(jwt);
            Guid userId = Guid.Parse(token.Issuer);
            var user = _personService.GetPerson(new Person { Id = userId });
            return user;
        }

        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("jwt");
            return Ok(new { message = "success" });
        }
    }
}
