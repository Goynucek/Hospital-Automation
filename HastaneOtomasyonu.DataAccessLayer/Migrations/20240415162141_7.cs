using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneOtomasyonu.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class _7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pid",
                table: "Girises",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pid",
                table: "Girises");
        }
    }
}
