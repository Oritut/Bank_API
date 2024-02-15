using Microsoft.AspNetCore.Mvc;
using Pagi.Core.Models;
using Pagi.Core.Service;
using Pagi.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClerkController : ControllerBase
    {

        private readonly IClerkService _clerkService;

        public ClerkController(IClerkService clerkService)
        {
            _clerkService = clerkService;
        }

        //private static List<Clerk> clerks = new List<Clerk> { new Clerk { Id = 1, Name = "avi" } };
        // GET: api/<ClerkController>
        [HttpGet]
        public IEnumerable<Clerk> Get()
        {
            return _clerkService.GetAll();
        }

        // GET api/<ClerkController>/5
        [HttpGet("{id}")]
        public Clerk Get(int id)
        {
          
            return _clerkService.GetId(id);
        }

        // POST api/<ClerkController>
        [HttpPost]
        public void Post([FromBody] Clerk clerk)
        {
            _clerkService.Post(clerk);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Clerk value)
        {
            
            _clerkService.Put(id, value);   

        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _clerkService.Delete(id);
        }
    }
}
