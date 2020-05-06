using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Potlog_Mihaela_Rp.Models;

namespace Asp_Potlog_Mihaela_Rp.Data
{
    public class Asp_Potlog_Mihaela_RpContext : DbContext
    {
        public Asp_Potlog_Mihaela_RpContext (DbContextOptions<Asp_Potlog_Mihaela_RpContext> options)
            : base(options)
        {
        }
        public Asp_Potlog_Mihaela_RpContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=Asp_Potlog_Mihaela_RpContext-3b397d0d-4109-45c4-96b2-f3711c9932a9;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Asp_Potlog_Mihaela_Rp.Models.Movie> Movie { get; set; }
    }
}
