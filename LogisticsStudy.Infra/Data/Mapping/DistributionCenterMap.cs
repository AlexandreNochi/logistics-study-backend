
using LogisticsStudy.Core.Models.Organization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogisticsStudy.Infra.Data.Mappings;
public class DistributionCenterMap : IEntityTypeConfiguration<DistributionCenter>
{
    public void Configure(EntityTypeBuilder<DistributionCenter> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name);
        builder.Property(x => x.AddressId);

        builder.HasMany(x => x.Vehicles);
        builder.HasMany(x => x.Employees);
    }
}