using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeWebApi.Dtos;
using PracticeWebApi.Services.Contract;

namespace PracticeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [AllowAnonymous]
        [HttpPost("Register")]
        public IActionResult RegisterUser(RegisterDto registerDto)
        {

            var result = _userService.RegisterUserService(registerDto);

            return !result.Success ? BadRequest(result) : Ok(result);
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login(LoginDto login)
        {
            var response = _userService.LoginUserService(login);
            return !response.Success ? BadRequest(response) : Ok(response);
        }

    }
}
