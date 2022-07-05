using Microsoft.EntityFrameworkCore;
using App.ManagementData.DataAccess.Models;

namespace App.ManagementData.DataAccess.Context
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tcustomer> Tcustomers { get; set; } = null!;
        public virtual DbSet<TcustomerAddress> TcustomerAddresses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tcustomer>(entity =>
            {
                entity.HasKey(e => e.Idcustomer);

                entity.ToTable("TCustomer");

                entity.Property(e => e.Idcustomer).HasColumnName("IDCustomer");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.Idno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDNo");

                entity.Property(e => e.Idsex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IDSex")
                    .IsFixedLength();

                entity.Property(e => e.Idtype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDType");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoHandphone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TcustomerAddress>(entity =>
            {
                entity.HasKey(e => e.IdcustomerAddress);

                entity.ToTable("TCustomerAddress");

                entity.Property(e => e.IdcustomerAddress).HasColumnName("IDCustomerAddress");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CityCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idcustomer).HasColumnName("IDCustomer");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdcustomerNavigation)
                    .WithMany(p => p.TcustomerAddresses)
                    .HasForeignKey(d => d.Idcustomer)
                    .HasConstraintName("FK_TCustomerAddress_TCustomer");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
