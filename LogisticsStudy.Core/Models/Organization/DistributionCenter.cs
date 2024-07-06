using LogisticsStudy.Core.Models.Account;
using LogisticsStudy.Core.Models.Delivery;
using LogisticsStudy.Core.Models.Shared;

namespace LogisticsStudy.Core.Models.Organization;
public class DistributionCenter
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string AddressId { get; set; }
    public ICollection<Vehicle> Vehicles { get; set; }
    public ICollection<Employee> Employees { get; set; }
}
