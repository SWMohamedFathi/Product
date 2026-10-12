using Microsoft.AspNetCore.Mvc;

namespace Product.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult HelloWorld()
        {
            return Ok("Hello world");
        }
    }
}
