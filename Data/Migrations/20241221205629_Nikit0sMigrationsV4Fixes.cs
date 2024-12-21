using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Nikit0sMigrationsV4Fixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentMOCode",
                table: "DispensaryListResults");

            migrationBuilder.DropColumn(
                name: "AttachmentMOName",
                table: "DispensaryListResults");

            migrationBuilder.DropColumn(
                name: "Organization",
                table: "DispensaryListResults");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttachmentMOCode",
                table: "DispensaryListResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AttachmentMOName",
                table: "DispensaryListResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Organization",
                table: "DispensaryListResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
