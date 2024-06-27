using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Shared;

namespace LogisticsStudy.Core.Models.Delivery;
public class Shipping
{
    public int Id { get; set; }
    public string TrackingCode { get; set; }
    public Address SenderAddress { get; set; }
    public Address ReceiverAddress { get; set; }
    public ShippingStatusEnum Status { get; set; }
    public ShippingTypeEnum Type { get; set; }
    public DateTime ShippedDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public ICollection<ShippingPackage> ShippingsPackage { get; set; }
}