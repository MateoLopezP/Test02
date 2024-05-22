using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test02.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Marke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modell = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JahrHerstellung = table.Column<int>(type: "int", nullable: false),
                    Laufleistung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Platte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypKraftstoff = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zustand = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auto");
        }
    }
}
