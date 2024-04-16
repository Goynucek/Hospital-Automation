using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneOtomasyonu.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Girises_Personels_personelID",
                table: "Girises");

            migrationBuilder.RenameColumn(
                name: "personelID",
                table: "Girises",
                newName: "PersonelID");

            migrationBuilder.RenameIndex(
                name: "IX_Girises_personelID",
                table: "Girises",
                newName: "IX_Girises_PersonelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Girises_Personels_PersonelID",
                table: "Girises",
                column: "PersonelID",
                principalTable: "Personels",
                principalColumn: "PersonelID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Girises_Personels_PersonelID",
                table: "Girises");

            migrationBuilder.RenameColumn(
                name: "PersonelID",
                table: "Girises",
                newName: "personelID");

            migrationBuilder.RenameIndex(
                name: "IX_Girises_PersonelID",
                table: "Girises",
                newName: "IX_Girises_personelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Girises_Personels_personelID",
                table: "Girises",
                column: "personelID",
                principalTable: "Personels",
                principalColumn: "PersonelID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
