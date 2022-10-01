namespace SaleReporting.Domain.Entities;

public class Country : NameableEntity
{
   public ICollection<Sale> Sales { get; set; } = null!;
}