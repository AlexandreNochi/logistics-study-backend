using LogisticsStudy.Core.Models.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogisticsStudy.Infra.Data.Mappings;
public class EmployeeMap : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(x => x.Vehicles)
            .WithOne(ve => ve.Employee)
            .HasForeignKey(ve => ve.EmployeeId);

        builder.HasOne(x => x.DistributionCenter);

        builder.Property(x => x.OfficePosition);
    }
}
