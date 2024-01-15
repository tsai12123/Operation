using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class helloworld : ControllerBase
    {
        public helloworld() { }

        [HttpGet]
        public string hellowold()
        {
            return "Hellow world";
        }
    }
}
