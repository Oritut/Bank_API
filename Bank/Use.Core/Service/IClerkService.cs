using Pagi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Core.Service
{
    public interface IClerkService
    {
        List<Clerk> GetAll();
        Clerk GetId(int id);
        void Post(Clerk clerk);
        void Put(int id, Clerk value);
        void Delete(int id);
    }
}
