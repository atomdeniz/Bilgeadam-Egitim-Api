using BilgeadamEgitim.Core.Services;
using BilgeadamEgitim.WebAPI.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BilgeadamEgitim.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }


        [HttpPost("authenticate")]
        [AllowAnonymous]
        public IActionResult Authenticate(LoginDTO login)
        {
            var usertoken = _userService.Authenticate(login.Username, login.Password);

            if (usertoken == null)
            {
                return BadRequest(new { message = "Kullanıcı adı veya şifre hatalı" });
            }

            return Ok(usertoken);
        }
    }
}
