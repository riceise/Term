using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration_v4AddKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UploadFileInfId",
                table: "SpiskiNaDDFromMO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SpiskiNaDDFromMO_UploadFileInfId",
                table: "SpiskiNaDDFromMO",
                column: "UploadFileInfId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpiskiNaDDFromMO_UploadFileInfs_UploadFileInfId",
                table: "SpiskiNaDDFromMO",
                column: "UploadFileInfId",
                principalTable: "UploadFileInfs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpiskiNaDDFromMO_UploadFileInfs_UploadFileInfId",
                table: "SpiskiNaDDFromMO");

            migrationBuilder.DropIndex(
                name: "IX_SpiskiNaDDFromMO_UploadFileInfId",
                table: "SpiskiNaDDFromMO");

            migrationBuilder.DropColumn(
                name: "UploadFileInfId",
                table: "SpiskiNaDDFromMO");
        }
    }
}
