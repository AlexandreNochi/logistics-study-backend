using System.Security.Cryptography.X509Certificates;
using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Delivery;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogisticsStudy.Infra.Data.Mappings;
public class ShippingMap : IEntityTypeConfiguration<Shipping>
{
    public void Configure(EntityTypeBuilder<Shipping> builder)
    {
        builder.HasOne(x => x.SenderAddress);
        builder.HasOne(x => x.ReceiverAddress);

        builder.HasMany(x => x.Packages);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.TrackingCode)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Status)
            .HasDefaultValue(ShippingStatusEnum.Wrapping)
            .HasConversion<int>();

        builder.Property(x => x.Type)
            .HasDefaultValue(ShippingTypeEnum.InternalShipping)
            .HasConversion<int>();

        builder.Property(x => x.ShippedDate)
            .HasDefaultValue(DateTime.UtcNow);

        builder.Property(x => x.LastUpdateDate)
            .HasDefaultValue(DateTime.UtcNow);

        builder.HasIndex(x => x.Id, "shipping_id_index")
            .IsUnique();

        builder.HasIndex(x => x.TrackingCode, "shipping_trackingcode_index")
            .IsUnique();
    }
}