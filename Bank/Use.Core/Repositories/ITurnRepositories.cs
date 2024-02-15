using Pagi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Core.Repositories
{
    public interface ITurnRepositories
    {
        List<Turn> GetList();
        //*void Post(Turn turn);
    }
}
