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
    [Migration("20231102135040_updateMovieColumn")]
    partial class updateMovieColumn
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
                            Actor = "Schw",
                            Director = "director",
                            Genre = "Action",
                            Title = "Terminator",
                            YearRelease = 1980
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
