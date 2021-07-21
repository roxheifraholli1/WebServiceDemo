using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace WebServiceDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        //Method 1 : Returns web service name and list of endpoints
        // GET: /info
        [HttpGet]
        [Route("/info")]
        public IEnumerable<string> Info()
        {
            return new string[] { "Info" };
        }



        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        
    }
}
