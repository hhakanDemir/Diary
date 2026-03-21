using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Joe!", new DateTime(2026, 3, 22, 2, 11, 20, 365, DateTimeKind.Local).AddTicks(9555), "Went Hiking" },
                    { 2, "Went shopping with Joe!", new DateTime(2026, 3, 22, 2, 11, 20, 365, DateTimeKind.Local).AddTicks(9557), "Went shopping" },
                    { 3, "Went diving with Joe!", new DateTime(2026, 3, 22, 2, 11, 20, 365, DateTimeKind.Local).AddTicks(9559), "Went diving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
