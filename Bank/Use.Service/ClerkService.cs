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
    public class ClerkService :IClerkService
    {
        private readonly IClerkRepositories _clerkRepositories;
        public ClerkService(IClerkRepositories clerkRepositories)
        {
            _clerkRepositories = clerkRepositories;
        }
        public List<Clerk>GetAll()
        {
            return _clerkRepositories.GetList();
        }
      
        public Clerk GetId(int id)
        {
            int index = _clerkRepositories.GetList().FindIndex(c=>c.Id == id);
            return _clerkRepositories.GetList()[index];
        }
        public void Post(Clerk clerk)
        {
            _clerkRepositories.Post(clerk);
        }
        public void Put(int id, Clerk value)
        {
            int index = _clerkRepositories.GetList().FindIndex(x => x.Id == id);
            _clerkRepositories.GetList()[index].Name = value.Name;

        }
        public void Delete (int id)
        {
            int index = _clerkRepositories.GetList().FindIndex(c => c.Id == id);
            _clerkRepositories.GetList().Remove(_clerkRepositories.GetList()[index]);
        }
    }
}
