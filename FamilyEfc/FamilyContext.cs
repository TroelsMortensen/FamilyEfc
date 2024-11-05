using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FamilyEfc;

public class FamilyContext : DbContext
{

    public DbSet<Adult> Adults => Set<Adult>();

    public DbSet<Child> Children => Set<Child>();

    public DbSet<Family> Families => Set<Family>();

    public DbSet<Interest> Interests => Set<Interest>();

    public DbSet<Pet> Pets => Set<Pet>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source = C:\\TRMO\\RiderProjects\\FamilyEfc\\FamilyEfc\\Family.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adult>(entity =>
        {
            entity.ToTable("Adult");

            entity.HasIndex(e => new { e.FamilyStreetName, e.FamilyHouseNumber }, "IX_Adult_FamilyStreetName_FamilyHouseNumber");

            entity.HasOne(d => d.Family).WithMany(p => p.Adults)
                .HasForeignKey(d => new { d.FamilyStreetName, d.FamilyHouseNumber })
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Child>(entity =>
        {
            entity.ToTable("Child");

            entity.HasIndex(e => new { e.FamilyStreetName, e.FamilyHouseNumber }, "IX_Child_FamilyStreetName_FamilyHouseNumber");

            entity.HasOne(d => d.Family).WithMany(p => p.Children)
                .HasForeignKey(d => new { d.FamilyStreetName, d.FamilyHouseNumber })
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(d => d.InterestsTypes).WithMany(p => p.Children)
                .UsingEntity<Dictionary<string, object>>(
                    "ChildInterest",
                    r => r.HasOne<Interest>().WithMany().HasForeignKey("InterestsType"),
                    l => l.HasOne<Child>().WithMany().HasForeignKey("ChildrenId"),
                    j =>
                    {
                        j.HasKey("ChildrenId", "InterestsType");
                        j.ToTable("ChildInterest");
                        j.HasIndex(new[] { "InterestsType" }, "IX_ChildInterest_InterestsType");
                    });
        });

        modelBuilder.Entity<Family>(entity =>
        {
            entity.HasKey(e => new { e.StreetName, e.HouseNumber });
        });

        modelBuilder.Entity<Interest>(entity =>
        {
            entity.HasKey(e => e.Type);

            entity.ToTable("Interest");
        });

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.ToTable("Pet");

            entity.HasIndex(e => e.ChildId, "IX_Pet_ChildId");

            entity.HasIndex(e => new { e.FamilyStreetName, e.FamilyHouseNumber }, "IX_Pet_FamilyStreetName_FamilyHouseNumber");

            entity.HasOne(d => d.Child).WithMany(p => p.Pets)
                .HasForeignKey(d => d.ChildId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Family).WithMany(p => p.Pets)
                .HasForeignKey(d => new { d.FamilyStreetName, d.FamilyHouseNumber })
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
