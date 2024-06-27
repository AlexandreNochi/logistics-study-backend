using Microsoft.EntityFrameworkCore;
using LogisticsStudy.Core.Models.Delivery;
using LogisticsStudy.Infra.Data.Mappings;
using LogisticsStudy.Core.Models.Shared;

namespace LogisticsStudy.Infra.Data;
public class LogisticsContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql("Host=localhost;Port=5432;Database=LogisticsStudy;Username=postgres;Password=NumSey123");

    public DbSet<Shipping> Shippings { get; set; }
    public DbSet<Package> Packages { get; set; }
    public DbSet<Address> Address { get; set; }
    // public DbSet<Role> Roles { get; set; }
    // public DbSet<Tag> Tags { get; set; }
    //public DbSet<User> Users { get; set; }
    // public DbSet<UserRole> UserRoles { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ShippingMap());
        modelBuilder.ApplyConfiguration(new PackageMap());
        modelBuilder.ApplyConfiguration(new AddressMap());
    }
}