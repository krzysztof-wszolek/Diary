using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddesSeedingDataModelDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Joe", new DateTime(2025, 4, 15, 13, 34, 49, 56, DateTimeKind.Local).AddTicks(4919), "Went Hiking" },
                    { 2, "Went shoping with Joe", new DateTime(2025, 4, 15, 13, 34, 49, 56, DateTimeKind.Local).AddTicks(4925), "Went Shoping" },
                    { 3, "Went running with Joe", new DateTime(2025, 4, 15, 13, 34, 49, 56, DateTimeKind.Local).AddTicks(4928), "Went Running" }
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
