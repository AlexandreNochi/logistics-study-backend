using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Delivery;

namespace LogisticsStudy.Core.Models.Organization;
public class DistributionCenterShipping
{
    public int DistributionCenterId { get; set; }
    public DistributionCenter DistributionCenter { get; set; }
    public int ShippingId { get; set; }
    public Shipping Shipping { get; set; }
    public ShippingStatusEnum Status { get; set; }
    public DateTime ShippedDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
}