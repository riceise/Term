using Data.Model;
using Data.Model.Entities.Dictionary;
using Data.Model.Entities.Invoice;
using Data.Model.Entities.MedicalCompany;
using Data.Model.Entities.Person;
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
                optionsBuilder.UseSqlServer("Server=127.0.0.1, 1433;Database=testNikitos;User Id=sa;Password=furi0so35;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SpiskiNaDDFromMO>()
                .HasOne(s => s.UploadFileInf)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<DispensaryListResult>()
                .HasOne(d => d.SpiskiNaDDFromMO)
                .WithMany()
                .HasForeignKey(d => d.SpiskiNaDDFromMOId)
                .HasConstraintName("FK_SpiskiNaDDFromMOId");
            
        }
        
        #region Справочники

        public DbSet<Diagnosis> Diagnosis => Set<Diagnosis>();
        public DbSet<MedProfileDictionary> MedProfileDictionary => Set<MedProfileDictionary>();
        public DbSet<InvoiceFileType> InvoiceFileTypes => Set<InvoiceFileType>();
        
        #endregion
        
        #region Реестры

        public DbSet<ZAP> ZAP => Set<ZAP>();
        public DbSet<Person> Persons => Set<Person>();
        public DbSet<Invoice> Invoices => Set<Invoice>();
        
        #endregion
        
        #region Медицинские организации
      
        public DbSet<MedicalCompany> MedicalCompanies => Set<MedicalCompany>();
       
        #endregion

        #region Загрузка
        public DbSet<SpiskiNaDDFromMO> SpiskiNaDDFromMO => Set<SpiskiNaDDFromMO>();

        public DbSet<UploadFileInf> UploadFileInfs => Set<UploadFileInf>();

        public DbSet<DispensaryListResult> DispensaryListResults => Set<DispensaryListResult>();

        #endregion

        public DbSet<DispensaryObservation> DispensaryObservation => Set<DispensaryObservation>();

    }
}
