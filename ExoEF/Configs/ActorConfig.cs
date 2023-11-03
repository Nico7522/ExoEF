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
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasKey(p => p.personId);
            builder.Property(p => p.personId).ValueGeneratedOnAdd();
            builder.Property(p => p.LastName).HasMaxLength(100).IsRequired();
            builder.Property(p => p.FirstName).HasMaxLength(100).IsRequired();
            builder.HasData(new Actor
            {
                personId = 1,
                LastName = "Schwarzenegger",
                FirstName = "Arnold",
            });

            builder.HasData(new Actor
            {
                personId = 2,
                LastName = "Winslet",
                FirstName = "Kate"
            });

            builder.HasData(new Actor
            {
                personId = 3,
                LastName = "DiCaprio",
                FirstName = "Leonardo"
            });

            builder.HasData(new Actor
            {
                personId = 4,
                LastName = "Streep",
                FirstName = "Meryl"
            });

            builder.HasData(new Actor
            {
                personId = 5,
                LastName = "Depp",
                FirstName = "Johnny"
            });

            builder.HasData(new Actor
            {
                personId = 6,
                LastName = "Jolie",
                FirstName = "Angelina"
            });

            builder.HasData(new Actor
            {
                personId = 7,
                LastName = "Pitt",
                FirstName = "Brad"
            });

            builder.HasData(new Actor
            {
                personId = 8,
                LastName = "Cruise",
                FirstName = "Tom"
            });

            builder.HasData(new Actor
            {
                personId = 9,
                LastName = "Portman",
                FirstName = "Natalie"
            });

            builder.HasData(new Actor
            {
                personId = 10,
                LastName = "Hanks",
                FirstName = "Tom"
            });
        }
    }
}
