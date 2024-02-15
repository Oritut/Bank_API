using Microsoft.AspNetCore.Mvc;
using Pagi.Core.Models;
using Pagi.Core.Service;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {

            _clientService = clientService;
        }

        //private static List<Client> clients=new List<Client> { new Client { Id = 1, Name = "ariel" } };
        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _clientService.GetAll();
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            //int index= _clientService.GetAll().FindIndex(c => c.Id == id);
            //return _clientService.GetAll()[index];
            return _clientService.GetId(id);    
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] string name)
        {
           // _clientService.GetAll().Add(new Client { Id = _clientService.GetAll()[_clientService.GetAll().Count - 1].Id + 1, Name = name});
            _clientService.Post(name);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client value)
        {
          // int index= _clientService.GetAll().FindIndex(x => x.Id == id);
            //_clientService.GetAll()[index].Name = value.Name;
           _clientService.Put(id, value); 
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           // _clientService.GetAll().Remove(Get(id));
            _clientService.Delete(id);       
        }
    }
}
