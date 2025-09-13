using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlaceAmenities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlaceAmenities",
                columns: new[] { "AmenityId", "PlaceId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 3, 2 },
                    { 3, 3 },
                    { 2, 4 },
                    { 1, 5 },
                    { 3, 6 },
                    { 2, 7 },
                    { 1, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 8 });
        }
    }
}
