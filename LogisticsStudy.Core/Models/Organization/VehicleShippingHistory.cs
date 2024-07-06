using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Delivery;

namespace LogisticsStudy.Core.Models.Organization;
public class VehicleShippingHistory
{
    public int VehicleId { get; set; }
    public Vehicle Vehicle { get; set; }
    public int EmployeeId { get; set; }
    public Shipping Shipping { get; set; }
}