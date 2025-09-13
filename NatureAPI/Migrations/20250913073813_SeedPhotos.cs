using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "PlaceId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "https://www.gob.mx/cms/uploads/article/main_image/27513/blog_izta_popo.jpg" },
                    { 2, 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTRN5dNWqAwUhFHJpo0EaIQdx_tsnLG-FrjaQ&s" },
                    { 3, 3, "https://imggraficos.gruporeforma.com/2023/06/2-2.jpg" },
                    { 4, 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRI_2vrL7aIS0K2cWYlFutIDKF31_RjAhifOg&s" },
                    { 5, 5, "https://i0.wp.com/foodandpleasure.com/wp-content/uploads/2024/12/cascada-de-basaseachi1.jpg?fit=1500%2C1610&ssl=1" },
                    { 6, 6, "https://offloadmedia.feverup.com/guadalajarasecreta.com/wp-content/uploads/2022/10/07033934/cerro-de-la-bufa.jpg" },
                    { 7, 7, "https://www.gob.mx/cms/uploads/article/main_image/28051/blog_PNCM.jpg" },
                    { 8, 8, "https://www.mexicodesconocido.com.mx/sites/default/files/nodes/1024/piedra-volada.jpg" },
                    { 9, 9, "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Mirador_de_la_Pe%C3%B1a.jpg/1200px-Mirador_de_la_Pe%C3%B1a.jpg" },
                    { 10, 10, "https://a.travel-assets.com/findyours-php/viewfinder/images/res70/201000/201283-Nevado-De-Toluca-National-Park.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
