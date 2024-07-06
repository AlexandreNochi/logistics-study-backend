using LogisticsStudy.Core.DTOs;
using LogisticsStudy.Core.Enums;

namespace LogisticsStudy.Core.Models.Delivery;
public class Package
{
    public string Id { get; set; }
    public string ClientId { get; set; }
    public string[] ShippingIdHistory { get; set; }
    public string SKU { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }
    public double Length { get; set; }
    public string Description { get; set; }
    public PackageTypeEnum Type { get; set; }
    public ShippingStatusEnum Status { get; set; }
    public DateTime ShippedDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public string SenderAddress { get; set; }
    public string ReceiverAddress { get; set; }
    public string TrackingCode { get; set; }

    public Package() { }

    public Package(RegisterPackageDTO packageDTO)
    {
        ClientId = packageDTO.ClientId;
        Weight = packageDTO.Weight;
        Height = packageDTO.Height;
        Width = packageDTO.Width;
        Length = packageDTO.Length;
        Description = packageDTO.Description;
        Type = packageDTO.Type;
        Status = packageDTO.Status;
        SenderAddress = packageDTO.SenderAddress;
        ReceiverAddress = packageDTO.ReceiverAddress;
    }
}