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
    public class DirectorConfig : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.HasKey(p => p.personId);
            builder.Property(p => p.personId).ValueGeneratedOnAdd();
            builder.Property(p => p.LastName).HasMaxLength(100).IsRequired();
            builder.Property(p => p.FirstName).HasMaxLength(100).IsRequired();
            builder.HasMany(m => m.Movies).WithOne(d => d.DirectorFilm).IsRequired();
            builder.HasData(new Director
            {
                personId = 1,
                LastName = "Spielberg",
                FirstName = "Steven"
            });

            builder.HasData(new Director
            {
                personId = 2,
                LastName = "Tarantino",
                FirstName = "Quentin"
            });

            builder.HasData(new Director
            {
                personId = 3,
                LastName = "Nolan",
                FirstName = "Christopher"
            });

            builder.HasData(new Director
            {
                personId = 4,
                LastName = "Bigelow",
                FirstName = "Kathryn"
            });

            builder.HasData(new Director
            {
                personId = 5,
                LastName = "Scorsese",
                FirstName = "Martin"
            });

            builder.HasData(new Director
            {
                personId = 6,
                LastName = "Coppola",
                FirstName = "Francis Ford"
            });

            builder.HasData(new Director
            {
                personId = 7,
                LastName = "Anderson",
                FirstName = "Paul Thomas"
            });

            builder.HasData(new Director
            {
                personId = 8,
                LastName = "Lee",
                FirstName = "Spike"
            });

            builder.HasData(new Director
            {
                personId = 9,
                LastName = "Villeneuve",
                FirstName = "Denis"
            });

            builder.HasData(new Director
            {
                personId = 10,
                LastName = "Coen",
                FirstName = "Joel and Ethan"
            });
        }
    }
}
