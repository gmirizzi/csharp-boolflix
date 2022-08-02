using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_boolflix.Migrations
{
    public partial class ContentsGenresRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilmGenre",
                columns: table => new
                {
                    FilmsListId = table.Column<int>(type: "int", nullable: false),
                    GenresListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmGenre", x => new { x.FilmsListId, x.GenresListId });
                    table.ForeignKey(
                        name: "FK_FilmGenre_films_FilmsListId",
                        column: x => x.FilmsListId,
                        principalTable: "films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmGenre_genres_GenresListId",
                        column: x => x.GenresListId,
                        principalTable: "genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreSerie",
                columns: table => new
                {
                    GenresListId = table.Column<int>(type: "int", nullable: false),
                    SeriesListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreSerie", x => new { x.GenresListId, x.SeriesListId });
                    table.ForeignKey(
                        name: "FK_GenreSerie_genres_GenresListId",
                        column: x => x.GenresListId,
                        principalTable: "genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreSerie_series_SeriesListId",
                        column: x => x.SeriesListId,
                        principalTable: "series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmGenre_GenresListId",
                table: "FilmGenre",
                column: "GenresListId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreSerie_SeriesListId",
                table: "GenreSerie",
                column: "SeriesListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmGenre");

            migrationBuilder.DropTable(
                name: "GenreSerie");
        }
    }
}
