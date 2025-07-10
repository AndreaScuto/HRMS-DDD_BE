using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Context;

public class HmrsDbContext : DbContext
{
    public HmrsDbContext(DbContextOptions<HmrsDbContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Assignment> Assignments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Assignment>()
            .HasKey(ep => new { ep.EmployeeId, ep.ProjectId });

        modelBuilder.Entity<Assignment>()
            .HasOne(ep => ep.Employee)
            .WithMany(e => e.Assignments)
            .HasForeignKey(ep => ep.EmployeeId);

        modelBuilder.Entity<Assignment>()
            .HasOne(ep => ep.Project)
            .WithMany(p => p.Assignments)
            .HasForeignKey(ep => ep.ProjectId);
    }
}