﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharp_boolflix;

#nullable disable

namespace csharp_boolflix.Migrations
{
    [DbContext(typeof(BoolflixDbContext))]
    [Migration("20220802104635_ContentsGenresRelation")]
    partial class ContentsGenresRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("csharp_boolflix.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("films");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("genres");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Serie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("series");
                });

            modelBuilder.Entity("FilmGenre", b =>
                {
                    b.Property<int>("FilmsListId")
                        .HasColumnType("int");

                    b.Property<int>("GenresListId")
                        .HasColumnType("int");

                    b.HasKey("FilmsListId", "GenresListId");

                    b.HasIndex("GenresListId");

                    b.ToTable("FilmGenre");
                });

            modelBuilder.Entity("GenreSerie", b =>
                {
                    b.Property<int>("GenresListId")
                        .HasColumnType("int");

                    b.Property<int>("SeriesListId")
                        .HasColumnType("int");

                    b.HasKey("GenresListId", "SeriesListId");

                    b.HasIndex("SeriesListId");

                    b.ToTable("GenreSerie");
                });

            modelBuilder.Entity("FilmGenre", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmsListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenreSerie", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Models.Serie", null)
                        .WithMany()
                        .HasForeignKey("SeriesListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
