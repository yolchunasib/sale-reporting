using SaleReporting.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace SaleReporting.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Segment> Segments { get; }
    DbSet<Country> Countries { get; }
    DbSet<Product> Products { get; }
    DbSet<Sale> Sales { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}