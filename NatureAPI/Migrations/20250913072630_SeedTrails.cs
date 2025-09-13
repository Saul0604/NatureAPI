using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedTrails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trails",
                columns: new[] { "Id", "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[,]
                {
                    { 1, "Media", 5.0, 180, true, "Sendero Volcán", "[[19.2200, -98.6570], [19.2220, -98.6630], [19.2200, -98.6570]]", 1 },
                    { 2, "Baja", 2.0, 60, false, "Mirador Principal", "[[25.1230, -99.1230], [25.1240, -99.1245], [25.1255, -99.1260]]", 1 },
                    { 3, "Baja", 1.5, 40, false, "Camino Cascada", "[[25.6750, -100.3090], [25.6765, -100.3075], [25.6780, -100.3060]]", 2 },
                    { 4, "Media", 1.2, 45, true, "Subida Mirador", "[[25.6780, -100.2340], [25.6800, -100.2330], [25.6815, -100.2320], [25.6780, -100.2340]]", 3 },
                    { 5, "Media", 3.5, 90, true, "Circuito Chipinque", "[[27.0820, -107.8670], [27.0835, -107.8650], [27.0850, -107.8630]]", 4 },
                    { 6, "Alta", 2.5, 80, false, "Caminata Basaseachic", "[[22.7710, -102.5830], [22.7715, -102.5820], [22.7720, -102.5810]]", 5 },
                    { 7, "Baja", 1.0, 30, false, "Ruta La Bufa", "[[25.4100, -100.2470], [25.4120, -100.2455], [25.4150, -100.2440], [25.4100, -100.2470]]", 6 },
                    { 8, "Alta", 6.0, 200, true, "Sendero Monterrey", "[[27.0370, -98.6570], [27.0385, -98.6555], [27.0400, -98.6540]]", 7 },
                    { 9, "Media", 3.0, 100, false, "Camino Piedra Volada", "[[20.6670, -100.1230], [20.6685, -100.1215], [20.6700, -100.1200]]", 8 },
                    { 10, "Media", 1.8, 50, true, "Subida Peña", "[[19.1180, -99.7670], [19.1200, -99.7650], [19.1220, -99.7630], [19.1180, -99.7670]]", 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
