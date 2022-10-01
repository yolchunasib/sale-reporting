namespace SaleReporting.Domain.Entities;

public class Product : NameableEntity
{
   public ICollection<Sale> Sales { get; set; } = null!;
}