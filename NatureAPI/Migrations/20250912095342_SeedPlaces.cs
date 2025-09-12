using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Accessible", "Category", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[,]
                {
                    { 1, true, "Parque", new DateTime(2025, 9, 12, 3, 52, 0, 0, DateTimeKind.Unspecified), "Parque con senderos y miradores", 3900, 50.0, 19.219999999999999, -98.656999999999996, "Parque Nacional Iztaccíhuatl", "08:00-18:00" },
                    { 2, true, "Cascada", new DateTime(2025, 9, 12, 3, 52, 0, 0, DateTimeKind.Unspecified), "Cascada famosa en Nuevo León", 50, 0.0, 25.123000000000001, -99.123000000000005, "Cascada Cola de Caballo", "08:00-17:00" },
                    { 3, true, "Mirador", new DateTime(2025, 9, 12, 3, 52, 0, 0, DateTimeKind.Unspecified), "Mirador icónico en Monterrey", 1800, 0.0, 25.675000000000001, -100.309, "Mirador del Cerro de la Silla", "06:00-20:00" },
                    { 4, true, "Parque", new DateTime(2025, 9, 12, 3, 52, 0, 0, DateTimeKind.Unspecified), "Parque natural con senderos", 2000, 20.0, 25.678000000000001, -100.23399999999999, "Parque Ecológico Chipinque", "07:00-19:00" },
                    { 5, false, "Cascada", new DateTime(2025, 9, 12, 3, 52, 0, 0, DateTimeKind.Unspecified), "Cascada más alta de Chihuahua", 1800, 30.0, 27.082000000000001, -107.867, "Cascada de Basaseacic", "08:00-17:00" },
                    { 6, true, "Mirador", new DateTime(2025, 9, 12, 3, 52, 0, 0, DateTimeKind.Unspecified), "Mirador panorámico en Zacatecas", 2500, 10.0, 22.771000000000001, -102.583, "Mirador La Bufa", "06:00-20:00" },
                    { 7, true, "Parque", new DateTime(2025, 9, 12, 3, 52, 0, 0, DateTimeKind.Unspecified), "Parque con diversas rutas de senderismo", 2600, 40.0, 25.41, -100.247, "Parque Nacional Cumbres de Monterrey", "07:00-18:00" },
                    { 8, false, "Cascada", new DateTime(2025, 9, 12, 3, 52, 0, 0, DateTimeKind.Unspecified), "Cascada en el cañón de Chihuahua", 1700, 25.0, 27.036999999999999, -98.656999999999996, "Cascada de Piedra Volada", "08:00-17:00" },
                    { 9, true, "Mirador", new DateTime(2025, 9, 12, 3, 52, 0, 0, DateTimeKind.Unspecified), "Mirador en Bernal, Queretáro", 2100, 15.0, 20.667000000000002, -100.123, "Mirador de la Peña", "06:00-19:00" },
                    { 10, true, "Parque", new DateTime(2025, 9, 12, 3, 52, 0, 0, DateTimeKind.Unspecified), "Parque con montaña y lagunas", 4600, 50.0, 19.117999999999999, -99.766999999999996, "Parque Nacional Nevado de Toluca", "07:00-18:00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
