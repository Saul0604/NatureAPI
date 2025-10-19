using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePhotoUrls2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "https://escapadas.mexicodesconocido.com.mx/wp-content/uploads/2020/10/Cascada-Cola-de-Caballo-XL-scaled.jpeg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "https://www.zonaturistica.com/viajecito2/wp-content/uploads/2020/12/g1-cola-de-caballo-santiago.jpg");
        }
    }
}
