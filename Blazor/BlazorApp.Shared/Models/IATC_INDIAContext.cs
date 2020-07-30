using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorApp.Shared.Models
{
    public partial class IATC_INDIAContext : DbContext
    {
        public IATC_INDIAContext()
        {
        }

        public IATC_INDIAContext(DbContextOptions<IATC_INDIAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<IatcindiaMMemberdetailsTest> IatcindiaMMemberdetailsTest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=43.255.152.25;Initial Catalog=IATC_INDIA;User ID=IATC_INDIA;Password=IATC_INDIA@03;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "IATC_INDIA");

            modelBuilder.Entity<IatcindiaMMemberdetailsTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("iatcindia_m_memberdetailsTest");

                entity.Property(e => e.Bank)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CityInstitution)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateofBirth)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateofTransaction)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EducationQualification)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Emailid)
                    .HasColumnName("EMAILID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Iatcregno)
                    .HasColumnName("IATCREGNO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Medicine)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NottoregistrationNo)
                    .HasColumnName("NOTTORegistrationNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nursing)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PkId)
                    .HasColumnName("Pk_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PostGraduate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QualificationDetails)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Salutations)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StateInstitution)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransacationNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.YearofExperience)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
