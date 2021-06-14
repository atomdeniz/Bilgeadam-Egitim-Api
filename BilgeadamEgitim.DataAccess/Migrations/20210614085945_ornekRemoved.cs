using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeadamEgitim.DataAccess.Migrations
{
    public partial class ornekRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ornek1",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ornek2",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ornek3",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
