using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneOtomasyonu.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hastas",
                columns: table => new
                {
                    HastaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastaAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastaSoyadı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastaTCNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KanGrubu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hastalık = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teshis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastas", x => x.HastaID);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelSoyadı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KlinikID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelID);
                });

            migrationBuilder.CreateTable(
                name: "Polikliniks",
                columns: table => new
                {
                    PoliklinikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoliklinikAdı = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polikliniks", x => x.PoliklinikID);
                });

            migrationBuilder.CreateTable(
                name: "Kliniks",
                columns: table => new
                {
                    KlinikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlinikAdı = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: false),
                    PoliklinikID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kliniks", x => x.KlinikID);
                    table.ForeignKey(
                        name: "FK_Kliniks_Polikliniks_PoliklinikID",
                        column: x => x.PoliklinikID,
                        principalTable: "Polikliniks",
                        principalColumn: "PoliklinikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Muayanes",
                columns: table => new
                {
                    MuayaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MuayaneZamanı = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HastaID = table.Column<int>(type: "int", nullable: false),
                    KlinikID = table.Column<int>(type: "int", nullable: false),
                    PoliklinikID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muayanes", x => x.MuayaneId);
                    table.ForeignKey(
                        name: "FK_Muayanes_Hastas_HastaID",
                        column: x => x.HastaID,
                        principalTable: "Hastas",
                        principalColumn: "HastaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Muayanes_Kliniks_KlinikID",
                        column: x => x.KlinikID,
                        principalTable: "Kliniks",
                        principalColumn: "KlinikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kliniks_PoliklinikID",
                table: "Kliniks",
                column: "PoliklinikID");

            migrationBuilder.CreateIndex(
                name: "IX_Muayanes_HastaID",
                table: "Muayanes",
                column: "HastaID");

            migrationBuilder.CreateIndex(
                name: "IX_Muayanes_KlinikID",
                table: "Muayanes",
                column: "KlinikID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Muayanes");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Hastas");

            migrationBuilder.DropTable(
                name: "Kliniks");

            migrationBuilder.DropTable(
                name: "Polikliniks");
        }
    }
}
