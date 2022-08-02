using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_boolflix.Migrations
{
    public partial class CreateLanguagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmLanguage",
                columns: table => new
                {
                    FilmsListId = table.Column<int>(type: "int", nullable: false),
                    LanguagesListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmLanguage", x => new { x.FilmsListId, x.LanguagesListId });
                    table.ForeignKey(
                        name: "FK_FilmLanguage_films_FilmsListId",
                        column: x => x.FilmsListId,
                        principalTable: "films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmLanguage_languages_LanguagesListId",
                        column: x => x.LanguagesListId,
                        principalTable: "languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguageSerie",
                columns: table => new
                {
                    LanguagesListId = table.Column<int>(type: "int", nullable: false),
                    SeriesListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageSerie", x => new { x.LanguagesListId, x.SeriesListId });
                    table.ForeignKey(
                        name: "FK_LanguageSerie_languages_LanguagesListId",
                        column: x => x.LanguagesListId,
                        principalTable: "languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageSerie_series_SeriesListId",
                        column: x => x.SeriesListId,
                        principalTable: "series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmLanguage_LanguagesListId",
                table: "FilmLanguage",
                column: "LanguagesListId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageSerie_SeriesListId",
                table: "LanguageSerie",
                column: "SeriesListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmLanguage");

            migrationBuilder.DropTable(
                name: "LanguageSerie");

            migrationBuilder.DropTable(
                name: "languages");
        }
    }
}
