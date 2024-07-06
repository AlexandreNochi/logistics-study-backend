using Microsoft.EntityFrameworkCore;
using LogisticsStudy.Infra.Data.Mappings;
using LogisticsStudy.Core.Models.Organization;
using LogisticsStudy.Core.Models.Account;
using Microsoft.Extensions.Configuration;

namespace LogisticsStudy.Infra.Data;
public class LogisticsContext : DbContext
{
    private readonly IConfiguration _configuration;

    public LogisticsContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("Postgre"));
    }

    public DbSet<DistributionCenter> DistributionCenters { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<VehicleEmployeeHistory> VehicleEmployeeHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new DistributionCenterMap());
        modelBuilder.ApplyConfiguration(new EmployeeMap());
        modelBuilder.ApplyConfiguration(new VehicleMap());
        modelBuilder.ApplyConfiguration(new VehicleEmployeeHistoryMap());
    }
}