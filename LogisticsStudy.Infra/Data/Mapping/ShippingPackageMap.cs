using System.Reflection.Metadata;
using LogisticsStudy.Core.Models.Delivery;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogisticsStudy.Infra.Data.Mappings;
public class ShippingPackageMap : IEntityTypeConfiguration<ShippingPackage>
{
    public void Configure(EntityTypeBuilder<ShippingPackage> builder)
    {
        builder.HasKey(sp => new { sp.ShippingId, sp.PackageId });

        builder.HasOne(sp => sp.Package)
            .WithMany(x => x.ShippingsPackage)
            .HasForeignKey(sp => sp.PackageId);

        builder.HasOne(sp => sp.Shipping)
            .WithMany(x => x.ShippingsPackage)
            .HasForeignKey(sp => sp.ShippingId);

        builder.Property(x => x.Inicialized)
            .HasDefaultValue(DateTime.UtcNow);

        builder.Property(x => x.Finished)
            .HasDefaultValue(DateTime.UtcNow);
    }
}