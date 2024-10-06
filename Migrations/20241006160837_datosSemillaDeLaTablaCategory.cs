using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace techstore.Migrations
{
    /// <inheritdoc />
    public partial class datosSemillaDeLaTablaCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Equipos de escritorio, laptops, monitores, etc.", "Computadoras y Portátiles" },
                    { 2, "Smartphones, tablets, accesorios para móviles.", "Teléfonos y Tablets" },
                    { 3, "Teclados, ratones, webcams, auriculares, y más.", "Accesorios para Computadoras" },
                    { 4, "Tarjetas gráficas, discos duros, fuentes de poder, procesadores.", "Componentes de Hardware" },
                    { 5, "Discos duros externos, SSDs, memorias USB, tarjetas de memoria.", "Almacenamiento y Memoria" },
                    { 6, "Routers, switches, cables, adaptadores Wi-Fi.", "Redes y Conectividad" },
                    { 7, "Cámaras, drones, consolas de videojuegos.", "Electrónica de Consumo" },
                    { 8, "Sistemas operativos, antivirus, licencias de software.", "Software y Licencias" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 8);
        }
    }
}
