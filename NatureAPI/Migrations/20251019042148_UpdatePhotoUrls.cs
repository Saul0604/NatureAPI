using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePhotoUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "https://www.zonaturistica.com/viajecito2/wp-content/uploads/2020/12/g1-cola-de-caballo-santiago.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Url",
                value: "https://www.civitatis.com/f/mexico/monterrey/galeria/senderismo-cerro-silla4.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "https://visitmexico.com/media/usercontent/6886d984e4344-chipinque-3_gmxdot_jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Url",
                value: "https://www.gob.mx/cms/uploads/image/file/247330/Basaseachi__foto_Teresita_Lasso__18_.JPG");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Url",
                value: "https://www.zacatecastravel.com/img/lugares/miradorlabufa_grande.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Url",
                value: "https://noro.mx/wp-content/uploads/2024/08/Cascada-Piedra-Volada-renace-en-la-Sierra-Tarahumara.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Url",
                value: "https://cdn.mexicodestinos.com/lugares/nevado-de-toluca-galeria.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 8,
                column: "Url",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Cascada_Piedra_Volada.jpg/1200px-Cascada_Piedra_Volada.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Url",
                value: "https://www.mexicodesconocido.com.mx/wp-content/uploads/2019/04/nevado-de-toluca.jpg");
        }
    }
}
