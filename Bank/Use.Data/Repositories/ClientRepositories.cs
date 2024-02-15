using Pagi.Core.Models;
using Pagi.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Data.Repositories
{
    public class ClientRepositories : IClientRepositories
    {
        private readonly DataContext _context;

        public ClientRepositories(DataContext context)
        {
            _context = context;
        }
        public List<Client> GetList()
        {
            return _context.Clients.ToList();
        }
    }
}

