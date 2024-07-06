using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Shared;

namespace LogisticsStudy.Core.Models.Delivery;
public class Shipping
{
    public string Id { get; set; }
    public string DistributionCenterId { get; set; }
    public string VehicleId { get; set; }
    public string EmployeeId { get; set; }
    public string TrackingCode { get; set; }
    public string SenderAddressId { get; set; }
    public string ReceiverAddressId { get; set; }
    public ShippingStatusEnum Status { get; set; }
    public ShippingTypeEnum Type { get; set; }
    public DateTime ShippedDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public string[] PackagesIds { get; set; }

    public Shipping() { }
}