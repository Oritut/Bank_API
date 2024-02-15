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
    public class ClientService:IClientService
    {
        private readonly IClientRepositories _clientRepositories;
        public ClientService(IClientRepositories clientRepositories)
        {
            _clientRepositories = clientRepositories;
        }
        public List<Client> GetAll()
        {
            return _clientRepositories.GetList();
        }
        public Client GetId(int id)
        {
            int index = _clientRepositories.GetList().FindIndex(c => c.Id == id);

            //if (index != -1)
            return _clientRepositories.GetList()[index];
            //else return null;
        }
        public void Post(string name)
        {
            _clientRepositories.GetList().Add(new Client { Name = name });
        }
        public void Put(int id, Client value)
        {
            int index = _clientRepositories.GetList().FindIndex(x => x.Id == id);
            _clientRepositories.GetList()[index].Name = value.Name;
        }
        public void Delete(int id)
        {
            int index = _clientRepositories.GetList().FindIndex(c => c.Id == id);
            _clientRepositories.GetList().Remove(_clientRepositories.GetList()[index]);
        }
    }
}
