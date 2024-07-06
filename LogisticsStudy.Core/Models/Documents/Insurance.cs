using LogisticsStudy.Core.Enums;

namespace LogisticsStudy.Core.Models.Documents;
public class Insurance
{
    public int Id { get; set; }
    public string InsuranceNumber { get; set; }
    public decimal InsuredValue { get; set; }
    public string VehicleId { get; set; }
    public string EmployeeId { get; set; }
    public InsuranceTargetTypeEnum TargetType { get; set; }
    public string TargetId { get; set; }
    public InsuranceTypeEnum Type { get; set; }
    public InsuranceStatusEnum Status { get; set; }
    public DateTime ValidityStartDate { get; set; }
    public DateTime ValidityEndDate { get; set; }
}