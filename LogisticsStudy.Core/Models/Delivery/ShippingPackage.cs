namespace LogisticsStudy.Core.Models.Delivery;
public class ShippingPackage
{
    public int ShippingId { get; set; }
    public Shipping Shipping { get; set; }
    public int PackageId { get; set; }
    public Package Package { get; set; }
    public DateTime Inicialized { get; set; }
    public DateTime Finished { get; set; }
}