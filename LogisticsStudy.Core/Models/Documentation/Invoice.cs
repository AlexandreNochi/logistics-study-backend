using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Delivery;

namespace LogisticsStudy.Core.Models.Documentation;
public class Invoice
{
    public int Id { get; set; }
    public string InvoiceNumber { get; set; }
    public string Sender { get; set; }
    public string Recipient { get; set; }
    public string OriginAddress { get; set; }
    public string DestinationAddress { get; set; }
    public decimal TotalValue { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public InvoiceStatus Status { get; set; }
    public IList<Package> Packages { get; set; }
    public IList<Shipping> ShippingsHistory { get; set; }
}

