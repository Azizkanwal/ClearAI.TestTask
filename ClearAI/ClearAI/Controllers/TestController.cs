using ClearAI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClearAI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // Add of two nums
        [HttpPost] 
        public ActionResult Add(AcceptedInt ints)
        {
            int sumOfTwo = (ints.Num1 + ints.Num2);             
            return Ok(sumOfTwo);
        }
    }
}
