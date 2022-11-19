using Ank9ServerApiTekrar.Model.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9ServerApiTekrar.Model.Data
{
    public class ServerApiContext :DbContext
    {
        public ServerApiContext(DbContextOptions<ServerApiContext> options):base(options)
        {

        }
        public DbSet<Kisi> Kisiler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KisiConfiguration());
        }
    }
}
