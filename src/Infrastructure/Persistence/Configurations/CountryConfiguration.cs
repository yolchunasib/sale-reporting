using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaleReporting.Domain.Entities;
using SaleReporting.Infrastructure.Persistence.Configurations.Common;

namespace SaleReporting.Infrastructure.Persistence.Configurations;

internal class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ConfigureNameableBaseEntity();

        builder.ToTable("Countries");
    }
}