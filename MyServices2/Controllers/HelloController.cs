using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyServices2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // GET: api/<HelloController>
        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "erick", "budi" };
        }

        // GET api/<HelloController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

      
    }
}
