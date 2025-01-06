using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MonterrosaDMC1SayHello_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpGet]
        [Route("Greeting")]
        public string GreetPerson(string userName) {
            return $"Greetings, {userName}! Welcome to Level 2.";
        }

    }
}