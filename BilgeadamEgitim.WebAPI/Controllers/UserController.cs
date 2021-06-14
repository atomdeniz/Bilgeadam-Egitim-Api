using BilgeadamEgitim.Common.DTO;
using BilgeadamEgitim.Core.Models;
using BilgeadamEgitim.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


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
        public async Task<IActionResult> Authenticate(LoginDTO login)
        {
            var loginResponse = await _userService.Authenticate(login.Username, login.Password);

            if (loginResponse == null)
            {
                return BadRequest(new { message = "Kullanıcı adı veya şifre hatalı" });
            }

            return Ok(loginResponse);
        }


        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterDTO register)
        {
            var user = new User
            {
                Email = register.Email,
                Name = "Deniz",
                Password = register.Password,
                Surname = "Ozogul",
                Username = register.Username
            };

            var registerReponse = await _userService.UserRegister(user);


            return Ok(new JsonResult(new { message = "Kullanıcı başarılya oluşturuldu" }));
        }
    }
}
