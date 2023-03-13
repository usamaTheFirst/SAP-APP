// HelloController.cs
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SAPConnection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public ActionResult<HelloResponse> Get(int number)
        {
            if (number < 1)
            {
                return BadRequest("Number must be a positive integer.");
            }

            string message = string.Concat(Enumerable.Repeat("Ello ", number)).TrimEnd();
            return new HelloResponse { Message = message };
        }
    }

    public class HelloResponse
    {
        public string Message { get; set; }
    }
}
