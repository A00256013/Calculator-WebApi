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

    }
}
