using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class newPlaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    ElevationMeters = table.Column<int>(type: "int", nullable: false),
                    Accessible = table.Column<bool>(type: "bit", nullable: false),
                    EntryFee = table.Column<double>(type: "float", nullable: false),
                    OpeningHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaceAmenities",
                columns: table => new
                {
                    PlaceId = table.Column<int>(type: "int", nullable: false),
                    AmenityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceAmenities", x => new { x.PlaceId, x.AmenityId });
                    table.ForeignKey(
                        name: "FK_PlaceAmenities_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaceAmenities_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceId = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistanceKm = table.Column<double>(type: "float", nullable: false),
                    EstimatedTimeMinutes = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLoop = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trails_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Baños" },
                    { 2, "Estacionamiento" },
                    { 3, "Mirador" },
                    { 4, "Zona de Picnic" },
                    { 5, "Área de Camping" },
                    { 6, "Señalización" },
                    { 7, "Sendero Guiado" },
                    { 8, "Restaurante" },
                    { 9, "Área de Observación" },
                    { 10, "Wi-Fi" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Accessible", "Category", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[,]
                {
                    { 1, true, "Parque", new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(2085), "Formaciones rocosas únicas en Zacatecas", 2300, 40.0, 24.244, -104.47, "Parque Nacional Sierra de Órganos", "08:00-18:00" },
                    { 2, true, "Cascada", new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7765), "Cascada impresionante en San Luis Potosí", 200, 20.0, 21.48, -99.200000000000003, "Cascada de Tamul", "07:00-17:00" },
                    { 3, true, "Mirador", new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7773), "Vista panorámica de la ciudad de plata", 1800, 0.0, 18.556000000000001, -99.605000000000004, "Mirador de Taxco", "06:00-20:00" },
                    { 4, true, "Parque", new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7774), "Lagos de agua cristalina en Chiapas", 1500, 30.0, 16.033000000000001, -91.549999999999997, "Parque Nacional Lagunas de Montebello", "08:00-18:00" },
                    { 5, false, "Cascada", new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7776), "Cascada en Chihuahua rodeada de cañones", 1700, 25.0, 28.143000000000001, -108.23, "Cascada de Piedra Volada", "08:00-17:00" },
                    { 6, true, "Mirador", new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7777), "Vista de la ciudad de Guaymas", 600, 10.0, 27.917999999999999, -110.88800000000001, "Mirador del Cerro de la Campana", "06:00-20:00" },
                    { 7, true, "Parque", new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7779), "Lagos rodeados de bosque", 2800, 35.0, 19.100000000000001, -99.299999999999997, "Parque Nacional Lagunas de Zempoala", "07:00-18:00" },
                    { 8, true, "Cascada", new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7780), "Cascada espectacular en Chiapas", 500, 25.0, 16.864999999999998, -92.016000000000005, "Cascada El Chiflón", "08:00-17:00" },
                    { 9, true, "Mirador", new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7781), "Símbolo de Monterrey con vistas panorámicas", 1800, 0.0, 25.893000000000001, -100.79000000000001, "Mirador del Cerro de la Silla", "06:00-20:00" },
                    { 10, true, "Parque", new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7794), "Arrecife de coral en Baja California Sur", 0, 50.0, 23.495000000000001, -109.429, "Parque Nacional Cabo Pulmo", "07:00-18:00" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "PlaceId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "https://example.com/sierra_organos.jpg" },
                    { 2, 2, "https://example.com/cascada_tamul.jpg" },
                    { 3, 3, "https://example.com/mirador_taxco.jpg" },
                    { 4, 4, "https://example.com/lagunas_montebello.jpg" },
                    { 5, 5, "https://example.com/piedra_volada.jpg" },
                    { 6, 6, "https://example.com/cerro_campana.jpg" },
                    { 7, 7, "https://example.com/lagunas_zempoala.jpg" },
                    { 8, 8, "https://example.com/el_chiflon.jpg" },
                    { 9, 9, "https://example.com/cerro_silla.jpg" },
                    { 10, 10, "https://example.com/cabo_pulmo.jpg" }
                });

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

            migrationBuilder.InsertData(
                table: "Trails",
                columns: new[] { "Id", "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[,]
                {
                    { 1, "Media", 4.0, 120, true, "Sendero Principal", "[[24.244, -104.470],[24.245, -104.472],[24.246, -104.468]]", 1 },
                    { 2, "Baja", 2.0, 60, false, "Camino a la Cascada", "[[21.480, -99.200],[21.481, -99.202],[21.482, -99.201]]", 2 },
                    { 3, "Media", 1.2, 40, true, "Subida al Mirador", "[[18.556, -99.605],[18.557, -99.606],[18.558, -99.604]]", 3 },
                    { 4, "Media", 3.5, 90, true, "Circuito de las Lagunas", "[[16.033, -91.550],[16.034, -91.552],[16.035, -91.551]]", 4 },
                    { 5, "Alta", 2.5, 80, false, "Caminata Piedra Volada", "[[28.143, -108.230],[28.144, -108.231],[28.145, -108.229]]", 5 },
                    { 6, "Baja", 1.0, 30, false, "Ruta Mirador Campana", "[[27.918, -110.888],[27.919, -110.889],[27.920, -110.887]]", 6 },
                    { 7, "Media", 2.7999999999999998, 70, true, "Sendero Lagos", "[[19.100, -99.300],[19.101, -99.301],[19.102, -99.302]]", 7 },
                    { 8, "Media", 3.2000000000000002, 80, false, "Camino El Chiflón", "[[16.865, -92.016],[16.866, -92.017],[16.867, -92.018]]", 8 },
                    { 9, "Media", 1.5, 50, true, "Subida Cerro Silla", "[[25.893, -100.790],[25.894, -100.791],[25.895, -100.792]]", 9 },
                    { 10, "Baja", 2.0, 60, true, "Recorrido Arrecife", "[[23.495, -109.429],[23.496, -109.430],[23.497, -109.431]]", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PlaceId",
                table: "Photos",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceAmenities_AmenityId",
                table: "PlaceAmenities",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_PlaceId",
                table: "Reviews",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Trails_PlaceId",
                table: "Trails",
                column: "PlaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "PlaceAmenities");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Trails");

            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
