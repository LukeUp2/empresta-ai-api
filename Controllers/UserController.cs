using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register()
        {
            return Ok();
        }

        [HttpGet("me")]
        public IActionResult GetDetails()
        {
            return Ok();
        }

        [HttpPut("me")]
        public IActionResult Put()
        {
            return Ok();
        }
    }
}