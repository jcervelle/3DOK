using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3DOK_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3DOK_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OauthController : ControllerBase
    {
        IUserService _userService;
        public OauthController(IUserService user)
        {
            _userService = user;
        }

        [HttpGet]
        [Route("{token}")]
        public IActionResult GetByToken(string token)
        {
            var users = _userService.CheckToken(token);
            if (users == null)
            {
                return BadRequest("Invalid Token or Token expire");
            }
            return Ok(users);
        }
    }
}