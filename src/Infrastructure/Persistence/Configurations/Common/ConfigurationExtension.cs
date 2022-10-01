using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaleReporting.Domain.Common;

namespace SaleReporting.Infrastructure.Persistence.Configurations.Common;

public static class ConfigurationExtension
{
    public static EntityTypeBuilder<TEntity> ConfigureBaseEntity<TEntity>(this EntityTypeBuilder<TEntity> builder)
                where TEntity : BaseEntity
    {
        builder.HasKey(e => e.Id);

        return builder;
    }

    public static EntityTypeBuilder<TEntity> ConfigureAuditableBaseEntity<TEntity>(this EntityTypeBuilder<TEntity> builder)
                where TEntity : BaseAuditableEntity
    {
        builder.ConfigureBaseEntity();

        builder.Property(e => e.CreatedBy).HasMaxLength(200).IsRequired();
        builder.Property(e => e.Created).IsRequired();

        builder.Property(e => e.LastModifiedBy).HasMaxLength(200);

        return builder;
    }

     public static EntityTypeBuilder<TEntity> ConfigureNameableBaseEntity<TEntity>(this EntityTypeBuilder<TEntity> builder)
                where TEntity : NameableEntity
    {
        builder.ConfigureBaseEntity();

        builder.Property(e => e.Name).HasMaxLength(200).IsRequired();

        return builder;
    }

}