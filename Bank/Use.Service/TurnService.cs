using Pagi.Core.Models;
using Pagi.Core.Repositories;
using Pagi.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Service
{
    public class TurnService: ITurnService
    {
        private readonly ITurnRepositories _turnRepositories;
        public TurnService(ITurnRepositories turnRepositories)
        {
            _turnRepositories = turnRepositories;
        }

        public List<Turn> GetAll()
        {
            return _turnRepositories.GetList();
        }
        public Turn GetId(int id)
        {
            int index = _turnRepositories.GetList().FindIndex(c => c.Id == id);
            return _turnRepositories.GetList()[index];
        }
        public void Post(DateTime date)
        {
            _turnRepositories.GetList().Add(new Turn { Date = date });
        }
        public void Put(int id, Turn value)
        {
            int index = _turnRepositories.GetList().FindIndex(x => x.Id == id);
            _turnRepositories.GetList()[index].Date = value.Date;
        }
        public void Delete(int id)
        {
            int index = _turnRepositories.GetList().FindIndex(c => c.Id == id);
            _turnRepositories.GetList().Remove(_turnRepositories.GetList()[index]);
        }
    }
}
