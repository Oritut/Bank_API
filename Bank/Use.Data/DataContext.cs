using Microsoft.EntityFrameworkCore;
using Pagi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Turn> Turns { get; set; }
        public DbSet<Clerk> Clerks { get; set; }

        //public DataContext ()
        //{
        //    Clerks = new List<Clerk>
        //    {
        //        new Clerk{ Id =1, Name ="Avi" },
        //        new Clerk{ Id =2, Name ="Dani" },
        //        new Clerk{ Id =3, Name ="Yoni" }

        //    };
        //    Clients = new List<Client>
        //    {
        //        new Client{ Id =1, Name ="Gogo" },
        //        new Client{ Id =2, Name ="Dodo" },
        //        new Client{ Id =3, Name ="Bobo" }

        //    };
        //    Turns = new List<Turn>
        //    {
        //        new Turn{ Id =1, Date =new DateTime(2023,05,01) },
        //        new Turn{ Id =2, Date =new DateTime(2023,05,08)},
        //        new Turn{ Id =3, Date =new DateTime(2023,05,15) }

        //    };
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
        }
    }
}
