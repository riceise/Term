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
                table: "SpiskiNaDNFromMO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SpiskiNaDNFromMO_UploadFileInfId",
                table: "SpiskiNaDNFromMO",
                column: "UploadFileInfId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpiskiNaDNFromMO_UploadFileInfs_UploadFileInfId",
                table: "SpiskiNaDNFromMO",
                column: "UploadFileInfId",
                principalTable: "UploadFileInfs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpiskiNaDNFromMO_UploadFileInfs_UploadFileInfId",
                table: "SpiskiNaDNFromMO");

            migrationBuilder.DropIndex(
                name: "IX_SpiskiNaDNFromMO_UploadFileInfId",
                table: "SpiskiNaDNFromMO");

            migrationBuilder.DropColumn(
                name: "UploadFileInfId",
                table: "SpiskiNaDNFromMO");
        }
    }
}
