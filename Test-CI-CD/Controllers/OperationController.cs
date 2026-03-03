using Microsoft.AspNetCore.Mvc;
using Test_CI_CD.Interfaces;
using Test_CI_CD.Models;

namespace Test_CI_CD.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private readonly IOperationService _operationService;

        public OperationController(IOperationService operationService)
        {
            _operationService = operationService;
        }

        [HttpPost]
        [Route("sum")]
        public async Task<IActionResult> Sum([FromBody] Operation operation)
        {
            var result = await _operationService.Sum(operation.Numbre_one, operation.Numbre_two);
            return Ok(result);
        }

        [HttpPost]
        [Route("Subtract")]
        public async Task<IActionResult> Subtract([FromBody] Operation operation)
        {
            var result = await _operationService.Subtract(operation.Numbre_one, operation.Numbre_two);
            return Ok(result);
        }

        [HttpPost]
        [Route("Multiply")]
        public async Task<IActionResult> Multiply([FromBody] Operation operation)
        {
            var result = await _operationService.Multiply(operation.Numbre_one, operation.Numbre_two);
            return Ok(result);
        }

        [HttpPost]
        [Route("Divide")]
        public async Task<IActionResult> Divide([FromBody] Operation operation)
        {
            var result = await _operationService.Divide(operation.Numbre_one, operation.Numbre_two);
            return Ok(result);
        }

    }
}
