using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        [Route("Add")]
        public IActionResult Add(decimal num1, decimal num2)
        {
            decimal sum = num1 + num2;
            return Ok(sum);
        }

        [HttpGet]
        [Route("Subtract")]
        public IActionResult Subtract(decimal num1, decimal num2)
        {
            decimal difference = num1 - num2;
            return Ok(difference);
        }

        [HttpGet]
        [Route("Multiply")]
        public IActionResult Multiply(decimal num1, decimal num2)
        {
            decimal product = num1 * num2;
            return Ok(product);
        }

        [HttpGet]
        [Route("Divide")]
        public IActionResult Divide(decimal num1, decimal num2)
        {
            if (num2 != 0)
            {
                decimal quotient = num1 / num2;
                return Ok(quotient);
            }
            else
            {
                return BadRequest("Cannot divide by zero.");
            }
        }

        [HttpGet]
        [Route("Modulo")]
        public IActionResult Modulo(decimal num1, decimal num2)
        {
            if (num2 != 0)
            {
                decimal remainder = num1 % num2;
                return Ok(remainder);
            }
            else
            {
                return BadRequest("Cannot calculate modulo with zero divisor.");
            }
        }

    }
}
