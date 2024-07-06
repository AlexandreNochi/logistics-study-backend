using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Shared;

namespace LogisticsStudy.Core.Models.Account;
public abstract class Credentials
{
    public int Id { get; set; }
    public CredentialsStatusEnum Status { get; set; }
    public CredentialsTypeEnum Type { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Age { get; set; }
    public string AddressId { get; set; }
    public IList<string> Phones { get; set; }
}