using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration_v9addTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DispensaryListResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpiskiNaDDFromMOId = table.Column<int>(type: "int", nullable: false),
                    SourceMOCode = table.Column<int>(type: "int", nullable: false),
                    SourceMOName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Snils = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    AttachmentMOCode = table.Column<int>(type: "int", nullable: true),
                    AttachmentMOName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DispensaryRegistrationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredMOCode = table.Column<int>(type: "int", nullable: true),
                    RegisteredMOName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DispensaryGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessingResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateLastDD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProcessingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispensaryListResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpiskiNaDDFromMOId",
                        column: x => x.SpiskiNaDDFromMOId,
                        principalTable: "SpiskiNaDDFromMO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZAP",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZAPNumber = table.Column<int>(type: "int", nullable: false),
                    UploadFileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDN = table.Column<DateOnly>(type: "date", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZAP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZAP_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DispensaryObservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    MedProfileId = table.Column<int>(type: "int", nullable: false),
                    MedProfileDictionaryId = table.Column<int>(type: "int", nullable: true),
                    LpuType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiagnosisCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiagnosisId = table.Column<int>(type: "int", nullable: true),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZAPId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispensaryObservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DispensaryObservation_Diagnosis_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnosis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DispensaryObservation_MedProfileDictionary_MedProfileDictionaryId",
                        column: x => x.MedProfileDictionaryId,
                        principalTable: "MedProfileDictionary",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DispensaryObservation_ZAP_ZAPId",
                        column: x => x.ZAPId,
                        principalTable: "ZAP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DispensaryListResults_SpiskiNaDDFromMOId",
                table: "DispensaryListResults",
                column: "SpiskiNaDDFromMOId");

            migrationBuilder.CreateIndex(
                name: "IX_DispensaryObservation_DiagnosisId",
                table: "DispensaryObservation",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_DispensaryObservation_MedProfileDictionaryId",
                table: "DispensaryObservation",
                column: "MedProfileDictionaryId");

            migrationBuilder.CreateIndex(
                name: "IX_DispensaryObservation_ZAPId",
                table: "DispensaryObservation",
                column: "ZAPId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAP_PersonId",
                table: "ZAP",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DispensaryListResults");

            migrationBuilder.DropTable(
                name: "DispensaryObservation");

            migrationBuilder.DropTable(
                name: "ZAP");
        }
    }
}
