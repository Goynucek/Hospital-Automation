using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneOtomasyonu.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Teshis",
                table: "Hastas");

            migrationBuilder.AddColumn<string>(
                name: "Teshis",
                table: "Muayanes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Teshis",
                table: "Muayanes");

            migrationBuilder.AddColumn<string>(
                name: "Teshis",
                table: "Hastas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
