using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Documents;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;

namespace LogisticsStudy.Infra.Data.Mappings.Mongo;
public class InvoiceMap
{
    public void Configure()
    {
        if (!BsonClassMap.IsClassMapRegistered(typeof(Invoice)))
        {
            BsonClassMap.RegisterClassMap<Invoice>(cm =>
            {
                cm.AutoMap();

                cm.MapIdMember(x => x.Id)
                  .SetIdGenerator(StringObjectIdGenerator.Instance)
                  .SetSerializer(new StringSerializer(MongoDB.Bson.BsonType.ObjectId));

                cm.MapMember(x => x.InvoiceNumber)
                    .SetElementName("invoice_number");

                cm.MapMember(x => x.TotalValue)
                    .SetElementName("total_value");

                cm.MapMember(x => x.TargetType)
                    .SetElementName("invoice_target_type")
                    .SetDefaultValue(InvoiceTargetTypeEnum.Shipping);

                cm.MapMember(x => x.TargetId)
                    .SetElementName("target_id")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.InsuranceId)
                    .SetElementName("insurance_id")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.SenderId)
                    .SetElementName("sender_id")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.RecipientId)
                    .SetElementName("recipient_id")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.OriginAddress)
                    .SetElementName("origin_address");

                cm.MapMember(x => x.DestinationAddress)
                    .SetElementName("destination_address");

                cm.MapMember(x => x.Status)
                    .SetElementName("insurance_status")
                    .SetDefaultValue(InsuranceStatusEnum.awaitingPayment);

                cm.MapMember(x => x.ValidityStartDate)
                    .SetElementName("validity_start_date")
                    .SetDefaultValue(DateTime.UtcNow);

                cm.MapMember(x => x.ValidityEndDate)
                    .SetElementName("validity_end_date")
                    .SetDefaultValue(DateTime.UtcNow);

            });
        }
    }
}