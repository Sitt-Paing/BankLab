using BankLab.Application.Common.Interfaces;
using BankLab.Domain.Common;
using BankLab.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankLab.Infrastructure.Persistence;

public class BankLabDbContext(
    DbContextOptions<BankLabDbContext> options,
    ICurrentUserService currentUserService
    ) : DbContext(options), IApplicationDbContext
{
    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customers");
            entity.HasKey(e => e.Id);
            entity.Property(x => x.FullName).IsRequired().HasMaxLength(200);
            entity.Property(x => x.Email).IsRequired().HasMaxLength(200);
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


    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var addedEntries = ChangeTracker
        .Entries<BaseAuditableEntity<long>>()
        .Where(entry => entry.State == EntityState.Added)
        .ToList();

        if(addedEntries.Count > 0)
        {
            foreach (var entry in addedEntries)
            {
                entry.Entity.CreatedOn = DateTime.Now;
                entry.Entity.CreatedBy = currentUserService.UserName;
            }
        }

        var modifiedEntries = ChangeTracker.Entries<BaseAuditableEntity<long>>()
            .Where(entry => entry.State == EntityState.Modified)
            .ToList();

        if (modifiedEntries.Count > 0)
        {
            foreach (var entry in modifiedEntries)
            {
                entry.Entity.UpdatedOn = DateTime.Now;
                entry.Entity.UpdatedBy = currentUserService.UserName;
            }
        }

        var deletedEntries = ChangeTracker.Entries<BaseAuditableEntity<long>>()
            .Where(entry => entry.State == EntityState.Deleted)
            .ToList();

        if (deletedEntries.Count > 0)
        {
            foreach (var entry in deletedEntries)
            {
                entry.State = EntityState.Modified;
                entry.Entity.DeletedOn = DateTime.Now;
                entry.Entity.DeletedBy = currentUserService.UserName;
            }
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}

