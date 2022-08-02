using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_boolflix.Migrations
{
    public partial class CreateHistoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "histories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_histories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmHistory",
                columns: table => new
                {
                    FilmsListId = table.Column<int>(type: "int", nullable: false),
                    HistoriesListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmHistory", x => new { x.FilmsListId, x.HistoriesListId });
                    table.ForeignKey(
                        name: "FK_FilmHistory_films_FilmsListId",
                        column: x => x.FilmsListId,
                        principalTable: "films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmHistory_histories_HistoriesListId",
                        column: x => x.HistoriesListId,
                        principalTable: "histories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistorySerie",
                columns: table => new
                {
                    HistoriesListId = table.Column<int>(type: "int", nullable: false),
                    SeriesListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorySerie", x => new { x.HistoriesListId, x.SeriesListId });
                    table.ForeignKey(
                        name: "FK_HistorySerie_histories_HistoriesListId",
                        column: x => x.HistoriesListId,
                        principalTable: "histories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistorySerie_series_SeriesListId",
                        column: x => x.SeriesListId,
                        principalTable: "series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmHistory_HistoriesListId",
                table: "FilmHistory",
                column: "HistoriesListId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorySerie_SeriesListId",
                table: "HistorySerie",
                column: "SeriesListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmHistory");

            migrationBuilder.DropTable(
                name: "HistorySerie");

            migrationBuilder.DropTable(
                name: "histories");
        }
    }
}
