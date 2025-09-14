using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class pruebaPlace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Accessible", "Category", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { 1, true, "Nature", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nature", 300, 40.0, 21.23, 24.420000000000002, "Nature", "7:00:00" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
