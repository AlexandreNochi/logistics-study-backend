using LogisticsStudy.Core.Models.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogisticsStudy.Infra.Data.Mappings;
public class AddressMap : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Street)
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(x => x.Number)
            .IsRequired();

        builder.Property(x => x.Neighborhood)
                .IsRequired()
                .HasMaxLength(100);

        builder.Property(x => x.City)
                .IsRequired()
                .HasMaxLength(100);

        builder.Property(x => x.State)
                .IsRequired()
                .HasMaxLength(100);

        builder.Property(x => x.ZipCode)
                .IsRequired()
                .HasMaxLength(20);

        builder.Property(x => x.Complement)
                .HasMaxLength(200);
    }
}