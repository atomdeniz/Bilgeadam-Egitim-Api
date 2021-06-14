using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeadamEgitim.DataAccess.Migrations
{
    public partial class ornekAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ornek1",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ornek2",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ornek3",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ornek1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Ornek2",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Ornek3",
                table: "Users");
        }
    }
}
