using Pagi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Core.Service
{
    public interface ITurnService
    {
        List<Turn> GetAll();
        Turn GetId(int id);
       // void Post(i)
        void Put(int id, Turn value);
        void Delete(int id);
    }
}
