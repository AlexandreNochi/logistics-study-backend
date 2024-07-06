using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Organization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogisticsStudy.Infra.Data.Mappings;
public class VehicleMap : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(x => x.Drivers)
            .WithOne(ve => ve.Vehicle)
            .HasForeignKey(ve => ve.VehicleId);

        builder.Property(x => x.Status)
            .HasDefaultValue(VehicleStatusEnum.Avaliable);

        builder.Property(x => x.Type)
            .HasDefaultValue(VehicleTypeEnum.Transport);

        builder.Property(x => x.LicensePlate)
            .IsRequired();

        builder.Property(x => x.LoadCapacity)
            .IsRequired();

        builder.Property(x => x.TrackingCode)
            .IsRequired();

        builder.Property(x => x.Model)
            .IsRequired();

        builder.Property(x => x.ManufactureYear)
            .IsRequired();
    }
}