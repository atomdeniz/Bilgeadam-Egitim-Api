using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeadamEgitim.DataAccess.Migrations
{
    public partial class hasuserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "IsDeleted", "Name", "Password", "Surname", "UpdatedDate", "Username" },
                values: new object[] { 1, new DateTime(2021, 6, 14, 12, 40, 54, 567, DateTimeKind.Local).AddTicks(309), "deneme@gmail.com", false, "Deniz", "12345", "Ozogul", new DateTime(2021, 6, 14, 12, 40, 54, 567, DateTimeKind.Local).AddTicks(319), "atomdeniz" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "IsDeleted", "Name", "Password", "Surname", "UpdatedDate", "Username" },
                values: new object[] { 2, new DateTime(2021, 6, 14, 12, 40, 54, 567, DateTimeKind.Local).AddTicks(555), "deneme2@gmail.com", false, "Mehmet", "123456", "Ahmet", new DateTime(2021, 6, 14, 12, 40, 54, 567, DateTimeKind.Local).AddTicks(565), "mehmetahmet" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
