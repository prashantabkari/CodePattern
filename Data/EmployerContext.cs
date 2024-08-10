using Microsoft.EntityFrameworkCore;
using EmployerApi.Models.Employer;

namespace EmployerApi.Data;

public class EmployerContext : DbContext
{
    public EmployerContext(DbContextOptions<EmployerContext> options) : base(options) { }

    public DbSet<Employer> Employers { get; set; }
}