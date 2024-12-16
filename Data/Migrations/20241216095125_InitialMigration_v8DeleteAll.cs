using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration_v8DeleteAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Сonciliums",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "CancerMedicinalProducts",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "ConcomitantDiseases",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "ContraindicationBlocks",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "DiagnosticBlocks",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "DifficultyCoefficients",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "DispensaryReferrals",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "DocumentTypes",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "Implants",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "InsuranceCompanies");

            migrationBuilder.DropTable(
                name: "KSGKPGClassificationCriterions",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "MedicinalProducts",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "OKATOs",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "OrganizationTypes",
                schema: "LPU");

            migrationBuilder.DropTable(
                name: "Referrals",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "SanctionExperts",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "SLCaseDiagnoses",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "SLCaseSanctions",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "ConsultationPurposes",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "CancerServices",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "Contraindications",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "CancerMarkerValues",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "HistologicalExaminationResults",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "KSLPs",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "MedicalDeviceTypes",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "USLServices",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "ClassificationCriterions",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "KSGKPGs",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "CombinationTreatments",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "InjectionMethods",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "Medications",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "Units",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "DiagnosticMethods",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "DirectionTypes",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "ExpertReestrs",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "Sanctions",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "CancerCases",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "DrugTherapyCycles",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "DrugTherapyLines",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "RadiationTherapyTypes",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "SurgeryTypes",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "TreatmentTypes",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "CancerMarkers",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "HistologicalFeatures",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "MedicalServices",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "KPGs",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "KSGs",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "ExcludingExperts",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "ControlTypes",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "RefusalReasons",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "Metastasises",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "Noduses",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "ReasonAppeals",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "SLCases",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "Stages",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "Tumors",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "BedMedProfiles",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "CharacterDiseases",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "MedSpecials",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "MedicalCompanyDepartments",
                schema: "LPU");

            migrationBuilder.DropTable(
                name: "VMPMethods",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "VisitPurposes",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "ZAPMainRecords",
                schema: "zap");

            migrationBuilder.DropTable(
                name: "MedProfiles",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "MedicalCompanyUnits",
                schema: "LPU");

            migrationBuilder.DropTable(
                name: "PatientVMPModels",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "VidVMPs",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "FormPoms",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "Invoices",
                schema: "inv");

            migrationBuilder.DropTable(
                name: "Ishods",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "PaymentMethods",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "ResultDisps",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "Results",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "VidPoms",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "VidSluchs",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "InvoiceFileTypes",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "MainInvoices",
                schema: "inv");

            migrationBuilder.DropTable(
                name: "TypeDisps",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "PolicyTypes",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "UMPs",
                schema: "dict");

            migrationBuilder.DropTable(
                name: "BatchNumbers",
                schema: "dict");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diagnoses",
                schema: "dict",
                table: "Diagnoses");

            migrationBuilder.DropIndex(
                name: "IX_Diagnoses_Code",
                schema: "dict",
                table: "Diagnoses");

            migrationBuilder.RenameTable(
                name: "Diagnoses",
                schema: "dict",
                newName: "Diagnosis");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EditDate",
                table: "Diagnosis",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedUserId",
                table: "Diagnosis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Diagnosis",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Diagnosis",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Diagnosis",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "EditUserId",
                table: "Diagnosis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diagnosis",
                table: "Diagnosis",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MedProfileDictionary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedProfileDictionary", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedProfileDictionary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diagnosis",
                table: "Diagnosis");

            migrationBuilder.DropColumn(
                name: "EditUserId",
                table: "Diagnosis");

            migrationBuilder.EnsureSchema(
                name: "zap");

            migrationBuilder.EnsureSchema(
                name: "dict");

            migrationBuilder.EnsureSchema(
                name: "inv");

            migrationBuilder.RenameTable(
                name: "Diagnosis",
                newName: "Diagnoses",
                newSchema: "dict");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EditDate",
                schema: "dict",
                table: "Diagnoses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedUserId",
                schema: "dict",
                table: "Diagnoses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                schema: "dict",
                table: "Diagnoses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                schema: "dict",
                table: "Diagnoses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                schema: "dict",
                table: "Diagnoses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diagnoses",
                schema: "dict",
                table: "Diagnoses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BatchNumbers",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BedMedProfiles",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedMedProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CancerMarkers",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CancerMarkers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterDiseases",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterDiseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassificationCriterions",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassificationCriterions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CombinationTreatments",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    SchemeCode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombinationTreatments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsultationPurposes",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultationPurposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contraindications",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contraindications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ControlTypes",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosticMethods",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosticMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectionTypes",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    DocNumberFormat = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DocSerFormat = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrugTherapyCycles",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugTherapyCycles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrugTherapyLines",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugTherapyLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExcludingExperts",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcludingExperts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormPoms",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormPoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistologicalFeatures",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistologicalFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InjectionMethods",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjectionMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    INN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    KPP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    OGRN = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceFileTypes",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiAdress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    FileExt = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceFileTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCompanyUnits",
                schema: "LPU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalCompanyId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CodeMain = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    FRMOId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OldCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCompanyUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCompanyUnits_MedicalCompanies_MedicalCompanyId",
                        column: x => x.MedicalCompanyId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalDeviceTypes",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActual = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsNPA = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    RZN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalDeviceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalServices",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOut = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActual = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedProfiles",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedSpecials",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    CodeJobNSI = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    NameSpec = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedSpecials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Metastasises",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    MCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metastasises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Metastasises_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalSchema: "dict",
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Noduses",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noduses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Noduses_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalSchema: "dict",
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OKATOs",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    ChangeNumber = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DateApproval = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEffective = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    RegionCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    SectionCode = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    VillageCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    VillageCounsilCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OKATOs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationTypes",
                schema: "LPU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientVMPModels",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientVMPModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyTypes",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RadiationTherapyTypes",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadiationTherapyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReasonAppeals",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReasonAppeals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefusalReasons",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    CodePD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeTypeControl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoefNonPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CoefPenalty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefusalReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResultDisps",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultDisps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stages",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stages_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalSchema: "dict",
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurgeryTypes",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurgeryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentTypes",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tumors",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tumors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tumors_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalSchema: "dict",
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypeDisps",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    ValidResultDisp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDisps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UMPs",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UMPs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Coefficient = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    ConversionId = table.Column<int>(type: "int", nullable: false),
                    ConversionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Measurement = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    OKEICode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PrintName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UCUMCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VidPoms",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VidPoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VidVMPs",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VMPGrupNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VidVMPs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitPurposes",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitPurposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainInvoices",
                schema: "inv",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchNumberId = table.Column<int>(type: "int", nullable: false),
                    MedicalCompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InvDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PaySum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    SankSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WeekNumber = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainInvoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainInvoices_BatchNumbers_BatchNumberId",
                        column: x => x.BatchNumberId,
                        principalSchema: "dict",
                        principalTable: "BatchNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MainInvoices_MedicalCompanies_MedicalCompanyId",
                        column: x => x.MedicalCompanyId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CancerMarkerValues",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CancerMarkerId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Result = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CancerMarkerValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CancerMarkerValues_CancerMarkers_CancerMarkerId",
                        column: x => x.CancerMarkerId,
                        principalSchema: "dict",
                        principalTable: "CancerMarkers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpertReestrs",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExcludingExpertId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    BeginDateExpert = table.Column<DateTime>(type: "date", nullable: false),
                    CodeExpert = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountExamination = table.Column<int>(type: "int", nullable: false),
                    CountIncorrectConclusion = table.Column<int>(type: "int", nullable: false),
                    CountMedicalCompany = table.Column<int>(type: "int", nullable: false),
                    CountSluch = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExcludingDateExpert = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NameSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OKTMO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReestrNumberExpert = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UidExpert = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertReestrs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpertReestrs_ExcludingExperts_ExcludingExpertId",
                        column: x => x.ExcludingExpertId,
                        principalSchema: "dict",
                        principalTable: "ExcludingExperts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistologicalExaminationResults",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HistologicalFeatureId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistologicalExaminationResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistologicalExaminationResults_HistologicalFeatures_HistologicalFeatureId",
                        column: x => x.HistologicalFeatureId,
                        principalSchema: "dict",
                        principalTable: "HistologicalFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    ENP = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsuranceCompanyId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    OKATO = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Series = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Policies_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Policies_PolicyTypes_PolicyTypeId",
                        column: x => x.PolicyTypeId,
                        principalSchema: "dict",
                        principalTable: "PolicyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ishods",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UMPId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ishods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ishods_UMPs_UMPId",
                        column: x => x.UMPId,
                        principalSchema: "dict",
                        principalTable: "UMPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KPGs",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UMPId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Coefficient = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KPGs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KPGs_UMPs_UMPId",
                        column: x => x.UMPId,
                        principalSchema: "dict",
                        principalTable: "UMPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KSGs",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UMPId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Coefficient = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KSGs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KSGs_UMPs_UMPId",
                        column: x => x.UMPId,
                        principalSchema: "dict",
                        principalTable: "UMPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KSLPs",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UMPId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KSLPs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KSLPs_UMPs_UMPId",
                        column: x => x.UMPId,
                        principalSchema: "dict",
                        principalTable: "UMPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UMPId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_UMPs_UMPId",
                        column: x => x.UMPId,
                        principalSchema: "dict",
                        principalTable: "UMPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VidSluchs",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UMPId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EditUserId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsCZ = table.Column<bool>(type: "bit", nullable: false),
                    IsConsDiagn = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDisp = table.Column<bool>(type: "bit", nullable: false),
                    IsGem = table.Column<bool>(type: "bit", nullable: false),
                    IsKons = table.Column<bool>(type: "bit", nullable: false),
                    IsMob = table.Column<bool>(type: "bit", nullable: false),
                    IsObr = table.Column<bool>(type: "bit", nullable: false),
                    IsPos = table.Column<bool>(type: "bit", nullable: false),
                    IsProf = table.Column<bool>(type: "bit", nullable: false),
                    IsReab = table.Column<bool>(type: "bit", nullable: false),
                    IsTelemed = table.Column<bool>(type: "bit", nullable: false),
                    IsVMP = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VidSluchs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VidSluchs_UMPs_UMPId",
                        column: x => x.UMPId,
                        principalSchema: "dict",
                        principalTable: "UMPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCompanyDepartments",
                schema: "LPU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalCompanyId = table.Column<int>(type: "int", nullable: false),
                    MedicalCompanyUnitId = table.Column<int>(type: "int", nullable: false),
                    MedProfileId = table.Column<int>(type: "int", nullable: false),
                    UMPId = table.Column<int>(type: "int", nullable: false),
                    VidPomId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OldCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCompanyDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCompanyDepartments_MedProfiles_MedProfileId",
                        column: x => x.MedProfileId,
                        principalSchema: "dict",
                        principalTable: "MedProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalCompanyDepartments_MedicalCompanies_MedicalCompanyId",
                        column: x => x.MedicalCompanyId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalCompanyDepartments_MedicalCompanyUnits_MedicalCompanyUnitId",
                        column: x => x.MedicalCompanyUnitId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanyUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalCompanyDepartments_UMPs_UMPId",
                        column: x => x.UMPId,
                        principalSchema: "dict",
                        principalTable: "UMPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalCompanyDepartments_VidPoms_VidPomId",
                        column: x => x.VidPomId,
                        principalSchema: "dict",
                        principalTable: "VidPoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VMPMethods",
                schema: "dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientVMPModelId = table.Column<int>(type: "int", nullable: false),
                    VidVMPId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    HGR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HMODP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VMPMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VMPMethods_PatientVMPModels_PatientVMPModelId",
                        column: x => x.PatientVMPModelId,
                        principalSchema: "dict",
                        principalTable: "PatientVMPModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VMPMethods_VidVMPs_VidVMPId",
                        column: x => x.VidVMPId,
                        principalSchema: "dict",
                        principalTable: "VidVMPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                schema: "inv",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceFileTypeId = table.Column<int>(type: "int", nullable: false),
                    MainInvoiceId = table.Column<int>(type: "int", nullable: false),
                    MedicalCompanyId = table.Column<int>(type: "int", nullable: false),
                    TypeDispId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InvDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PaySum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecordsNumber = table.Column<int>(type: "int", nullable: false),
                    SankSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_InvoiceFileTypes_InvoiceFileTypeId",
                        column: x => x.InvoiceFileTypeId,
                        principalSchema: "dict",
                        principalTable: "InvoiceFileTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_MainInvoices_MainInvoiceId",
                        column: x => x.MainInvoiceId,
                        principalSchema: "inv",
                        principalTable: "MainInvoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_MedicalCompanies_MedicalCompanyId",
                        column: x => x.MedicalCompanyId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_TypeDisps_TypeDispId",
                        column: x => x.TypeDispId,
                        principalSchema: "dict",
                        principalTable: "TypeDisps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZAPMainRecords",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DirectedMOId = table.Column<int>(type: "int", nullable: false),
                    FormPomId = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    IshodId = table.Column<int>(type: "int", nullable: false),
                    MedicalCompanyId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyId = table.Column<int>(type: "int", nullable: false),
                    ResultDispId = table.Column<int>(type: "int", nullable: false),
                    ResultId = table.Column<int>(type: "int", nullable: false),
                    UMPId = table.Column<int>(type: "int", nullable: false),
                    VidPomId = table.Column<int>(type: "int", nullable: false),
                    VidSluchId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DirectedDate = table.Column<DateTime>(type: "date", nullable: false),
                    DurationHospitalization = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndTreatmentDate = table.Column<DateTime>(type: "date", nullable: false),
                    InvGroup = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEdited = table.Column<bool>(type: "bit", nullable: false),
                    IsIntrahospitalTransfer = table.Column<bool>(type: "bit", nullable: false),
                    IsMSE = table.Column<bool>(type: "bit", nullable: false),
                    IsMobileMedicalTeam = table.Column<bool>(type: "bit", nullable: false),
                    IsPay = table.Column<bool>(type: "bit", nullable: false),
                    IsRefusal = table.Column<bool>(type: "bit", nullable: false),
                    IsSpecialCase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewBorn = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    NewBornWeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    NumberCase = table.Column<int>(type: "int", nullable: false),
                    Pay = table.Column<int>(type: "int", nullable: false),
                    PaySum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SankSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartTreatmentDate = table.Column<DateTime>(type: "date", nullable: false),
                    TotalSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZAPMainRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZAPMainRecords_FormPoms_FormPomId",
                        column: x => x.FormPomId,
                        principalSchema: "dict",
                        principalTable: "FormPoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZAPMainRecords_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalSchema: "inv",
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZAPMainRecords_Ishods_IshodId",
                        column: x => x.IshodId,
                        principalSchema: "dict",
                        principalTable: "Ishods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZAPMainRecords_MedicalCompanies_DirectedMOId",
                        column: x => x.DirectedMOId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZAPMainRecords_MedicalCompanies_MedicalCompanyId",
                        column: x => x.MedicalCompanyId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZAPMainRecords_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalSchema: "dict",
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZAPMainRecords_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZAPMainRecords_Policies_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "Policies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZAPMainRecords_ResultDisps_ResultDispId",
                        column: x => x.ResultDispId,
                        principalSchema: "dict",
                        principalTable: "ResultDisps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZAPMainRecords_Results_ResultId",
                        column: x => x.ResultId,
                        principalSchema: "dict",
                        principalTable: "Results",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZAPMainRecords_UMPs_UMPId",
                        column: x => x.UMPId,
                        principalSchema: "dict",
                        principalTable: "UMPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZAPMainRecords_VidPoms_VidPomId",
                        column: x => x.VidPomId,
                        principalSchema: "dict",
                        principalTable: "VidPoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZAPMainRecords_VidSluchs_VidSluchId",
                        column: x => x.VidSluchId,
                        principalSchema: "dict",
                        principalTable: "VidSluchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sanctions",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ControlTypeId = table.Column<int>(type: "int", nullable: false),
                    RefusalReasonId = table.Column<int>(type: "int", nullable: false),
                    ZAPMainRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActDate = table.Column<DateTime>(type: "date", nullable: false),
                    ActNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SanctionId = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Source = table.Column<bool>(type: "bit", nullable: false),
                    TotalSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sanctions_ControlTypes_ControlTypeId",
                        column: x => x.ControlTypeId,
                        principalSchema: "dict",
                        principalTable: "ControlTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sanctions_RefusalReasons_RefusalReasonId",
                        column: x => x.RefusalReasonId,
                        principalSchema: "dict",
                        principalTable: "RefusalReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sanctions_ZAPMainRecords_ZAPMainRecordId",
                        column: x => x.ZAPMainRecordId,
                        principalSchema: "zap",
                        principalTable: "ZAPMainRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SLCases",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BedMedProfileId = table.Column<int>(type: "int", nullable: false),
                    CharacterDiseaseId = table.Column<int>(type: "int", nullable: false),
                    DoctorSpecialtyId = table.Column<int>(type: "int", nullable: false),
                    MedicalCompanyDepartmentId = table.Column<int>(type: "int", nullable: false),
                    MedicalCompanyUnitId = table.Column<int>(type: "int", nullable: false),
                    MedProfileId = table.Column<int>(type: "int", nullable: false),
                    VidVMPId = table.Column<int>(type: "int", nullable: false),
                    VisitPurposeId = table.Column<int>(type: "int", nullable: false),
                    VMPMethodId = table.Column<int>(type: "int", nullable: false),
                    ZapMainRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ConcomitantMedicalCareStandard = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DispensaryObservation = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DurationHospitalization = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndTreatmentDate = table.Column<DateTime>(type: "date", nullable: false),
                    IdCase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCancer = table.Column<bool>(type: "bit", nullable: false),
                    IsChildrenProfile = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsRehabilitation = table.Column<bool>(type: "bit", nullable: false),
                    MedSpecialVersion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MedicalCareStandard = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NumberHistory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PayUnits = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PlannedHospitalizationDate = table.Column<DateTime>(type: "date", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartTreatmentDate = table.Column<DateTime>(type: "date", nullable: false),
                    TicketNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TicketReceiveDate = table.Column<DateTime>(type: "date", nullable: false),
                    TotalSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransferSign = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SLCases_BedMedProfiles_BedMedProfileId",
                        column: x => x.BedMedProfileId,
                        principalSchema: "dict",
                        principalTable: "BedMedProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SLCases_CharacterDiseases_CharacterDiseaseId",
                        column: x => x.CharacterDiseaseId,
                        principalSchema: "dict",
                        principalTable: "CharacterDiseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SLCases_MedProfiles_MedProfileId",
                        column: x => x.MedProfileId,
                        principalSchema: "dict",
                        principalTable: "MedProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SLCases_MedSpecials_DoctorSpecialtyId",
                        column: x => x.DoctorSpecialtyId,
                        principalSchema: "dict",
                        principalTable: "MedSpecials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SLCases_MedicalCompanyDepartments_MedicalCompanyDepartmentId",
                        column: x => x.MedicalCompanyDepartmentId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanyDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SLCases_MedicalCompanyUnits_MedicalCompanyUnitId",
                        column: x => x.MedicalCompanyUnitId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanyUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SLCases_VMPMethods_VMPMethodId",
                        column: x => x.VMPMethodId,
                        principalSchema: "dict",
                        principalTable: "VMPMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SLCases_VidVMPs_VidVMPId",
                        column: x => x.VidVMPId,
                        principalSchema: "dict",
                        principalTable: "VidVMPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SLCases_VisitPurposes_VisitPurposeId",
                        column: x => x.VisitPurposeId,
                        principalSchema: "dict",
                        principalTable: "VisitPurposes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SLCases_ZAPMainRecords_ZapMainRecordId",
                        column: x => x.ZapMainRecordId,
                        principalSchema: "zap",
                        principalTable: "ZAPMainRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanctionExperts",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpertReestrId = table.Column<int>(type: "int", nullable: false),
                    SanctionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanctionExperts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanctionExperts_ExpertReestrs_ExpertReestrId",
                        column: x => x.ExpertReestrId,
                        principalSchema: "dict",
                        principalTable: "ExpertReestrs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanctionExperts_Sanctions_SanctionId",
                        column: x => x.SanctionId,
                        principalSchema: "zap",
                        principalTable: "Sanctions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Сonciliums",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultationPurposeId = table.Column<int>(type: "int", nullable: false),
                    SLCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Сonciliums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Сonciliums_ConsultationPurposes_ConsultationPurposeId",
                        column: x => x.ConsultationPurposeId,
                        principalSchema: "dict",
                        principalTable: "ConsultationPurposes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Сonciliums_SLCases_SLCaseId",
                        column: x => x.SLCaseId,
                        principalSchema: "zap",
                        principalTable: "SLCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CancerCases",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MetastasisId = table.Column<int>(type: "int", nullable: false),
                    NodusId = table.Column<int>(type: "int", nullable: false),
                    ReasonAppealId = table.Column<int>(type: "int", nullable: false),
                    SLCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    TumorId = table.Column<int>(type: "int", nullable: false),
                    BodyArea = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    FractionsNumber = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsMetastasis = table.Column<bool>(type: "bit", nullable: false),
                    TotalFocalDose = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(4,1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CancerCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CancerCases_Metastasises_MetastasisId",
                        column: x => x.MetastasisId,
                        principalSchema: "dict",
                        principalTable: "Metastasises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CancerCases_Noduses_NodusId",
                        column: x => x.NodusId,
                        principalSchema: "dict",
                        principalTable: "Noduses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CancerCases_ReasonAppeals_ReasonAppealId",
                        column: x => x.ReasonAppealId,
                        principalSchema: "dict",
                        principalTable: "ReasonAppeals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CancerCases_SLCases_SLCaseId",
                        column: x => x.SLCaseId,
                        principalSchema: "zap",
                        principalTable: "SLCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CancerCases_Stages_StageId",
                        column: x => x.StageId,
                        principalSchema: "dict",
                        principalTable: "Stages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CancerCases_Tumors_TumorId",
                        column: x => x.TumorId,
                        principalSchema: "dict",
                        principalTable: "Tumors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConcomitantDiseases",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    SLCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DispensaryObservation = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsFirstInstalled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConcomitantDiseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConcomitantDiseases_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalSchema: "dict",
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConcomitantDiseases_SLCases_SLCaseId",
                        column: x => x.SLCaseId,
                        principalSchema: "zap",
                        principalTable: "SLCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DispensaryReferrals",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BedMedProfileId = table.Column<int>(type: "int", nullable: false),
                    DiagnosticResearchMethodId = table.Column<int>(type: "int", nullable: false),
                    MedicalCompanyId = table.Column<int>(type: "int", nullable: false),
                    MedicalServiceId = table.Column<int>(type: "int", nullable: false),
                    MedProfileId = table.Column<int>(type: "int", nullable: false),
                    MedSpecialId = table.Column<int>(type: "int", nullable: false),
                    SLCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DoctorId = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    ReferralType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispensaryReferrals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DispensaryReferrals_BedMedProfiles_BedMedProfileId",
                        column: x => x.BedMedProfileId,
                        principalSchema: "dict",
                        principalTable: "BedMedProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DispensaryReferrals_DiagnosticMethods_DiagnosticResearchMethodId",
                        column: x => x.DiagnosticResearchMethodId,
                        principalSchema: "dict",
                        principalTable: "DiagnosticMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DispensaryReferrals_MedProfiles_MedProfileId",
                        column: x => x.MedProfileId,
                        principalSchema: "dict",
                        principalTable: "MedProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DispensaryReferrals_MedSpecials_MedSpecialId",
                        column: x => x.MedSpecialId,
                        principalSchema: "dict",
                        principalTable: "MedSpecials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DispensaryReferrals_MedicalCompanies_MedicalCompanyId",
                        column: x => x.MedicalCompanyId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DispensaryReferrals_MedicalServices_MedicalServiceId",
                        column: x => x.MedicalServiceId,
                        principalSchema: "dict",
                        principalTable: "MedicalServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DispensaryReferrals_SLCases_SLCaseId",
                        column: x => x.SLCaseId,
                        principalSchema: "zap",
                        principalTable: "SLCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KSGKPGs",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KPGId = table.Column<int>(type: "int", nullable: false),
                    KSGId = table.Column<int>(type: "int", nullable: false),
                    SlCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BaseRate = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CostCoefficient = table.Column<decimal>(type: "decimal(7,5)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DifferentiationCoefficient = table.Column<decimal>(type: "decimal(7,5)", nullable: false),
                    DifficultyCoefficient = table.Column<decimal>(type: "decimal(6,5)", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsKSLP = table.Column<bool>(type: "bit", nullable: false),
                    IsSubgroupKSG = table.Column<bool>(type: "bit", nullable: false),
                    KSGModel = table.Column<int>(type: "int", nullable: false),
                    LevelCoefficient = table.Column<decimal>(type: "decimal(7,5)", nullable: false),
                    ManagementCoefficient = table.Column<decimal>(type: "decimal(7,5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KSGKPGs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KSGKPGs_KPGs_KPGId",
                        column: x => x.KPGId,
                        principalSchema: "dict",
                        principalTable: "KPGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KSGKPGs_KSGs_KSGId",
                        column: x => x.KSGId,
                        principalSchema: "dict",
                        principalTable: "KSGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KSGKPGs_SLCases_SlCaseId",
                        column: x => x.SlCaseId,
                        principalSchema: "zap",
                        principalTable: "SLCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicinalProducts",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CombinationTreatmentId = table.Column<int>(type: "int", nullable: false),
                    InjectionMethodId = table.Column<int>(type: "int", nullable: false),
                    MedicationId = table.Column<int>(type: "int", nullable: false),
                    SLCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    InjectionsNumber = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LabelCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UnitValue = table.Column<decimal>(type: "decimal(7,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicinalProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicinalProducts_CombinationTreatments_CombinationTreatmentId",
                        column: x => x.CombinationTreatmentId,
                        principalSchema: "dict",
                        principalTable: "CombinationTreatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicinalProducts_InjectionMethods_InjectionMethodId",
                        column: x => x.InjectionMethodId,
                        principalSchema: "dict",
                        principalTable: "InjectionMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicinalProducts_Medications_MedicationId",
                        column: x => x.MedicationId,
                        principalSchema: "dict",
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicinalProducts_SLCases_SLCaseId",
                        column: x => x.SLCaseId,
                        principalSchema: "zap",
                        principalTable: "SLCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicinalProducts_Units_UnitId",
                        column: x => x.UnitId,
                        principalSchema: "dict",
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Referrals",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiagnosticResearchMethodId = table.Column<int>(type: "int", nullable: false),
                    DirectionTypeId = table.Column<int>(type: "int", nullable: false),
                    MedicalCompanyId = table.Column<int>(type: "int", nullable: false),
                    MedicalServiceId = table.Column<int>(type: "int", nullable: false),
                    SLCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referrals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referrals_DiagnosticMethods_DiagnosticResearchMethodId",
                        column: x => x.DiagnosticResearchMethodId,
                        principalSchema: "dict",
                        principalTable: "DiagnosticMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Referrals_DirectionTypes_DirectionTypeId",
                        column: x => x.DirectionTypeId,
                        principalSchema: "dict",
                        principalTable: "DirectionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Referrals_MedicalCompanies_MedicalCompanyId",
                        column: x => x.MedicalCompanyId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Referrals_MedicalServices_MedicalServiceId",
                        column: x => x.MedicalServiceId,
                        principalSchema: "dict",
                        principalTable: "MedicalServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Referrals_SLCases_SLCaseId",
                        column: x => x.SLCaseId,
                        principalSchema: "zap",
                        principalTable: "SLCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SLCaseDiagnoses",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    SLCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DiagnosisType = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsFirstInstalled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLCaseDiagnoses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SLCaseDiagnoses_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalSchema: "dict",
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SLCaseDiagnoses_SLCases_SLCaseId",
                        column: x => x.SLCaseId,
                        principalSchema: "zap",
                        principalTable: "SLCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SLCaseSanctions",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SanctionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SLCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLCaseSanctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SLCaseSanctions_SLCases_SLCaseId",
                        column: x => x.SLCaseId,
                        principalSchema: "zap",
                        principalTable: "SLCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SLCaseSanctions_Sanctions_SanctionId",
                        column: x => x.SanctionId,
                        principalSchema: "zap",
                        principalTable: "Sanctions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USLServices",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    MedicalCompanyDepartmentId = table.Column<int>(type: "int", nullable: false),
                    MedicalCompanyId = table.Column<int>(type: "int", nullable: false),
                    MedicalCompanyUnitId = table.Column<int>(type: "int", nullable: false),
                    MedicalInterventionTypeId = table.Column<int>(type: "int", nullable: false),
                    MedicalServiceId = table.Column<int>(type: "int", nullable: false),
                    MedProfileId = table.Column<int>(type: "int", nullable: false),
                    MedSpecialId = table.Column<int>(type: "int", nullable: false),
                    SlCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VMPMethodId = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DoctorId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IdService = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IncompleteVolume = table.Column<int>(type: "int", nullable: false),
                    IsChildrenProfile = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsRefusal = table.Column<bool>(type: "bit", nullable: false),
                    NumberServices = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USLServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_USLServices_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalSchema: "dict",
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USLServices_MedProfiles_MedProfileId",
                        column: x => x.MedProfileId,
                        principalSchema: "dict",
                        principalTable: "MedProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USLServices_MedSpecials_MedSpecialId",
                        column: x => x.MedSpecialId,
                        principalSchema: "dict",
                        principalTable: "MedSpecials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USLServices_MedicalCompanies_MedicalCompanyId",
                        column: x => x.MedicalCompanyId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USLServices_MedicalCompanyDepartments_MedicalCompanyDepartmentId",
                        column: x => x.MedicalCompanyDepartmentId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanyDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USLServices_MedicalCompanyUnits_MedicalCompanyUnitId",
                        column: x => x.MedicalCompanyUnitId,
                        principalSchema: "LPU",
                        principalTable: "MedicalCompanyUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USLServices_MedicalServices_MedicalInterventionTypeId",
                        column: x => x.MedicalInterventionTypeId,
                        principalSchema: "dict",
                        principalTable: "MedicalServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USLServices_MedicalServices_MedicalServiceId",
                        column: x => x.MedicalServiceId,
                        principalSchema: "dict",
                        principalTable: "MedicalServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USLServices_SLCases_SlCaseId",
                        column: x => x.SlCaseId,
                        principalSchema: "zap",
                        principalTable: "SLCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USLServices_VMPMethods_VMPMethodId",
                        column: x => x.VMPMethodId,
                        principalSchema: "dict",
                        principalTable: "VMPMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CancerServices",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CancerCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DrugTherapyCycleId = table.Column<int>(type: "int", nullable: false),
                    DrugTherapyLineId = table.Column<int>(type: "int", nullable: false),
                    RadiationTherapyTypeId = table.Column<int>(type: "int", nullable: false),
                    SurgeryTypeId = table.Column<int>(type: "int", nullable: false),
                    TreatmentTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsPreventingNausea = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CancerServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CancerServices_CancerCases_CancerCaseId",
                        column: x => x.CancerCaseId,
                        principalSchema: "zap",
                        principalTable: "CancerCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CancerServices_DrugTherapyCycles_DrugTherapyCycleId",
                        column: x => x.DrugTherapyCycleId,
                        principalSchema: "dict",
                        principalTable: "DrugTherapyCycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CancerServices_DrugTherapyLines_DrugTherapyLineId",
                        column: x => x.DrugTherapyLineId,
                        principalSchema: "dict",
                        principalTable: "DrugTherapyLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CancerServices_RadiationTherapyTypes_RadiationTherapyTypeId",
                        column: x => x.RadiationTherapyTypeId,
                        principalSchema: "dict",
                        principalTable: "RadiationTherapyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CancerServices_SurgeryTypes_SurgeryTypeId",
                        column: x => x.SurgeryTypeId,
                        principalSchema: "dict",
                        principalTable: "SurgeryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CancerServices_TreatmentTypes_TreatmentTypeId",
                        column: x => x.TreatmentTypeId,
                        principalSchema: "dict",
                        principalTable: "TreatmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContraindicationBlocks",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CancerCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContraindicationId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContraindicationBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContraindicationBlocks_CancerCases_CancerCaseId",
                        column: x => x.CancerCaseId,
                        principalSchema: "zap",
                        principalTable: "CancerCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContraindicationBlocks_Contraindications_ContraindicationId",
                        column: x => x.ContraindicationId,
                        principalSchema: "dict",
                        principalTable: "Contraindications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosticBlocks",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CancerCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CancerMarkerId = table.Column<int>(type: "int", nullable: false),
                    CancerMarkerValueId = table.Column<int>(type: "int", nullable: false),
                    HistologicalExaminationResultId = table.Column<int>(type: "int", nullable: false),
                    HistologicalFeatureId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    DiagnosticIndicatorType = table.Column<int>(type: "int", nullable: false),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsResultReceive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosticBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiagnosticBlocks_CancerCases_CancerCaseId",
                        column: x => x.CancerCaseId,
                        principalSchema: "zap",
                        principalTable: "CancerCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosticBlocks_CancerMarkerValues_CancerMarkerValueId",
                        column: x => x.CancerMarkerValueId,
                        principalSchema: "dict",
                        principalTable: "CancerMarkerValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosticBlocks_CancerMarkers_CancerMarkerId",
                        column: x => x.CancerMarkerId,
                        principalSchema: "dict",
                        principalTable: "CancerMarkers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosticBlocks_HistologicalExaminationResults_HistologicalExaminationResultId",
                        column: x => x.HistologicalExaminationResultId,
                        principalSchema: "dict",
                        principalTable: "HistologicalExaminationResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosticBlocks_HistologicalFeatures_HistologicalFeatureId",
                        column: x => x.HistologicalFeatureId,
                        principalSchema: "dict",
                        principalTable: "HistologicalFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DifficultyCoefficients",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KSGKPGId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KSLPId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DifficultyCoefficients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DifficultyCoefficients_KSGKPGs_KSGKPGId",
                        column: x => x.KSGKPGId,
                        principalSchema: "zap",
                        principalTable: "KSGKPGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DifficultyCoefficients_KSLPs_KSLPId",
                        column: x => x.KSLPId,
                        principalSchema: "dict",
                        principalTable: "KSLPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KSGKPGClassificationCriterions",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassificationCriterionId = table.Column<int>(type: "int", nullable: false),
                    KSGKPGId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KSGKPGClassificationCriterions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KSGKPGClassificationCriterions_ClassificationCriterions_ClassificationCriterionId",
                        column: x => x.ClassificationCriterionId,
                        principalSchema: "dict",
                        principalTable: "ClassificationCriterions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KSGKPGClassificationCriterions_KSGKPGs_KSGKPGId",
                        column: x => x.KSGKPGId,
                        principalSchema: "zap",
                        principalTable: "KSGKPGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Implants",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalDeviceTypeId = table.Column<int>(type: "int", nullable: false),
                    USLServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Implants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Implants_MedicalDeviceTypes_MedicalDeviceTypeId",
                        column: x => x.MedicalDeviceTypeId,
                        principalSchema: "dict",
                        principalTable: "MedicalDeviceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Implants_USLServices_USLServiceId",
                        column: x => x.USLServiceId,
                        principalSchema: "zap",
                        principalTable: "USLServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CancerMedicinalProducts",
                schema: "zap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CancerServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DrugRegimenCodeId = table.Column<int>(type: "int", nullable: false),
                    MedicationId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CancerMedicinalProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CancerMedicinalProducts_CancerServices_CancerServiceId",
                        column: x => x.CancerServiceId,
                        principalSchema: "zap",
                        principalTable: "CancerServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CancerMedicinalProducts_ClassificationCriterions_DrugRegimenCodeId",
                        column: x => x.DrugRegimenCodeId,
                        principalSchema: "dict",
                        principalTable: "ClassificationCriterions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CancerMedicinalProducts_Medications_MedicationId",
                        column: x => x.MedicationId,
                        principalSchema: "dict",
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_Code",
                schema: "dict",
                table: "Diagnoses",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Сonciliums_ConsultationPurposeId",
                schema: "zap",
                table: "Сonciliums",
                column: "ConsultationPurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_Сonciliums_SLCaseId",
                schema: "zap",
                table: "Сonciliums",
                column: "SLCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_BatchNumbers_Code",
                schema: "dict",
                table: "BatchNumbers",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_BedMedProfiles_Code",
                schema: "dict",
                table: "BedMedProfiles",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_CancerCases_MetastasisId",
                schema: "zap",
                table: "CancerCases",
                column: "MetastasisId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerCases_NodusId",
                schema: "zap",
                table: "CancerCases",
                column: "NodusId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerCases_ReasonAppealId",
                schema: "zap",
                table: "CancerCases",
                column: "ReasonAppealId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerCases_SLCaseId",
                schema: "zap",
                table: "CancerCases",
                column: "SLCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerCases_StageId",
                schema: "zap",
                table: "CancerCases",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerCases_TumorId",
                schema: "zap",
                table: "CancerCases",
                column: "TumorId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerMarkers_Code",
                schema: "dict",
                table: "CancerMarkers",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_CancerMarkerValues_CancerMarkerId",
                schema: "dict",
                table: "CancerMarkerValues",
                column: "CancerMarkerId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerMarkerValues_Code",
                schema: "dict",
                table: "CancerMarkerValues",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_CancerMedicinalProducts_CancerServiceId",
                schema: "zap",
                table: "CancerMedicinalProducts",
                column: "CancerServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerMedicinalProducts_DrugRegimenCodeId",
                schema: "zap",
                table: "CancerMedicinalProducts",
                column: "DrugRegimenCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerMedicinalProducts_MedicationId",
                schema: "zap",
                table: "CancerMedicinalProducts",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerServices_CancerCaseId",
                schema: "zap",
                table: "CancerServices",
                column: "CancerCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerServices_DrugTherapyCycleId",
                schema: "zap",
                table: "CancerServices",
                column: "DrugTherapyCycleId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerServices_DrugTherapyLineId",
                schema: "zap",
                table: "CancerServices",
                column: "DrugTherapyLineId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerServices_RadiationTherapyTypeId",
                schema: "zap",
                table: "CancerServices",
                column: "RadiationTherapyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerServices_SurgeryTypeId",
                schema: "zap",
                table: "CancerServices",
                column: "SurgeryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CancerServices_TreatmentTypeId",
                schema: "zap",
                table: "CancerServices",
                column: "TreatmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDiseases_Code",
                schema: "dict",
                table: "CharacterDiseases",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ClassificationCriterions_Code",
                schema: "dict",
                table: "ClassificationCriterions",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_CombinationTreatments_Code",
                schema: "dict",
                table: "CombinationTreatments",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ConcomitantDiseases_DiagnosisId",
                schema: "zap",
                table: "ConcomitantDiseases",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_ConcomitantDiseases_SLCaseId",
                schema: "zap",
                table: "ConcomitantDiseases",
                column: "SLCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationPurposes_Code",
                schema: "dict",
                table: "ConsultationPurposes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ContraindicationBlocks_CancerCaseId",
                schema: "zap",
                table: "ContraindicationBlocks",
                column: "CancerCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ContraindicationBlocks_ContraindicationId",
                schema: "zap",
                table: "ContraindicationBlocks",
                column: "ContraindicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Contraindications_Code",
                schema: "dict",
                table: "Contraindications",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ControlTypes_Code",
                schema: "dict",
                table: "ControlTypes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticBlocks_CancerCaseId",
                schema: "zap",
                table: "DiagnosticBlocks",
                column: "CancerCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticBlocks_CancerMarkerId",
                schema: "zap",
                table: "DiagnosticBlocks",
                column: "CancerMarkerId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticBlocks_CancerMarkerValueId",
                schema: "zap",
                table: "DiagnosticBlocks",
                column: "CancerMarkerValueId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticBlocks_HistologicalExaminationResultId",
                schema: "zap",
                table: "DiagnosticBlocks",
                column: "HistologicalExaminationResultId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticBlocks_HistologicalFeatureId",
                schema: "zap",
                table: "DiagnosticBlocks",
                column: "HistologicalFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticMethods_Code",
                schema: "dict",
                table: "DiagnosticMethods",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_DifficultyCoefficients_KSGKPGId",
                schema: "zap",
                table: "DifficultyCoefficients",
                column: "KSGKPGId");

            migrationBuilder.CreateIndex(
                name: "IX_DifficultyCoefficients_KSLPId",
                schema: "zap",
                table: "DifficultyCoefficients",
                column: "KSLPId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectionTypes_Code",
                schema: "dict",
                table: "DirectionTypes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_DispensaryReferrals_BedMedProfileId",
                schema: "zap",
                table: "DispensaryReferrals",
                column: "BedMedProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_DispensaryReferrals_DiagnosticResearchMethodId",
                schema: "zap",
                table: "DispensaryReferrals",
                column: "DiagnosticResearchMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_DispensaryReferrals_MedicalCompanyId",
                schema: "zap",
                table: "DispensaryReferrals",
                column: "MedicalCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_DispensaryReferrals_MedicalServiceId",
                schema: "zap",
                table: "DispensaryReferrals",
                column: "MedicalServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_DispensaryReferrals_MedProfileId",
                schema: "zap",
                table: "DispensaryReferrals",
                column: "MedProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_DispensaryReferrals_MedSpecialId",
                schema: "zap",
                table: "DispensaryReferrals",
                column: "MedSpecialId");

            migrationBuilder.CreateIndex(
                name: "IX_DispensaryReferrals_SLCaseId",
                schema: "zap",
                table: "DispensaryReferrals",
                column: "SLCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTypes_Code",
                schema: "dict",
                table: "DocumentTypes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_DrugTherapyCycles_Code",
                schema: "dict",
                table: "DrugTherapyCycles",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_DrugTherapyLines_Code",
                schema: "dict",
                table: "DrugTherapyLines",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ExcludingExperts_Code",
                schema: "dict",
                table: "ExcludingExperts",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertReestrs_ExcludingExpertId",
                schema: "dict",
                table: "ExpertReestrs",
                column: "ExcludingExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertReestrs_UidExpert",
                schema: "dict",
                table: "ExpertReestrs",
                column: "UidExpert");

            migrationBuilder.CreateIndex(
                name: "IX_HistologicalExaminationResults_Code",
                schema: "dict",
                table: "HistologicalExaminationResults",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_HistologicalExaminationResults_HistologicalFeatureId",
                schema: "dict",
                table: "HistologicalExaminationResults",
                column: "HistologicalFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_HistologicalFeatures_Code",
                schema: "dict",
                table: "HistologicalFeatures",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Implants_MedicalDeviceTypeId",
                schema: "zap",
                table: "Implants",
                column: "MedicalDeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Implants_USLServiceId",
                schema: "zap",
                table: "Implants",
                column: "USLServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InjectionMethods_Code",
                schema: "dict",
                table: "InjectionMethods",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_InvoiceFileTypeId",
                schema: "inv",
                table: "Invoices",
                column: "InvoiceFileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_MainInvoiceId",
                schema: "inv",
                table: "Invoices",
                column: "MainInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_MedicalCompanyId",
                schema: "inv",
                table: "Invoices",
                column: "MedicalCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_TypeDispId",
                schema: "inv",
                table: "Invoices",
                column: "TypeDispId");

            migrationBuilder.CreateIndex(
                name: "IX_Ishods_UMPId",
                schema: "dict",
                table: "Ishods",
                column: "UMPId");

            migrationBuilder.CreateIndex(
                name: "IX_KPGs_Code",
                schema: "dict",
                table: "KPGs",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_KPGs_UMPId",
                schema: "dict",
                table: "KPGs",
                column: "UMPId");

            migrationBuilder.CreateIndex(
                name: "IX_KSGKPGClassificationCriterions_ClassificationCriterionId",
                schema: "zap",
                table: "KSGKPGClassificationCriterions",
                column: "ClassificationCriterionId");

            migrationBuilder.CreateIndex(
                name: "IX_KSGKPGClassificationCriterions_KSGKPGId",
                schema: "zap",
                table: "KSGKPGClassificationCriterions",
                column: "KSGKPGId");

            migrationBuilder.CreateIndex(
                name: "IX_KSGKPGs_KPGId",
                schema: "zap",
                table: "KSGKPGs",
                column: "KPGId");

            migrationBuilder.CreateIndex(
                name: "IX_KSGKPGs_KSGId",
                schema: "zap",
                table: "KSGKPGs",
                column: "KSGId");

            migrationBuilder.CreateIndex(
                name: "IX_KSGKPGs_SlCaseId",
                schema: "zap",
                table: "KSGKPGs",
                column: "SlCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_KSGs_Code",
                schema: "dict",
                table: "KSGs",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_KSGs_UMPId",
                schema: "dict",
                table: "KSGs",
                column: "UMPId");

            migrationBuilder.CreateIndex(
                name: "IX_KSLPs_Code",
                schema: "dict",
                table: "KSLPs",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_KSLPs_UMPId",
                schema: "dict",
                table: "KSLPs",
                column: "UMPId");

            migrationBuilder.CreateIndex(
                name: "IX_MainInvoices_BatchNumberId",
                schema: "inv",
                table: "MainInvoices",
                column: "BatchNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_MainInvoices_MedicalCompanyId",
                schema: "inv",
                table: "MainInvoices",
                column: "MedicalCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCompanyDepartments_MedicalCompanyId",
                schema: "LPU",
                table: "MedicalCompanyDepartments",
                column: "MedicalCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCompanyDepartments_MedicalCompanyUnitId",
                schema: "LPU",
                table: "MedicalCompanyDepartments",
                column: "MedicalCompanyUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCompanyDepartments_MedProfileId",
                schema: "LPU",
                table: "MedicalCompanyDepartments",
                column: "MedProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCompanyDepartments_UMPId",
                schema: "LPU",
                table: "MedicalCompanyDepartments",
                column: "UMPId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCompanyDepartments_VidPomId",
                schema: "LPU",
                table: "MedicalCompanyDepartments",
                column: "VidPomId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCompanyUnits_MedicalCompanyId",
                schema: "LPU",
                table: "MedicalCompanyUnits",
                column: "MedicalCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalDeviceTypes_Code",
                schema: "dict",
                table: "MedicalDeviceTypes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalServices_Code",
                schema: "dict",
                table: "MedicalServices",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Medications_Code",
                schema: "dict",
                table: "Medications",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_MedicinalProducts_CombinationTreatmentId",
                schema: "zap",
                table: "MedicinalProducts",
                column: "CombinationTreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicinalProducts_InjectionMethodId",
                schema: "zap",
                table: "MedicinalProducts",
                column: "InjectionMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicinalProducts_MedicationId",
                schema: "zap",
                table: "MedicinalProducts",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicinalProducts_SLCaseId",
                schema: "zap",
                table: "MedicinalProducts",
                column: "SLCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicinalProducts_UnitId",
                schema: "zap",
                table: "MedicinalProducts",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_MedProfiles_Code",
                schema: "dict",
                table: "MedProfiles",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_MedSpecials_Code",
                schema: "dict",
                table: "MedSpecials",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Metastasises_Code",
                schema: "dict",
                table: "Metastasises",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Metastasises_DiagnosisId",
                schema: "dict",
                table: "Metastasises",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Noduses_Code",
                schema: "dict",
                table: "Noduses",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Noduses_DiagnosisId",
                schema: "dict",
                table: "Noduses",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientVMPModels_Code",
                schema: "dict",
                table: "PatientVMPModels",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Policies_PersonId",
                table: "Policies",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Policies_PolicyTypeId",
                table: "Policies",
                column: "PolicyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyTypes_Code",
                schema: "dict",
                table: "PolicyTypes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_RadiationTherapyTypes_Code",
                schema: "dict",
                table: "RadiationTherapyTypes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ReasonAppeals_Code",
                schema: "dict",
                table: "ReasonAppeals",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Referrals_DiagnosticResearchMethodId",
                schema: "zap",
                table: "Referrals",
                column: "DiagnosticResearchMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Referrals_DirectionTypeId",
                schema: "zap",
                table: "Referrals",
                column: "DirectionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Referrals_MedicalCompanyId",
                schema: "zap",
                table: "Referrals",
                column: "MedicalCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Referrals_MedicalServiceId",
                schema: "zap",
                table: "Referrals",
                column: "MedicalServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Referrals_SLCaseId",
                schema: "zap",
                table: "Referrals",
                column: "SLCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_RefusalReasons_Code",
                schema: "dict",
                table: "RefusalReasons",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ResultDisps_Code",
                schema: "dict",
                table: "ResultDisps",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Results_UMPId",
                schema: "dict",
                table: "Results",
                column: "UMPId");

            migrationBuilder.CreateIndex(
                name: "IX_SanctionExperts_ExpertReestrId",
                schema: "zap",
                table: "SanctionExperts",
                column: "ExpertReestrId");

            migrationBuilder.CreateIndex(
                name: "IX_SanctionExperts_SanctionId",
                schema: "zap",
                table: "SanctionExperts",
                column: "SanctionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sanctions_ControlTypeId",
                schema: "zap",
                table: "Sanctions",
                column: "ControlTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sanctions_RefusalReasonId",
                schema: "zap",
                table: "Sanctions",
                column: "RefusalReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Sanctions_ZAPMainRecordId",
                schema: "zap",
                table: "Sanctions",
                column: "ZAPMainRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCaseDiagnoses_DiagnosisId",
                schema: "zap",
                table: "SLCaseDiagnoses",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCaseDiagnoses_SLCaseId",
                schema: "zap",
                table: "SLCaseDiagnoses",
                column: "SLCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCases_BedMedProfileId",
                schema: "zap",
                table: "SLCases",
                column: "BedMedProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCases_CharacterDiseaseId",
                schema: "zap",
                table: "SLCases",
                column: "CharacterDiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCases_DoctorSpecialtyId",
                schema: "zap",
                table: "SLCases",
                column: "DoctorSpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCases_MedicalCompanyDepartmentId",
                schema: "zap",
                table: "SLCases",
                column: "MedicalCompanyDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCases_MedicalCompanyUnitId",
                schema: "zap",
                table: "SLCases",
                column: "MedicalCompanyUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCases_MedProfileId",
                schema: "zap",
                table: "SLCases",
                column: "MedProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCases_VidVMPId",
                schema: "zap",
                table: "SLCases",
                column: "VidVMPId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCases_VisitPurposeId",
                schema: "zap",
                table: "SLCases",
                column: "VisitPurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCases_VMPMethodId",
                schema: "zap",
                table: "SLCases",
                column: "VMPMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCases_ZapMainRecordId",
                schema: "zap",
                table: "SLCases",
                column: "ZapMainRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCaseSanctions_SanctionId",
                schema: "zap",
                table: "SLCaseSanctions",
                column: "SanctionId");

            migrationBuilder.CreateIndex(
                name: "IX_SLCaseSanctions_SLCaseId",
                schema: "zap",
                table: "SLCaseSanctions",
                column: "SLCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Stages_Code",
                schema: "dict",
                table: "Stages",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Stages_DiagnosisId",
                schema: "dict",
                table: "Stages",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeryTypes_Code",
                schema: "dict",
                table: "SurgeryTypes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentTypes_Code",
                schema: "dict",
                table: "TreatmentTypes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Tumors_Code",
                schema: "dict",
                table: "Tumors",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Tumors_DiagnosisId",
                schema: "dict",
                table: "Tumors",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeDisps_Code",
                schema: "dict",
                table: "TypeDisps",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_UMPs_Code",
                schema: "dict",
                table: "UMPs",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Units_Code",
                schema: "dict",
                table: "Units",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_USLServices_DiagnosisId",
                schema: "zap",
                table: "USLServices",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_USLServices_MedicalCompanyDepartmentId",
                schema: "zap",
                table: "USLServices",
                column: "MedicalCompanyDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_USLServices_MedicalCompanyId",
                schema: "zap",
                table: "USLServices",
                column: "MedicalCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_USLServices_MedicalCompanyUnitId",
                schema: "zap",
                table: "USLServices",
                column: "MedicalCompanyUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_USLServices_MedicalInterventionTypeId",
                schema: "zap",
                table: "USLServices",
                column: "MedicalInterventionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_USLServices_MedicalServiceId",
                schema: "zap",
                table: "USLServices",
                column: "MedicalServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_USLServices_MedProfileId",
                schema: "zap",
                table: "USLServices",
                column: "MedProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_USLServices_MedSpecialId",
                schema: "zap",
                table: "USLServices",
                column: "MedSpecialId");

            migrationBuilder.CreateIndex(
                name: "IX_USLServices_SlCaseId",
                schema: "zap",
                table: "USLServices",
                column: "SlCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_USLServices_VMPMethodId",
                schema: "zap",
                table: "USLServices",
                column: "VMPMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_VidSluchs_UMPId",
                schema: "dict",
                table: "VidSluchs",
                column: "UMPId");

            migrationBuilder.CreateIndex(
                name: "IX_VidVMPs_Code",
                schema: "dict",
                table: "VidVMPs",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_VisitPurposes_Code",
                schema: "dict",
                table: "VisitPurposes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_VMPMethods_Code",
                schema: "dict",
                table: "VMPMethods",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_VMPMethods_PatientVMPModelId",
                schema: "dict",
                table: "VMPMethods",
                column: "PatientVMPModelId");

            migrationBuilder.CreateIndex(
                name: "IX_VMPMethods_VidVMPId",
                schema: "dict",
                table: "VMPMethods",
                column: "VidVMPId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPMainRecords_DirectedMOId",
                schema: "zap",
                table: "ZAPMainRecords",
                column: "DirectedMOId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPMainRecords_FormPomId",
                schema: "zap",
                table: "ZAPMainRecords",
                column: "FormPomId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPMainRecords_InvoiceId",
                schema: "zap",
                table: "ZAPMainRecords",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPMainRecords_IshodId",
                schema: "zap",
                table: "ZAPMainRecords",
                column: "IshodId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPMainRecords_MedicalCompanyId",
                schema: "zap",
                table: "ZAPMainRecords",
                column: "MedicalCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPMainRecords_PaymentMethodId",
                schema: "zap",
                table: "ZAPMainRecords",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPMainRecords_PersonId",
                schema: "zap",
                table: "ZAPMainRecords",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPMainRecords_PolicyId",
                schema: "zap",
                table: "ZAPMainRecords",
                column: "PolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPMainRecords_ResultDispId",
                schema: "zap",
                table: "ZAPMainRecords",
                column: "ResultDispId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPMainRecords_ResultId",
                schema: "zap",
                table: "ZAPMainRecords",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPMainRecords_UMPId",
                schema: "zap",
                table: "ZAPMainRecords",
                column: "UMPId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPMainRecords_VidPomId",
                schema: "zap",
                table: "ZAPMainRecords",
                column: "VidPomId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPMainRecords_VidSluchId",
                schema: "zap",
                table: "ZAPMainRecords",
                column: "VidSluchId");
        }
    }
}
