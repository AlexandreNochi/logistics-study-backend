using LogisticsStudy.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogisticsStudy.Infra.Data.Mappings;
public class VehicleEmployeeHistoryMap : IEntityTypeConfiguration<VehicleEmployeeHistory>
{
    public void Configure(EntityTypeBuilder<VehicleEmployeeHistory> builder)
    {
        builder.HasKey(x => new { x.Id, x.EmployeeId, x.VehicleId });

        builder.HasOne(ve => ve.Employee)
            .WithMany(x => x.Vehicles)
            .HasForeignKey(ve => ve.EmployeeId);

        builder.HasOne(ve => ve.Vehicle)
            .WithMany(x => x.Drivers)
            .HasForeignKey(ve => ve.EmployeeId);

        builder.Property(x => x.Status)
            .HasDefaultValue(VehicleStatusEnum.Avaliable);

        builder.Property(x => x.Start)
                .HasDefaultValue(DateTime.UtcNow);
        builder.Property(x => x.End)
                .HasDefaultValue(DateTime.UtcNow);
    }
}