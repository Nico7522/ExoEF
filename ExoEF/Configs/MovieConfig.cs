using ExoEF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExoEF.Configs
{
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(c => c.MovieId);
            builder.Property(c => c.MovieId).ValueGeneratedOnAdd();
            builder.HasIndex(c => c.Title).IsUnique();
            builder.Property(c => c.Title).HasMaxLength(100).IsRequired();
            builder.HasCheckConstraint("CK_YearRelease", "YearRelease > 1975").Property(c => c.YearRelease).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Genre).HasMaxLength(100).IsRequired();
            builder.HasData(
                       new Movie
                       {
                           MovieId = 1,
                           Title = "Star Wars : Un nouvel espoir",
                           YearRelease = 1977,
                           Genre = "Science-Fiction",
                           DirectorID = 1,

                       },
                       new Movie
                       {
                           MovieId = 2,
                           Title = "Star Wars : L'empire contre-attaque",
                           YearRelease = 1980,
                           Genre = "Science-Fiction",
                           DirectorID = 1,
                       },
                       new Movie
                       {
                           MovieId = 3,
                           Title = "Star Wars : Le retour du Jedi",
                           YearRelease = 1983,
                           Genre = "Science-Fiction",
                           DirectorID = 1,

                       },
                       new Movie
                       {
                           MovieId = 4,
                           Title = "Hooligans",
                           YearRelease = 2005,
                           Genre = "Société",
                           DirectorID = 1,

                       },
                       new Movie
                       {
                           MovieId = 5,
                           Title = "LOTR - La communauté de l'anneau",
                           YearRelease = 2001,
                           Genre = "Heroic-Fantasy",
                           DirectorID = 1,

                       },
                       new Movie
                       {
                           MovieId = 6,
                           Title = "LOTR - Les deux tours",
                           YearRelease = 2002,
                           Genre = "Heroic-Fantasy",
                           DirectorID = 1,
                       },
                       new Movie
                       {
                           MovieId = 7,
                           Title = "LOTR - Le retour du roi",
                           YearRelease = 2003,
                           Genre = "Heroic-Fantasy",
                           DirectorID = 1,

                       }
                       );

        }
    }
}
