using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneOtomasyonu.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Girises",
                columns: table => new
                {
                    GirisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Girises", x => x.GirisId);
                    table.ForeignKey(
                        name: "FK_Girises_Personels_PersonelID",
                        column: x => x.PersonelID,
                        principalTable: "Personels",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Girises_PersonelID",
                table: "Girises",
                column: "PersonelID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Girises");
        }
    }
}
