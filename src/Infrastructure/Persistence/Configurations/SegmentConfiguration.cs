using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaleReporting.Domain.Entities;
using SaleReporting.Infrastructure.Persistence.Configurations.Common;

namespace SaleReporting.Infrastructure.Persistence.Configurations;

internal class SegmentConfiguration : IEntityTypeConfiguration<Segment>
{
    public void Configure(EntityTypeBuilder<Segment> builder)
    {
        builder.ConfigureNameableBaseEntity();

        builder.ToTable("Segments");
    }
}