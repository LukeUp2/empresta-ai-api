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
        public async Task<IActionResult> RegisterAsync(CreateUserRequest request, [FromServices] CreateUserUseCase useCase)
        {
            var response = await useCase.Execute(request);
            return Ok(response);
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