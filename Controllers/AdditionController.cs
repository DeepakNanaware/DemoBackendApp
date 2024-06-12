using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionController : ControllerBase
    {

        //private readonly IConfiguration _configuration;

        //public AdditionController(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}


        [HttpGet("add")]
        public IActionResult Add(int num1, int num2)
        {
            int sum = num1+ num2;
            return Ok(sum);
        }

        //[HttpGet("environment")]
        //public IActionResult GetEnvironment()
        //{
        //    var env = _configuration.GetSection("Environment").Value;
        //    Console.WriteLine("env=>",env);
        //    return Ok(env);
        //   /* string environment = _configuration?["Environment"] ?? "DefaultEnvironment"; // Handle null configuration
           
        //    return Ok(environment);*/
        //}
    }
}
