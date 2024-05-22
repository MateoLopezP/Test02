using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test02.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Betrag",
                table: "Auto",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<decimal>(
                name: "Preis",
                table: "Auto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Betrag",
                table: "Auto");

            migrationBuilder.DropColumn(
                name: "Preis",
                table: "Auto");
        }
    }
}
