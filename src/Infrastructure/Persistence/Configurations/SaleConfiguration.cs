using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaleReporting.Domain.Entities;
using SaleReporting.Infrastructure.Persistence.Configurations.Common;

namespace SaleReporting.Infrastructure.Persistence.Configurations;

internal class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.ConfigureAuditableBaseEntity();

        builder.HasOne(e => e.Segment)
        .WithMany(e => e.Sales)
        .HasForeignKey(e => e.SegmentId)
        .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.Country)
       .WithMany(e => e.Sales)
       .HasForeignKey(e => e.CountryId)
       .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.Product)
       .WithMany(e => e.Sales)
       .HasForeignKey(e => e.ProductId)
       .OnDelete(DeleteBehavior.Cascade);

        builder.Property(e => e.DiscountBand).IsRequired();
        builder.Property(e => e.SoldUnits).IsRequired();
        builder.Property(e => e.ManufacturingPrice).IsRequired();
        builder.Property(e => e.SalePrice).IsRequired();
        builder.Property(e => e.GrossSales).IsRequired();
        builder.Property(e => e.Discounts).IsRequired();
        builder.Property(e => e.Sales).IsRequired();
        builder.Property(e => e.COGS).IsRequired();
        builder.Property(e => e.Profit).IsRequired();

        builder.Property(e => e.Date).HasColumnName("SaleDate").HasColumnType("DATE").IsRequired();

        builder.ToTable("Sales");
    }
}