﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharp_boolflix;

#nullable disable

namespace csharp_boolflix.Migrations
{
    [DbContext(typeof(BoolflixDbContext))]
    partial class BoolflixDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("csharp_boolflix.Models.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("SeasonId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.ToTable("episodes");
                });

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

            modelBuilder.Entity("csharp_boolflix.Models.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("histories");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("languages");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("SerieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SerieId");

                    b.ToTable("seasons");
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

            modelBuilder.Entity("FilmHistory", b =>
                {
                    b.Property<int>("FilmsListId")
                        .HasColumnType("int");

                    b.Property<int>("HistoriesListId")
                        .HasColumnType("int");

                    b.HasKey("FilmsListId", "HistoriesListId");

                    b.HasIndex("HistoriesListId");

                    b.ToTable("FilmHistory");
                });

            modelBuilder.Entity("FilmLanguage", b =>
                {
                    b.Property<int>("FilmsListId")
                        .HasColumnType("int");

                    b.Property<int>("LanguagesListId")
                        .HasColumnType("int");

                    b.HasKey("FilmsListId", "LanguagesListId");

                    b.HasIndex("LanguagesListId");

                    b.ToTable("FilmLanguage");
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

            modelBuilder.Entity("HistorySerie", b =>
                {
                    b.Property<int>("HistoriesListId")
                        .HasColumnType("int");

                    b.Property<int>("SeriesListId")
                        .HasColumnType("int");

                    b.HasKey("HistoriesListId", "SeriesListId");

                    b.HasIndex("SeriesListId");

                    b.ToTable("HistorySerie");
                });

            modelBuilder.Entity("LanguageSerie", b =>
                {
                    b.Property<int>("LanguagesListId")
                        .HasColumnType("int");

                    b.Property<int>("SeriesListId")
                        .HasColumnType("int");

                    b.HasKey("LanguagesListId", "SeriesListId");

                    b.HasIndex("SeriesListId");

                    b.ToTable("LanguageSerie");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Episode", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Season", "Season")
                        .WithMany("EpisodesList")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Season");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Season", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Serie", "Serie")
                        .WithMany()
                        .HasForeignKey("SerieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Serie");
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

            modelBuilder.Entity("FilmHistory", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmsListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Models.History", null)
                        .WithMany()
                        .HasForeignKey("HistoriesListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FilmLanguage", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmsListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Models.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesListId")
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

            modelBuilder.Entity("HistorySerie", b =>
                {
                    b.HasOne("csharp_boolflix.Models.History", null)
                        .WithMany()
                        .HasForeignKey("HistoriesListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Models.Serie", null)
                        .WithMany()
                        .HasForeignKey("SeriesListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LanguageSerie", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Models.Serie", null)
                        .WithMany()
                        .HasForeignKey("SeriesListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("csharp_boolflix.Models.Season", b =>
                {
                    b.Navigation("EpisodesList");
                });
#pragma warning restore 612, 618
        }
    }
}
