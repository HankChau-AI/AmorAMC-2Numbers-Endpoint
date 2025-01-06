using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AmorAMC_2Numbers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TwoPlusTwoApiController : ControllerBase
    {
         [HttpGet("add")]
        public IActionResult AddNumbers([FromQuery] int number1, [FromQuery] int number2)
        {
            var sum = number1 + number2;
            var message = $"The sum of {number1} and {number2} is {sum}.";
            return Ok(new { Message = message });
        }
    }
}