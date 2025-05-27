using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoansController : ControllerBase
    {
        [HttpGet("owned")]
        public IActionResult GetOwned()
        {
            return Ok();
        }

        [HttpGet("borrowed")]
        public IActionResult GetBorrowed()
        {
            return Ok();
        }

        [HttpPost("{loanId}/status")]
        public IActionResult Status()
        {
            return Ok();
        }

        [HttpPut("{loanId}")]
        public IActionResult Put([FromRoute] long loanId)
        {
            return Ok();
        }

        [HttpDelete("{loanId}")]
        public IActionResult Delete([FromRoute] long loanId)
        {
            return Ok();
        }
    }
}