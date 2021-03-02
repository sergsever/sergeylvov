using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sergeylvov.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "articles",
                columns: new[] { "Id", "Created", "Text", "Title" },
                values: new object[] { 1, new DateTime(2021, 3, 2, 16, 4, 24, 63, DateTimeKind.Local).AddTicks(3888), "<h1>asp.net</h1>", "ASP" });

            migrationBuilder.InsertData(
                table: "articles",
                columns: new[] { "Id", "Created", "Text", "Title" },
                values: new object[] { 2, new DateTime(2021, 3, 2, 16, 4, 24, 65, DateTimeKind.Local).AddTicks(9893), "<h1>Entity framework</h1>", "databases" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "articles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
