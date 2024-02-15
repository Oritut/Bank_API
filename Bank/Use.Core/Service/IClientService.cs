using Pagi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Core.Service
{
    public interface IClientService
    {
        List<Client> GetAll();
        Client GetId(int id);
        void Post(string name);
        void Put(int id, Client value);
        void Delete(int id);
    }
}
