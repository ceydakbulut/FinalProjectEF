using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjeAppSube1.Migrations
{
    /// <inheritdoc />
    public partial class SinifAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifAd", "SinifKontenjan" },
                values: new object[] { "1", "5" });

            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifAd", "SinifKontenjan" },
                values: new object[] { "2", "5" });

            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifAd", "SinifKontenjan" },
                values: new object[] { "3", "5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
