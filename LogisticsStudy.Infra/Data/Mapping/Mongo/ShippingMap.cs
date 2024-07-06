using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Delivery;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;

namespace LogisticsStudy.Infra.Data.Mappings.Mongo;
public class ShippingMap
{
    public void Configure()
    {
        if (!BsonClassMap.IsClassMapRegistered(typeof(Shipping)))
        {
            BsonClassMap.RegisterClassMap<Shipping>(cm =>
            {
                cm.AutoMap();

                cm.MapIdMember(x => x.Id)
                    .SetIdGenerator(StringObjectIdGenerator.Instance)
                    .SetSerializer(new StringSerializer(MongoDB.Bson.BsonType.ObjectId));

                cm.MapMember(x => x.DistributionCenterId)
                    .SetElementName("distribution_center_id")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.PackagesIds)
                    .SetSerializer(new ArraySerializer<string>(new StringSerializer(BsonType.ObjectId)));

                cm.MapMember(x => x.VehicleId)
                    .SetElementName("vehicle_id")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.EmployeeId)
                    .SetElementName("employee_id")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.TrackingCode)
                    .SetElementName("tracking_code")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.Type)
                    .SetElementName("shipping_type")
                    .SetDefaultValue(ShippingTypeEnum.InternalShipping);

                cm.MapMember(x => x.Status)
                    .SetElementName("shipping_status")
                    .SetDefaultValue(ShippingStatusEnum.Wrapping);

                cm.MapMember(x => x.ShippedDate)
                    .SetElementName("shipped_date")
                    .SetDefaultValue(DateTime.UtcNow);

                cm.MapMember(x => x.LastUpdateDate)
                    .SetElementName("last_update_date")
                    .SetDefaultValue(DateTime.UtcNow);

                cm.MapMember(x => x.SenderAddressId)
                    .SetElementName("sender_address_id")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.ReceiverAddressId)
                    .SetElementName("receiver_address_id")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));
            });
        }
    }
}