using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Delivery;

namespace LogisticsStudy.Core.Models;
public class Insurance
{
    public int Id { get; set; }
    public string InsuranceNumber { get; set; }
    public decimal InsuredValue { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public InsuranceTypeEnum Type { get; set; }
    public InsuranceStatusEnum Status { get; set; }
    public IList<Package> InsuredPackages { get; set; }
    public IList<Shipping> InsuredShippingsHistory { get; set; }
}