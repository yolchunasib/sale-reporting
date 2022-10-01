using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaleReporting.Domain.Entities;
using SaleReporting.Infrastructure.Persistence.Configurations.Common;

namespace SaleReporting.Infrastructure.Persistence.Configurations;

internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ConfigureNameableBaseEntity();

        builder.ToTable("Products");
    }
}