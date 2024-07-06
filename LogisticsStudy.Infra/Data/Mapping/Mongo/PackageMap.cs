using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Delivery;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;

namespace LogisticsStudy.Infra.Data.Mappings.Mongo;
public class PackageMap
{
    public void Configure()
    {
        if (!BsonClassMap.IsClassMapRegistered(typeof(Package)))
        {
            BsonClassMap.RegisterClassMap<Package>(cm =>
            {
                cm.AutoMap();

                cm.MapIdMember(x => x.Id)
                    .SetIdGenerator(StringObjectIdGenerator.Instance)
                    .SetSerializer(new StringSerializer(MongoDB.Bson.BsonType.ObjectId));

                cm.MapMember(x => x.ClientId)
                    .SetElementName("client_id")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.ShippingIdHistory)
                    .SetSerializer(new ArraySerializer<string>(new StringSerializer(BsonType.ObjectId)));

                cm.MapMember(x => x.SKU)
                    .SetElementName("package_sku")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.TrackingCode)
                    .SetElementName("tracking_code")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.Weight)
                    .SetElementName("weight");

                cm.MapMember(x => x.Height)
                    .SetElementName("height");

                cm.MapMember(x => x.Width)
                    .SetElementName("widht");

                cm.MapMember(x => x.Length)
                    .SetElementName("lenght");

                cm.MapMember(x => x.Description)
                    .SetElementName("description");

                cm.MapMember(x => x.Type)
                    .SetElementName("package_type")
                    .SetDefaultValue(PackageTypeEnum.Delivery);

                cm.MapMember(x => x.Status)
                    .SetElementName("package_status")
                    .SetDefaultValue(PackageStatusEnum.Wrapping);

                cm.MapMember(x => x.ShippedDate)
                    .SetElementName("shipped_date")
                    .SetDefaultValue(DateTime.UtcNow);

                cm.MapMember(x => x.LastUpdateDate)
                    .SetElementName("last_update_date")
                    .SetDefaultValue(DateTime.UtcNow);

                cm.MapMember(x => x.SenderAddress)
                    .SetElementName("sender_address");

                cm.MapMember(x => x.ReceiverAddress)
                    .SetElementName("receiver_address");
            });
        }
    }
}