using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedNaturePlacesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Centro de Visitantes");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Url",
                value: "https://www.gob.mx/cms/uploads/article/main_image/27513/blog_izta_popo.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "https://nuevoleon.travel/wp-content/uploads/2023/05/Cola-de-Caballo-e1685557699991.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Url",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Cerro_de_la_Silla_desde_Chipinque.jpg/1200px-Cerro_de_la_Silla_desde_Chipinque.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "https://www.visitmexico.com/sites/default/files/2019-12/Parque%20Ecol%C3%B3gico%20Chipinque%2C%20Nuevo%20Le%C3%B3n.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Url",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Basaseachic_Falls.jpg/1200px-Basaseachic_Falls.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Url",
                value: "https://www.zacatecastravel.com/img/atractivo/1.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Url",
                value: "https://www.gob.mx/cms/uploads/article/main_image/28051/blog_PNCM.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Url",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Cascada_Piedra_Volada.jpg/1200px-Cascada_Piedra_Volada.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9,
                column: "Url",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Mirador_de_la_Pe%C3%B1a.jpg/1200px-Mirador_de_la_Pe%C3%B1a.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Url",
                value: "https://www.mexicodesconocido.com.mx/wp-content/uploads/2019/04/nevado-de-toluca.jpg");

            migrationBuilder.InsertData(
                table: "PlaceAmenities",
                columns: new[] { "AmenityId", "PlaceId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 10, 1 },
                    { 2, 2 },
                    { 4, 2 },
                    { 8, 2 },
                    { 6, 3 },
                    { 1, 4 },
                    { 3, 4 },
                    { 6, 4 },
                    { 8, 4 },
                    { 2, 5 },
                    { 3, 5 },
                    { 5, 5 },
                    { 8, 6 },
                    { 1, 7 },
                    { 5, 7 },
                    { 6, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 8, 9 },
                    { 2, 10 },
                    { 3, 10 },
                    { 10, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), "Área natural protegida que rodea los volcanes Popocatépetl e Iztaccíhuatl, segunda y tercera montañas más altas de México. Cuenta con bosques de coníferas, praderas alpinas y senderos de alta montaña.", 3600, 45.0, 19.179099999999998, -98.627700000000004, "Parque Nacional Iztaccíhuatl-Popocatépetl", "07:00-16:00" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), "Impresionante cascada de 25 metros de altura ubicada en el Parque Ecológico Cola de Caballo. El agua cae formando una silueta que asemeja la cola de un caballo.", 620, 50.0, 25.4665, -100.1365, "Cascada Cola de Caballo", "09:00-17:00" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), "Icónico cerro de Monterrey con forma de silla de montar. El mirador ofrece vistas panorámicas de toda el área metropolitana. Incluye antiguas instalaciones del teleférico.", 1820, 25.630299999999998, -100.2347, "Mirador del Cerro de la Silla", "06:00-18:00" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), "Reserva natural privada en la Sierra Madre Oriental con 1,791 hectáreas de bosque. Ofrece más de 60 km de senderos señalizados, miradores y áreas de picnic.", 2100, 90.0, 25.6187, -100.36279999999999, "Parque Ecológico Chipinque", "05:30-19:30" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name" },
                values: new object[] { new DateTime(2025, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), "La cascada permanente más alta de México con 246 metros de caída libre. Ubicada en la Sierra Madre Occidental, rodeada de bosques de pino y encino.", 1900, 35.0, 28.191700000000001, -108.2153, "Cascada de Basaseachi" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), "Emblemático cerro de Zacatecas a 2,610 metros sobre el nivel del mar. Sitio histórico de la Toma de Zacatecas y patrimonio de la UNESCO. Ofrece vistas panorámicas de 360 grados.", 2610, 0.0, 22.778700000000001, -102.568, "Mirador Cerro de la Bufa", "09:00-18:00" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), "Extenso parque nacional en la Sierra Madre Oriental que abarca 177,395 hectáreas. Incluye cañones profundos, cascadas y rica biodiversidad.", 2240, 0.0, 25.583300000000001, -100.2167, "Parque Nacional Cumbres de Monterrey", "24 horas" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Accessible", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name" },
                values: new object[] { false, new DateTime(2025, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), "La cascada más alta de México con 453 metros de caída libre. Ubicada en el mismo parque nacional que Basaseachi, solo lleva agua en temporada de lluvias.", 1850, 35.0, 28.175000000000001, -108.20829999999999, "Cascada de Piedra Volada" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), "Mirador junto al tercer monolito más grande del mundo. Ubicado en el Pueblo Mágico de Bernal, Querétaro, ofrece vistas espectaculares del valle.", 2500, 20.744700000000002, -99.944400000000002, "Mirador La Peña de Bernal", "06:00-19:00" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), "Parque nacional que rodea el volcán Nevado de Toluca (4,680 msnm). Cuenta con dos lagunas cratéricas: Laguna del Sol y Laguna de la Luna.", 4200, 65.0, 19.108499999999999, -99.757300000000001, "Parque Nacional Nevado de Toluca", "06:00-17:00" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path" },
                values: new object[] { "Alta", 8.5, 240, false, "Sendero Paso de Cortés", "[[19.1791, -98.6277], [19.1850, -98.6200], [19.1900, -98.6150]]" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "Name", "Path", "PlaceId" },
                values: new object[] { "Media", 3.5, 90, "Mirador La Joya", "[[19.1750, -98.6300], [19.1780, -98.6250], [19.1800, -98.6220]]", 1 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[] { "Baja", 0.59999999999999998, 30, false, "Sendero a la Cascada", "[[25.4700, -100.1400], [25.4680, -100.1380], [25.4665, -100.1365]]", 2 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[] { 4.2999999999999998, 150, false, "Ascenso Pico Antena", "[[25.6200, -100.2400], [25.6250, -100.2370], [25.6303, -100.2347]]", 3 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[] { "Media", 5.7999999999999998, 120, true, "Sendero del Coatí", "[[25.6150, -100.3650], [25.6200, -100.3600], [25.6250, -100.3580], [25.6150, -100.3650]]", 4 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "Name", "Path", "PlaceId" },
                values: new object[] { "Alta", 2.0, 90, "Descenso a la Base de la Cascada", "[[28.1950, -108.2180], [28.1930, -108.2165], [28.1917, -108.2153]]", 5 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[] { 2.5, 60, false, "Ruta Histórica La Bufa", "[[22.7720, -102.5720], [22.7750, -102.5700], [22.7787, -102.5680]]", 6 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DistanceKm", "EstimatedTimeMinutes", "Name", "Path", "PlaceId" },
                values: new object[] { 4.2000000000000002, 110, "Sendero Cañón de la Huasteca", "[[25.5900, -100.2200], [25.5850, -100.2150], [25.5800, -100.2100]]", 7 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[] { "Alta", 3.7999999999999998, 140, false, "Mirador Piedra Volada", "[[28.1800, -108.2120], [28.1770, -108.2100], [28.1750, -108.2083]]", 8 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[] { "Media", 1.5, 90, false, "Ascenso a la Peña", "[[20.7400, -99.9480], [20.7420, -99.9460], [20.7447, -99.9444]]", 9 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenities",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Wi-Fi");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Url",
                value: "https://example.com/sierra_organos.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "https://example.com/cascada_tamul.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Url",
                value: "https://example.com/mirador_taxco.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "https://example.com/lagunas_montebello.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Url",
                value: "https://example.com/piedra_volada.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Url",
                value: "https://example.com/cerro_campana.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Url",
                value: "https://example.com/lagunas_zempoala.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Url",
                value: "https://example.com/el_chiflon.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9,
                column: "Url",
                value: "https://example.com/cerro_silla.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Url",
                value: "https://example.com/cabo_pulmo.jpg");

            migrationBuilder.InsertData(
                table: "PlaceAmenities",
                columns: new[] { "AmenityId", "PlaceId" },
                values: new object[,]
                {
                    { 3, 2 },
                    { 1, 5 },
                    { 2, 7 },
                    { 1, 8 }
                });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(2085), "Formaciones rocosas únicas en Zacatecas", 2300, 40.0, 24.244, -104.47, "Parque Nacional Sierra de Órganos", "08:00-18:00" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7765), "Cascada impresionante en San Luis Potosí", 200, 20.0, 21.48, -99.200000000000003, "Cascada de Tamul", "07:00-17:00" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7773), "Vista panorámica de la ciudad de plata", 1800, 18.556000000000001, -99.605000000000004, "Mirador de Taxco", "06:00-20:00" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7774), "Lagos de agua cristalina en Chiapas", 1500, 30.0, 16.033000000000001, -91.549999999999997, "Parque Nacional Lagunas de Montebello", "08:00-18:00" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7776), "Cascada en Chihuahua rodeada de cañones", 1700, 25.0, 28.143000000000001, -108.23, "Cascada de Piedra Volada" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7777), "Vista de la ciudad de Guaymas", 600, 10.0, 27.917999999999999, -110.88800000000001, "Mirador del Cerro de la Campana", "06:00-20:00" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7779), "Lagos rodeados de bosque", 2800, 35.0, 19.100000000000001, -99.299999999999997, "Parque Nacional Lagunas de Zempoala", "07:00-18:00" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Accessible", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name" },
                values: new object[] { true, new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7780), "Cascada espectacular en Chiapas", 500, 25.0, 16.864999999999998, -92.016000000000005, "Cascada El Chiflón" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7781), "Símbolo de Monterrey con vistas panorámicas", 1800, 25.893000000000001, -100.79000000000001, "Mirador del Cerro de la Silla", "06:00-20:00" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 21, 23, 411, DateTimeKind.Local).AddTicks(7794), "Arrecife de coral en Baja California Sur", 0, 50.0, 23.495000000000001, -109.429, "Parque Nacional Cabo Pulmo", "07:00-18:00" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path" },
                values: new object[] { "Media", 4.0, 120, true, "Sendero Principal", "[[24.244, -104.470],[24.245, -104.472],[24.246, -104.468]]" });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "Name", "Path", "PlaceId" },
                values: new object[] { "Baja", 2.0, 60, "Camino a la Cascada", "[[21.480, -99.200],[21.481, -99.202],[21.482, -99.201]]", 2 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[] { "Media", 1.2, 40, true, "Subida al Mirador", "[[18.556, -99.605],[18.557, -99.606],[18.558, -99.604]]", 3 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[] { 3.5, 90, true, "Circuito de las Lagunas", "[[16.033, -91.550],[16.034, -91.552],[16.035, -91.551]]", 4 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[] { "Alta", 2.5, 80, false, "Caminata Piedra Volada", "[[28.143, -108.230],[28.144, -108.231],[28.145, -108.229]]", 5 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "Name", "Path", "PlaceId" },
                values: new object[] { "Baja", 1.0, 30, "Ruta Mirador Campana", "[[27.918, -110.888],[27.919, -110.889],[27.920, -110.887]]", 6 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[] { 2.7999999999999998, 70, true, "Sendero Lagos", "[[19.100, -99.300],[19.101, -99.301],[19.102, -99.302]]", 7 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DistanceKm", "EstimatedTimeMinutes", "Name", "Path", "PlaceId" },
                values: new object[] { 3.2000000000000002, 80, "Camino El Chiflón", "[[16.865, -92.016],[16.866, -92.017],[16.867, -92.018]]", 8 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[] { "Media", 1.5, 50, true, "Subida Cerro Silla", "[[25.893, -100.790],[25.894, -100.791],[25.895, -100.792]]", 9 });

            migrationBuilder.UpdateData(
                table: "Trails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[] { "Baja", 2.0, 60, true, "Recorrido Arrecife", "[[23.495, -109.429],[23.496, -109.430],[23.497, -109.431]]", 10 });
        }
    }
}
