using Microsoft.EntityFrameworkCore;
using CRMEducacional.Models;

namespace CRMEducational.Repository;

public class CRMEducacionalContext : DbContext
{
  public DbSet<Lead> Leads { get; private set; } = default!;
  public DbSet<Course> Courses { get; private set; } = default!;
  public DbSet<Registration> Registrations { get; private set; } = default!;

  public CRMEducacionalContext(DbContextOptions<CRMEducacionalContext> options) : base(options) { }
  public CRMEducacionalContext() { }

  protected override void OnConfiguring(DbContextOptionsBuilder contextBuilder)
  {
      if (!contextBuilder.IsConfigured)
      {
          contextBuilder.UseSqlServer(Environment.GetEnvironmentVariable("CONTEXT_CONNECTION_STRING"));
      }
  }
}