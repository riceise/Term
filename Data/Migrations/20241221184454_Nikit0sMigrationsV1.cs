using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Nikit0sMigrationsV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DispensaryGroup",
                table: "DispensaryListResults");

            migrationBuilder.DropColumn(
                name: "DispensaryRegistrationStatus",
                table: "DispensaryListResults");

            migrationBuilder.DropColumn(
                name: "RegisteredMOCode",
                table: "DispensaryListResults");

            migrationBuilder.DropColumn(
                name: "RegisteredMOName",
                table: "DispensaryListResults");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "ZAP",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "InvoiceFileTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileExt = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ApiAdress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceFileTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalCompanyId = table.Column<int>(type: "int", nullable: false),
                    InvDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SankSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaySum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InvNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Version = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    InvoiceFileTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceFileTypes");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "ZAP");

            migrationBuilder.AddColumn<string>(
                name: "DispensaryGroup",
                table: "DispensaryListResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DispensaryRegistrationStatus",
                table: "DispensaryListResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RegisteredMOCode",
                table: "DispensaryListResults",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegisteredMOName",
                table: "DispensaryListResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
