using Microsoft.AspNetCore.Mvc;
using RestWithAspNet10.Services;
using RestWithAspNet10.Utils;

namespace RestWithAspNet10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        private readonly MathService _service;

        public MathController(MathService service)
        {
            _service = service;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult GetSum(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var sum = _service.Sum(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(sum);
            }
            return BadRequest("Invalid Input!");
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult GetSub(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var sub = _service.Subtraction(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(sub);
            }
            return BadRequest("Invalid Input!");
        }

        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public IActionResult GetMult(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var mult = _service.Multiplication(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(mult);
            }
            return BadRequest("Invalid Input!");
        }


        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult GetDiv(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var div = _service.Division(NumberHelper.ConvertToDecimal(firstNumber), 
                                            NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(div);
            }
            return BadRequest("Invalid Input!");
        }

        [HttpGet("Mean/{firstNumber}/{secondNumber}")]
        public IActionResult GetAver(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var Mean = _service.Mean( NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(Mean);
            }
            return BadRequest("Invalid Input!");
        }

        [HttpGet("Square/{firstNumber}")]
        public IActionResult GetSqrt(string firstNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber))
            {
                var Square = _service.SquareRoot(NumberHelper.ConvertToDecimal(firstNumber));
                return Ok(Square);
            }
            return BadRequest("Invalid Input!");
        }
    }
}
