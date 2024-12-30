using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjeAppSube1.Migrations
{
    /// <inheritdoc />
    public partial class newchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Siniflar_SiniflarSinifId",
                table: "Ogrenciler");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenciler_SiniflarSinifId",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "SiniflarSinifId",
                table: "Ogrenciler");

            migrationBuilder.AddColumn<string>(
                name: "Ders",
                table: "OgrenciDersler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_SinifId",
                table: "Ogrenciler",
                column: "SinifId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Siniflar_SinifId",
                table: "Ogrenciler",
                column: "SinifId",
                principalTable: "Siniflar",
                principalColumn: "SinifId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Siniflar_SinifId",
                table: "Ogrenciler");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenciler_SinifId",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "Ders",
                table: "OgrenciDersler");

            migrationBuilder.AddColumn<int>(
                name: "SiniflarSinifId",
                table: "Ogrenciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_SiniflarSinifId",
                table: "Ogrenciler",
                column: "SiniflarSinifId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Siniflar_SiniflarSinifId",
                table: "Ogrenciler",
                column: "SiniflarSinifId",
                principalTable: "Siniflar",
                principalColumn: "SinifId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
