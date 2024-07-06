using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Delivery;

namespace LogisticsStudy.Core.Models.Organization;
public class DistributionCenterPackage
{
    public int DistributionCenterId { get; set; }
    public DistributionCenter DistributionCenter { get; set; }
    public int PackageId { get; set; }
    public Package Package { get; set; }
    public PackageStatusEnum Status { get; set; }
    public DateTime Received { get; set; }
    public DateTime? Shipped { get; set; }
}