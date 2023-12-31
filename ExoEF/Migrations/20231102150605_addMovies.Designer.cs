﻿// <auto-generated />
using ExoEF.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExoEF.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231102150605_addMovies")]
    partial class addMovies
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExoEF.Entities.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"), 1L, 1);

                    b.Property<string>("Actor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("YearRelease")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Movies");

                    b.HasCheckConstraint("CK_YearRelease", "YearRelease > 1975");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Actor = "Mark Hammil",
                            Director = "Georges Lucas",
                            Genre = "Science-Fiction",
                            Title = "Star Wars : Un nouvel espoir",
                            YearRelease = 1977
                        },
                        new
                        {
                            MovieId = 2,
                            Actor = "Mark Hammil",
                            Director = "Georges Lucas",
                            Genre = "Science-Fiction",
                            Title = "Star Wars : L'empire contre-attaque",
                            YearRelease = 1980
                        },
                        new
                        {
                            MovieId = 3,
                            Actor = "Mark Hammil",
                            Director = "Georges Lucas",
                            Genre = "Science-Fiction",
                            Title = "Star Wars : Le retour du Jedi",
                            YearRelease = 1983
                        },
                        new
                        {
                            MovieId = 4,
                            Actor = "Charlie Hunnam",
                            Director = "Lexi Alexander",
                            Genre = "Société",
                            Title = "Hooligans",
                            YearRelease = 2005
                        },
                        new
                        {
                            MovieId = 5,
                            Actor = "Elijah Wood",
                            Director = "Peter Jackson",
                            Genre = "Heroic-Fantasy",
                            Title = "LOTR - La communauté de l'anneau",
                            YearRelease = 2001
                        },
                        new
                        {
                            MovieId = 6,
                            Actor = "Elijah Wood",
                            Director = "Peter Jackson",
                            Genre = "Heroic-Fantasy",
                            Title = "LOTR - Les deux tours",
                            YearRelease = 2002
                        },
                        new
                        {
                            MovieId = 7,
                            Actor = "Elijah Wood",
                            Director = "Peter Jackson",
                            Genre = "Heroic-Fantasy",
                            Title = "LOTR - Le retour du roi",
                            YearRelease = 2003
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
