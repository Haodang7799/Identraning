using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdenTranning.Models;
using IdenTranning.Extentions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdenTranning.Data
{
    public class IdenDBContext : IdentityDbContext
    {
        public IdenDBContext(DbContextOptions<IdenDBContext> options ) : base(options)
        {

        }
        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

       // DbSet<Album> albums { get; set; }
        public DbSet<Music> musics { get; set; }
        public DbSet<Categories> Categories { get; set; }

      

    }
}
