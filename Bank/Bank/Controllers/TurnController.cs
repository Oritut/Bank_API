using Microsoft.AspNetCore.Mvc;
using Pagi.Core.Models;
using Pagi.Core.Service;
using Pagi.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {

        private readonly ITurnService _turnService;

        public TurnController(ITurnService turnService)
        {
            _turnService = turnService;
        }

        //private static List<Turn> turns = new List<Turn> { new Turn { Id = 1, Date = DateTime.Today } };
        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Turn> Get()
        {
            return _turnService.GetAll();
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        //public ActionResult Get(int id)
        //{
        //    int index = _turnService.GetAll().FindIndex(c => c.Id == id);
        //    if(index == -1)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(_turnService.GetAll()[index]);

        //}
        public Turn Get(int id)
        {
            return _turnService.GetId(id);
        }
        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] DateTime date)
        {
            _turnService.GetAll().Add(new Turn { Id = _turnService.GetAll()[_turnService.GetAll().Count - 1].Id + 1, Date = date });
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Turn value)
        {
          //  int index = _turnService.GetAll().FindIndex(x => x.Id == id);
          //  _turnService.GetAll()[index].Date = value.Date;
          _turnService.Put(id, value);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
    //    public ActionResult Delete(int id)
    //    {
    //        int index = _turnService.GetAll().FindIndex(x => x.Id == id);
    //        if(index == -1)
    //        {
    //            return NotFound();
    //        }
    //        _turnService.GetAll().RemoveAt(index);
    //        return Ok();
    //
    //  }
  public void Delete(int id)
        {
            _turnService.Delete(id);
        }
    }

}
