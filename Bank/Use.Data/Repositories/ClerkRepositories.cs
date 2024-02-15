using Pagi.Core.Models;
using Pagi.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Data.Repositories
{
    public class ClerkRepositories : IClerkRepositories
    {
        private readonly DataContext _context;
  
        public ClerkRepositories(DataContext context)
        {
            _context = context;
        }

        public List<Clerk> GetList()
        {
            return _context.Clerks.ToList();
        }
        public void Post(Clerk clerk)
        {
            _context.Clerks.Add(clerk);
            _context.SaveChanges();
        }
    }
}
