using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3DOK_API.Model;
using _3DOK_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _3DOK_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost]
        [HttpPost("signin")]
        public IActionResult Authenticate([FromBody]User model)
        {
            var user = _userService.Authenticate(model.Email, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        //[AllowAnonymous]
        //[HttpPost]
        //[HttpPost("signin")]
        //public IActionResult Logout()
        //{
        //    var user = _userService.(model.Email, model.Password);

        //    if (user == null)
        //        return BadRequest(new { message = "Username or password is incorrect" });

        //    return Ok(user);
        //}

        [AllowAnonymous]
        [HttpPost]
        [Route("signup")]
        public IActionResult CreateUser([FromBody]User user)
        {
            var utilisateur = _userService.CreateUser(user);
            return Ok();
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            _logger.LogInformation("Retrieving users");
            return _userService.GetUsers();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            _logger.LogInformation($"Retrieving user {id}");
            return _userService.GetUser(id);
        }

        [AllowAnonymous]
        [HttpPost]
        public User Post(User user)
        {
            _logger.LogInformation("Creating user");
            return _userService.CreateUser(user);
        }

        [HttpPut]
        public void Put(User user)
        {
            _logger.LogInformation("Updating user");
            _userService.UpdateUser(user);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _logger.LogInformation("Deleting user");
            _userService.DeleteUser(id);
        }
    }
}
