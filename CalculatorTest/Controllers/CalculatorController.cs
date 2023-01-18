using CalculatorTest.BLL.Interfaces;
using CalculatorTest.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorTest.Controllers
{
    [Route("api/calculator")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ISimpleCalculator _simpleCalculator;

        public CalculatorController(ISimpleCalculator simpleCalculator)
        {
            _simpleCalculator = simpleCalculator;
        }



        [HttpGet("addition")]
        public IActionResult GetAddition(int start, int amount)
        {
            try
            {
                var result = _simpleCalculator.Add(start, amount);

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("subtraction")]
        public IActionResult GetSubtraction(int start, int amount)
        {
            try
            {
                var result = _simpleCalculator.Subtract(start, amount);

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
