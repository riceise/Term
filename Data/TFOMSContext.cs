using Data.Model.Entities.Dictionary;
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
                optionsBuilder.UseSqlServer("server=DESKTOP-PVQM84B\\SQLEXPRESS;Database=testim;User Id=sa;Password=5456;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SpiskiNaDNFromMO>()
                .HasOne(s => s.UploadFileInf)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
            
        }
        
        #region Справочники

        public DbSet<Diagnosis> Diagnosis => Set<Diagnosis>();
        public DbSet<MedProfileDictionary> MedProfileDictionary => Set<MedProfileDictionary>();
        
        #endregion
        
        #region Реестры

        public DbSet<Person> Persons => Set<Person>();
        
        #endregion
        
        #region Медицинские организации
      
        public DbSet<MedicalCompany> MedicalCompanies => Set<MedicalCompany>();
       
        #endregion

        #region Загрузка
        public DbSet<SpiskiNaDNFromMO> SpiskiNaDNFromMO => Set<SpiskiNaDNFromMO>();

        public DbSet<UploadFileInf> UploadFileInfs => Set<UploadFileInf>();
        
        #endregion




    }
}
