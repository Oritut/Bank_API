using Pagi.Core.Models;
using Pagi.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Data.Repositories
{
    public class TurnRepositories: ITurnRepositories
    {
        private readonly DataContext _context;

        public TurnRepositories(DataContext context)
        {
            _context = context;
        }
        public List<Turn> GetList()
        {
            return _context.Turns.ToList();
        }
    }
}
