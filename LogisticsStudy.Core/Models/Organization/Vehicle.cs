using LogisticsStudy.Core.Enums;

namespace LogisticsStudy.Core.Models.Organization;
public class Vehicle
{
    public int Id { get; set; }
    public IList<VehicleEmployeeHistory> Drivers { get; set; }
    public DistributionCenter DistributionCenter { get; set; }
    public string LicensePlate { get; set; }
    public string Model { get; set; }
    public int ManufactureYear { get; set; }
    public decimal LoadCapacity { get; set; }
    public VehicleStatusEnum Status { get; set; }
    public VehicleTypeEnum Type { get; set; }
    public string TrackingCode { get; set; }
}