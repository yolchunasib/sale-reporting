namespace SaleReporting.Domain.Entities;

public class Segment : NameableEntity
{
   public ICollection<Sale> Sales { get; set; } = null!;
}