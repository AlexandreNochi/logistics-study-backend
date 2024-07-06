using LogisticsStudy.Core.Models.Organization;

namespace LogisticsStudy.Core.Models.Account;
public class Employee : Credentials
{
    public DistributionCenter DistributionCenter { get; set; }
    public IEnumerable<VehicleEmployeeHistory> Vehicles { get; set; }
    public string OfficePosition { get; set; }
}