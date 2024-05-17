using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeaveManagement.Web.Data;

public class ApplicationDbContext : IdentityDbContext<Employee>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<LeaveType> LeaveTypes { get; set; }
    public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); // Ensure to call the base method

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var properties = entityType.GetProperties()
                .Where(p => p.ClrType == typeof(DateTime) || p.ClrType == typeof(DateTime?));

            foreach (var property in properties)
            {
                property.SetValueConverter(new ValueConverter<DateTime, DateTime>(
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc),
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc)));
            }
        }
    }
}
