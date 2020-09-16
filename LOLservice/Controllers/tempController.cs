using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LOLservice.Controllers
{
    [ApiController]
    [Route("LOL")]
    public class tempController : ControllerBase
    {
        public tempController()
        {
        }

        [HttpGet, Route("hello/{name}")]
        public string SayHello(string name)
        {
            return $"Hello, {name}";
        }
    }
}
