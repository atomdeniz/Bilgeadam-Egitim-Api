using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeadamEgitim.DataAccess.Migrations
{
    public partial class summarycontent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Contents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Contents");
        }
    }
}
