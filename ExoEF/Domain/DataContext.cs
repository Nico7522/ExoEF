using ExoEF.Configs;
using ExoEF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoEF.Domain
{
    internal class DataContext : DbContext
    {

        public DbSet<Movie> Movies { get; set;}
        public DbSet<Director> Directors { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorMovie> ActorMovie { get; set; }

        private string cs = "Data Source=GOS-VDI202\\TFTIC;Initial Catalog=ExoEF;User Id=nico; Password=123;Integrated Security=True; Trust Server Certificate=Yes";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActorConfig());
            modelBuilder.ApplyConfiguration(new MovieConfig());
            modelBuilder.ApplyConfiguration(new DirectorConfig());
            modelBuilder.ApplyConfiguration(new MovieActorConfig());



        }

    }
}
