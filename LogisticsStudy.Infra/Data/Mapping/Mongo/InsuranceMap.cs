using LogisticsStudy.Core.Enums;
using LogisticsStudy.Core.Models.Documents;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;

namespace LogisticsStudy.Infra.Data.Mappings.Mongo;
public class InsuranceMap
{
    public void Configure()
    {
        if (!BsonClassMap.IsClassMapRegistered(typeof(Insurance)))
        {
            BsonClassMap.RegisterClassMap<Insurance>(cm =>
            {
                cm.AutoMap();

                cm.MapIdMember(x => x.Id)
                  .SetIdGenerator(StringObjectIdGenerator.Instance)
                  .SetSerializer(new StringSerializer(MongoDB.Bson.BsonType.ObjectId));

                cm.MapMember(x => x.InsuranceNumber)
                    .SetElementName("insurance_number");

                cm.MapMember(x => x.InsuredValue)
                    .SetElementName("insured_value");

                cm.MapMember(x => x.VehicleId)
                    .SetElementName("vehicle_id")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.EmployeeId)
                    .SetElementName("employee_id")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.TargetType)
                    .SetElementName("insurance_target_type")
                    .SetDefaultValue(InsuranceTargetTypeEnum.Shipping);

                cm.MapMember(x => x.TargetId)
                    .SetElementName("target_id")
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));

                cm.MapMember(x => x.Status)
                    .SetElementName("insurance_status")
                    .SetDefaultValue(InsuranceStatusEnum.awaitingPayment);

                cm.MapMember(x => x.Type)
                    .SetElementName("insurance_type")
                    .SetDefaultValue(InsuranceTypeEnum.InternalInsurance);

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