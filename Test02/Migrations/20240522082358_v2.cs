using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test02.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BesitzerId",
                table: "Auto",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Besitzer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nachname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geburtsdatum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefonnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besitzer", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auto_BesitzerId",
                table: "Auto",
                column: "BesitzerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_Besitzer_BesitzerId",
                table: "Auto",
                column: "BesitzerId",
                principalTable: "Besitzer",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto_Besitzer_BesitzerId",
                table: "Auto");

            migrationBuilder.DropTable(
                name: "Besitzer");

            migrationBuilder.DropIndex(
                name: "IX_Auto_BesitzerId",
                table: "Auto");

            migrationBuilder.DropColumn(
                name: "BesitzerId",
                table: "Auto");
        }
    }
}
