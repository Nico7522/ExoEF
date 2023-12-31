﻿// <auto-generated />
using ExoEF.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExoEF.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExoEF.Entities.Actor", b =>
                {
                    b.Property<int>("personId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("personId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("personId");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            personId = 1,
                            FirstName = "Arnold",
                            LastName = "Schwarzenegger"
                        },
                        new
                        {
                            personId = 2,
                            FirstName = "Kate",
                            LastName = "Winslet"
                        },
                        new
                        {
                            personId = 3,
                            FirstName = "Leonardo",
                            LastName = "DiCaprio"
                        },
                        new
                        {
                            personId = 4,
                            FirstName = "Meryl",
                            LastName = "Streep"
                        },
                        new
                        {
                            personId = 5,
                            FirstName = "Johnny",
                            LastName = "Depp"
                        },
                        new
                        {
                            personId = 6,
                            FirstName = "Angelina",
                            LastName = "Jolie"
                        },
                        new
                        {
                            personId = 7,
                            FirstName = "Brad",
                            LastName = "Pitt"
                        },
                        new
                        {
                            personId = 8,
                            FirstName = "Tom",
                            LastName = "Cruise"
                        },
                        new
                        {
                            personId = 9,
                            FirstName = "Natalie",
                            LastName = "Portman"
                        },
                        new
                        {
                            personId = 10,
                            FirstName = "Tom",
                            LastName = "Hanks"
                        });
                });

            modelBuilder.Entity("ExoEF.Entities.ActorMovie", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("ActorMovie");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 6,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 7,
                            MovieId = 6
                        },
                        new
                        {
                            ActorId = 8,
                            MovieId = 7
                        },
                        new
                        {
                            ActorId = 9,
                            MovieId = 7
                        });
                });

            modelBuilder.Entity("ExoEF.Entities.Director", b =>
                {
                    b.Property<int>("personId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("personId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("personId");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            personId = 1,
                            FirstName = "Steven",
                            LastName = "Spielberg"
                        },
                        new
                        {
                            personId = 2,
                            FirstName = "Quentin",
                            LastName = "Tarantino"
                        },
                        new
                        {
                            personId = 3,
                            FirstName = "Christopher",
                            LastName = "Nolan"
                        },
                        new
                        {
                            personId = 4,
                            FirstName = "Kathryn",
                            LastName = "Bigelow"
                        },
                        new
                        {
                            personId = 5,
                            FirstName = "Martin",
                            LastName = "Scorsese"
                        },
                        new
                        {
                            personId = 6,
                            FirstName = "Francis Ford",
                            LastName = "Coppola"
                        },
                        new
                        {
                            personId = 7,
                            FirstName = "Paul Thomas",
                            LastName = "Anderson"
                        },
                        new
                        {
                            personId = 8,
                            FirstName = "Spike",
                            LastName = "Lee"
                        },
                        new
                        {
                            personId = 9,
                            FirstName = "Denis",
                            LastName = "Villeneuve"
                        },
                        new
                        {
                            personId = 10,
                            FirstName = "Joel and Ethan",
                            LastName = "Coen"
                        });
                });

            modelBuilder.Entity("ExoEF.Entities.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"), 1L, 1);

                    b.Property<int>("DirectorID")
                        .HasColumnType("int");

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

                    b.HasIndex("DirectorID");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Movies");

                    b.HasCheckConstraint("CK_YearRelease", "YearRelease > 1975");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            DirectorID = 1,
                            Genre = "Science-Fiction",
                            Title = "Star Wars : Un nouvel espoir",
                            YearRelease = 1977
                        },
                        new
                        {
                            MovieId = 2,
                            DirectorID = 1,
                            Genre = "Science-Fiction",
                            Title = "Star Wars : L'empire contre-attaque",
                            YearRelease = 1980
                        },
                        new
                        {
                            MovieId = 3,
                            DirectorID = 1,
                            Genre = "Science-Fiction",
                            Title = "Star Wars : Le retour du Jedi",
                            YearRelease = 1983
                        },
                        new
                        {
                            MovieId = 4,
                            DirectorID = 1,
                            Genre = "Société",
                            Title = "Hooligans",
                            YearRelease = 2005
                        },
                        new
                        {
                            MovieId = 5,
                            DirectorID = 1,
                            Genre = "Heroic-Fantasy",
                            Title = "LOTR - La communauté de l'anneau",
                            YearRelease = 2001
                        },
                        new
                        {
                            MovieId = 6,
                            DirectorID = 1,
                            Genre = "Heroic-Fantasy",
                            Title = "LOTR - Les deux tours",
                            YearRelease = 2002
                        },
                        new
                        {
                            MovieId = 7,
                            DirectorID = 1,
                            Genre = "Heroic-Fantasy",
                            Title = "LOTR - Le retour du roi",
                            YearRelease = 2003
                        });
                });

            modelBuilder.Entity("ExoEF.Entities.ActorMovie", b =>
                {
                    b.HasOne("ExoEF.Entities.Actor", "Actor")
                        .WithMany("Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExoEF.Entities.Movie", "Movie")
                        .WithMany("Actors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ExoEF.Entities.Movie", b =>
                {
                    b.HasOne("ExoEF.Entities.Director", "DirectorFilm")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DirectorFilm");
                });

            modelBuilder.Entity("ExoEF.Entities.Actor", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("ExoEF.Entities.Director", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("ExoEF.Entities.Movie", b =>
                {
                    b.Navigation("Actors");
                });
#pragma warning restore 612, 618
        }
    }
}
