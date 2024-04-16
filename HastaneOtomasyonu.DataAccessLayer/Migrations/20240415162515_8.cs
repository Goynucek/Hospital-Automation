using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneOtomasyonu.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class _8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pid",
                table: "Girises");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pid",
                table: "Girises",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
