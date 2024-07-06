using LogisticsStudy.Core.Enums;

namespace LogisticsStudy.Core.Models.Documents;
public class Invoice
{
    public int Id { get; set; }
    public string InvoiceNumber { get; set; }
    public InvoiceTargetTypeEnum TargetType { get; set; }
    public string TargetId { get; set; }
    public string InsuranceId { get; set; }
    public decimal TotalValue { get; set; }
    public string SenderId { get; set; }
    public string RecipientId { get; set; }
    public string OriginAddress { get; set; }
    public string DestinationAddress { get; set; }
    public InvoiceStatusEnum Status { get; set; }
    public DateTime ValidityStartDate { get; set; }
    public DateTime ValidityEndDate { get; set; }
}