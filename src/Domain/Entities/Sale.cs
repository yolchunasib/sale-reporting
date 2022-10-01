namespace SaleReporting.Domain.Entities;

public class Sale: BaseAuditableEntity
{
    public int SegmentId { get; set; }
    public int CountryId { get; set; }
    public int ProductId { get; set; }
    public DiscountBand DiscountBand { get; set; }
    public double SoldUnits { get; set; }
    public double ManufacturingPrice { get; set; }
    public double SalePrice { get; set; }
    public double GrossSales { get; set; }
    public double Discounts { get; set; }
    public double Sales { get; set; }
    public double COGS { get; set; }
    public double Profit { get; set; }
    public DateTime Date { get; set; }


    public Segment Segment { get; set; } = null!;
    public Country Country { get; set; } = null!;
    public Product Product { get; set; } = null!;
}