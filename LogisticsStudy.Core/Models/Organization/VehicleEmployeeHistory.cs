using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Account;
using LogisticsStudy.Core.Models.Organization;

public class VehicleEmployeeHistory
{
    public int Id { get; set; }
    public int VehicleId { get; set; }
    public Vehicle Vehicle { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public VehicleStatusEnum Status { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}