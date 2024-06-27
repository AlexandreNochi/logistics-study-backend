using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Delivery;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogisticsStudy.Infra.Data.Mappings;
public class PackageMap : IEntityTypeConfiguration<Package>
{
    public void Configure(EntityTypeBuilder<Package> builder)
    {
        builder.HasOne(x => x.SenderAddress);

        builder.HasOne(x => x.ReceiverAddress);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.SKU)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.TrackingCode)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Description)
            .HasMaxLength(1500);

        builder.Property(x => x.Weight)
            .IsRequired();

        builder.Property(x => x.Height)
            .IsRequired();

        builder.Property(x => x.Width)
            .IsRequired();

        builder.Property(x => x.Length)
            .IsRequired();

        builder.Property(x => x.Status)
            .HasDefaultValue(ShippingStatusEnum.Wrapping)
            .HasConversion<int>();

        builder.Property(x => x.Type)
                    .HasDefaultValue(PackageTypeEnum.Delivery)
                    .HasConversion<int>();

        builder.Property(x => x.DevolutionId)
            .HasDefaultValue(null)
            .IsRequired(false);

        builder.Property(x => x.ShippedDate)
            .HasDefaultValue(DateTime.UtcNow);

        builder.Property(x => x.LastUpdateDate)
            .HasDefaultValue(DateTime.UtcNow);

        builder.HasIndex(x => x.Id, "package_id_index")
            .IsUnique();

        builder.HasIndex(x => x.SKU, "package_sku_index")
            .IsUnique();

        builder.HasIndex(x => x.TrackingCode, "package_trackingcode_index")
            .IsUnique();
    }
}