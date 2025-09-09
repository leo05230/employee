using Employee.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employee.Infrastructure.Data;

public class EmployeeDbContext : DbContext
{
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) {}

    public DbSet<Employee> Employees => Set<Employee>();

    // TODO: Configure connection string in appsettings.json
}