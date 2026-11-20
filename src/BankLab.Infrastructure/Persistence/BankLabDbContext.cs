using BankLab.Application.Common;
using BankLab.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankLab.Infrastructure.Persistence;

public class BankLabDbContext(DbContextOptions<BankLabDbContext> options) : DbContext(options), IApplicationDbContext
{
    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customers");
            entity.HasKey(e => e.Id);
            entity.Property(x => x.FullName).IsRequired().HasMaxLength(200);
            entity.Property(x => x.Address).IsRequired().HasMaxLength(500);
            entity.Property(x => x.FatherName).IsRequired().HasMaxLength(200);
            entity.Property(x => x.PhoneNo).IsRequired().HasMaxLength(100);
            entity.Property(x => x.Nrc).IsRequired().HasMaxLength(100);
            entity.Property(x => x.DateOfBirth).IsRequired();
            entity.Property(x => x.IsActive).IsRequired();
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(50);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
        });
    }
}

