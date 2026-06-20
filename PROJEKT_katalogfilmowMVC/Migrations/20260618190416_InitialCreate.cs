using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace katalogfilmowMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tytul = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Rezyser = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Gatunek = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    RokProdukcji = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocena = table.Column<int>(type: "INTEGER", nullable: false),
                    Opis = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmy", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmy");
        }
    }
}
