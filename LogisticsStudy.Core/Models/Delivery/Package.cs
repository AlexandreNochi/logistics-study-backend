using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Shared;

namespace LogisticsStudy.Core.Models.Delivery;
public class Package
{
    public int Id { get; set; }
    public string SKU { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }
    public double Length { get; set; }
    public string Description { get; set; }
    public PackageTypeEnum Type { get; set; }
    public ShippingStatusEnum Status { get; set; }
    public DateTime ShippedDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public Address SenderAddress { get; set; }
    public Address ReceiverAddress { get; set; }
    public string TrackingCode { get; set; }
    public ICollection<ShippingPackage> ShippingsPackage { get; set; }
    //public DateTime ExpectedDeliveryDate { get; set; }
    //public string CurrentLocation { get; set; }

#nullable enable
    public int? DevolutionId { get; set; }
}