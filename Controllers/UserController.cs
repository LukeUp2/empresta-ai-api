using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Requests;
using api.UseCases.User.Create;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register(CreateUserRequest request, [FromServices] CreateUserUseCase useCase)
        {
            useCase.Execute(request);
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