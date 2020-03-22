using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebCalc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpGet("[action]")]
        public ObjectResult Add([FromQuery]double num1, [FromQuery]double num2)
            => Ok(num1 + num2);

        [HttpGet("[action]")]
        public ObjectResult Subtract([FromQuery]double num1, [FromQuery]double num2)
            => Ok(num1 - num2);

        [HttpGet("[action]")]
        public ObjectResult Multiple([FromQuery]double num1, [FromQuery]double num2)
            => Ok(num1 * num2);

        [HttpGet("[action]")]
        public ObjectResult Divide([FromQuery]double num1, [FromQuery]double num2)
        {
            if (num2 == 0)
                return BadRequest("num2 shouldn't be 0!");
            return Ok(num1 / num2);
        }
    }
}