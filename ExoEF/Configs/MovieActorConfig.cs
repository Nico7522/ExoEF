using ExoEF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoEF.Configs
{
    public class MovieActorConfig : IEntityTypeConfiguration<ActorMovie>
    {
        public void Configure(EntityTypeBuilder<ActorMovie> builder)
        {
            builder.HasKey(am => new { am.ActorId, am.MovieId });
            builder.HasOne(a => a.Actor).WithMany(m => m.Movies).HasForeignKey(a => a.ActorId);
            builder.HasOne(m => m.Movie).WithMany(a => a.Actors).HasForeignKey(a => a.MovieId);
            builder.HasData(
            new ActorMovie { ActorId = 1, MovieId = 1 }, 
            new ActorMovie { ActorId = 2, MovieId = 2 },  
            new ActorMovie { ActorId = 3, MovieId = 3 },  
            new ActorMovie { ActorId = 5, MovieId = 4 }, 
            new ActorMovie { ActorId = 6, MovieId = 5 },  
            new ActorMovie { ActorId = 7, MovieId = 6 },  
            new ActorMovie { ActorId = 8, MovieId = 7 },
            new ActorMovie { ActorId = 9, MovieId = 7 }
            );
        }
    }
}
