using Data.Model.Entities.Dictionary;
using Data.Model.Entities.Invoice;
using Data.Model.Entities.MedicalCompany;
using Data.Model.Entities.Person;
using Data.Model.Entities.Policy;
using Data.Model.Entities.UploadedFile;
using Data.Model.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Data
{
    public class TFOMSContext : IdentityDbContext<ApplicationUser>
    {
        public TFOMSContext()
        {
            
        }
        public TFOMSContext(DbContextOptions<TFOMSContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-PVQM84B\\SQLEXPRESS;Database=testim;User Id=sa;Password=5456;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SLCase>()
                .HasMany(x => x.Diagnoses)
                .WithMany("SLCases")
                .UsingEntity<SLCaseDiagnosis>();
            modelBuilder.Entity<KSGKPG>()
                .HasMany(x=> x.ClassificationCriterions)
                .WithMany("KSGKPGs")
                .UsingEntity<KSGKPGClassificationCriterion>();
            modelBuilder.Entity<Sanction>()
                .HasMany(x => x.Experts)
                .WithMany("Sanctions")
                .UsingEntity<SanctionExpert>();
            modelBuilder.Entity<Sanction>()
                .HasMany(x => x.SLCases)
                .WithMany(x=> x.Sanctions)
                .UsingEntity<SLCaseSanction>();
        }
        
        #region Справочники
        public DbSet<UMP> UMPs => Set<UMP>();
        public DbSet<VidPom> VidPoms => Set<VidPom>();
        public DbSet<FormPom> FormPoms => Set<FormPom>();
        public DbSet<PolicyType> PolicyTypes => Set<PolicyType>();
        public DbSet<DocumentType> DocumentTypes => Set<DocumentType>();
        public DbSet<OKATO> OKATOs => Set<OKATO>();
        public DbSet<InsuranceCompany> InsuranceCompanies => Set<InsuranceCompany>();
        public DbSet<Result> Results => Set<Result>();
        public DbSet<Ishod> Ishods => Set<Ishod>();
        public DbSet<PaymentMethod> PaymentMethods => Set<PaymentMethod>();
        public DbSet<VidSluch> VidSluchs => Set<VidSluch>();
        public DbSet<TypeDisp> TypeDisps => Set<TypeDisp>();
        public DbSet<ResultDisp> ResultDisps => Set<ResultDisp>();
        public DbSet<MedProfile> MedProfiles => Set<MedProfile>();
        public DbSet<BedMedProfile> BedMedProfiles => Set<BedMedProfile>();
        public DbSet<VisitPurpose> VisitPurposes => Set<VisitPurpose>();
        public DbSet<MedSpecial> MedSpecials => Set<MedSpecial>();
        public DbSet<CharacterDisease> CharacterDiseases => Set<CharacterDisease>();
        public DbSet<VidVMP> VidVMPs => Set<VidVMP>();
        public DbSet<PatientVMPModel> PatientVMPModels => Set<PatientVMPModel>();
        public DbSet<VMPMethod> VMPMethods => Set<VMPMethod>();
        public DbSet<Diagnosis> Diagnoses => Set<Diagnosis>();
        public DbSet<MedicalService> MedicalServices => Set<MedicalService>();
        public DbSet<KPG> KPGs => Set<KPG>();
        public DbSet<KSG> KSGs => Set<KSG>();
        public DbSet<ClassificationCriterion> ClassificationCriterions => Set<ClassificationCriterion>();
        public DbSet<DirectionType> DirectionTypes => Set<DirectionType>();
        public DbSet<DiagnosticMethod> DiagnosticMethods => Set<DiagnosticMethod>();
        public DbSet<ControlType> ControlTypes => Set<ControlType>();
        public DbSet<RefusalReason> RefusalReasons => Set<RefusalReason>();
        public DbSet<ExcludingExpert> ExcludingExperts => Set<ExcludingExpert>();
        public DbSet<ExpertReestr> ExpertReestrs => Set<ExpertReestr>();
        public DbSet<CombinationTreatment> CombinationTreatments => Set<CombinationTreatment>();
        public DbSet<Medication> Medications => Set<Medication>();
        public DbSet<ConsultationPurpose> ConsultationPurposes => Set<ConsultationPurpose>();
        public DbSet<ReasonAppeal> ReasonAppeals => Set<ReasonAppeal>();
        public DbSet<Stage> Stages => Set<Stage>();
        public DbSet<Tumor> Tumors => Set<Tumor>();
        public DbSet<Nodus> Noduses => Set<Nodus>();
        public DbSet<Metastasis> Metastasises => Set<Metastasis>();
        public DbSet<HistologicalFeature> HistologicalFeatures => Set<HistologicalFeature>();
        public DbSet<CancerMarker> CancerMarkers => Set<CancerMarker>();
        public DbSet<HistologicalExaminationResult> HistologicalExaminationResults => Set<HistologicalExaminationResult>();
        public DbSet<CancerMarkerValue> CancerMarkerValues => Set<CancerMarkerValue>();
        public DbSet<Contraindication> Contraindications => Set<Contraindication>();
        public DbSet<TreatmentType> TreatmentTypes => Set<TreatmentType>();
        public DbSet<SurgeryType> SurgeryTypes => Set<SurgeryType>();
        public DbSet<DrugTherapyLine> DrugTherapyLines => Set<DrugTherapyLine>();
        public DbSet<DrugTherapyCycle> DrugTherapyCycles => Set<DrugTherapyCycle>();
        public DbSet<RadiationTherapyType> RadiationTherapyTypes => Set<RadiationTherapyType>();
        public DbSet<Unit> Units => Set<Unit>();
        public DbSet<InjectionMethod> InjectionMethods => Set<InjectionMethod>();
        public DbSet<MedicalDeviceType> MedicalDeviceTypes => Set<MedicalDeviceType>();
        public DbSet<KSLP> KSLPs => Set<KSLP>();
        public DbSet<BatchNumber> BatchNumbers => Set<BatchNumber>();
        #endregion
        #region Реестры
        public DbSet<MainInvoice> MainInvoices => Set<MainInvoice>();
        public DbSet<Person> Persons => Set<Person>();
        public DbSet<Invoice> Invoices => Set<Invoice>();
        public DbSet<ZAPMainRecord> ZAPMainRecords => Set<ZAPMainRecord>();
        public  DbSet<SLCase> SLCases =>  Set<SLCase>();
        public  DbSet<SLCaseDiagnosis> SLCaseDiagnoses =>  Set<SLCaseDiagnosis>();
        public  DbSet<USLService> USLServices =>  Set<USLService>();
        public  DbSet<Policy> Policies =>  Set<Policy>();
        public DbSet<InvoiceFileType> InvoiceFileType => Set<InvoiceFileType>();
        public DbSet<KSGKPG> KSGKPGs => Set<KSGKPG>();
        public DbSet<KSGKPGClassificationCriterion> KSGKPGClassificationCriterions => Set<KSGKPGClassificationCriterion>();
        public DbSet<Referral> Referrals => Set<Referral>();
        public DbSet<Sanction> Sanctions => Set<Sanction>();
        public DbSet<SLCaseSanction> SLCaseSanctions => Set<SLCaseSanction>();
        public DbSet<SanctionExpert> SanctionExperts => Set<SanctionExpert>();
        public DbSet<Сoncilium> Сonciliums => Set<Сoncilium>();
        public DbSet<CancerCase> CancerCases => Set<CancerCase>();
        public DbSet<DiagnosticBlock> DiagnosticBlocks => Set<DiagnosticBlock>();
        public DbSet<ContraindicationBlock> ContraindicationBlocks => Set<ContraindicationBlock>();
        public DbSet<CancerService> CancerServices => Set<CancerService>();
        public DbSet<DispensaryReferral> DispensaryReferrals => Set<DispensaryReferral>();
        public DbSet<ConcomitantDisease> ConcomitantDiseases => Set<ConcomitantDisease>();
        public DbSet<Implant> Implants => Set<Implant>();
        public DbSet<MedicinalProduct> MedicinalProducts => Set<MedicinalProduct>();
        public DbSet<CancerMedicinalProduct> CancerMedicinalProducts => Set<CancerMedicinalProduct>();
        public DbSet<DifficultyCoefficient> DifficultyCoefficients => Set<DifficultyCoefficient>();
        #endregion
        #region Медицинские организации
        public DbSet<OrganizationType> OrganizationTypes => Set<OrganizationType>();
        public DbSet<MedicalCompany> MedicalCompanies => Set<MedicalCompany>();
        public DbSet<MedicalCompanyUnit> MedicalCompanyUnits => Set<MedicalCompanyUnit>();
        public DbSet<MedicalCompanyDepartment> MedicalCompanyDepartments => Set<MedicalCompanyDepartment>();
        
        #endregion
        #region Экспертизы СМО


        #endregion

        #region Загрузка
        public DbSet<SpiskiNaDNFromMO> SpiskiNaDNFromMO => Set<SpiskiNaDNFromMO>();

        public DbSet<UploadFileInf> UploadFileInfs => Set<UploadFileInf>();


        #endregion




    }
}
