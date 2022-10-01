namespace SaleReporting.Domain.Common;

public abstract class NameableEntity : BaseEntity
{
  public string Name { get; set; } = string.Empty;
}