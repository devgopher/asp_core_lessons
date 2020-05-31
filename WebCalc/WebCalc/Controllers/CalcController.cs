using Microsoft.AspNetCore.Mvc;
using WebCalc.Services;

namespace WebCalc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        private readonly CalcService _service;
        private readonly CalcResults _calcResults;

        public CalcController( CalcService service, CalcResults calcResults )
        {
            _service = service;
            _calcResults = calcResults;
        }

        [HttpGet("[action]")]
        public ObjectResult Add([FromQuery]double num1, [FromQuery]double num2)
        {
            var calcResult = _service.Add(num1, num2);
            string decorated_result = _calcResults.Decorate(num1, num2, calcResult, "Add");
        
            return Ok(decorated_result);
        }

        [HttpGet("[action]")]
        public ObjectResult Subtract([FromQuery]double num1, [FromQuery]double num2)
        {
            var calcResult = _service.Subtract(num1, num2);
            string result = _calcResults.Decorate(num1, num2, calcResult, "Sub");
            return Ok(result);
        }

        [HttpGet("[action]")]
        public ObjectResult Multiply([FromQuery]double num1, [FromQuery]double num2)
        {
            var calcResult = _service.Multiply(num1, num2);
            string result = _calcResults.Decorate(num1, num2, calcResult, "Mult");
            return Ok(result);
        }

        [HttpGet("[action]")]
        public ObjectResult Divide([FromQuery]double num1, [FromQuery]double num2)
        {
            if (num2 == 0)
                return BadRequest("num2 shouldn't be 0!");

            var calcResult = _service.Divide(num1, num2);
            string result = _calcResults.Decorate(num1, num2, calcResult, "Div");
            return Ok(result);
        }
    }
}