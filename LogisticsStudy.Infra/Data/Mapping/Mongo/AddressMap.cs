using LogisticsStudy.Core.Models.Shared;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;

namespace LogisticsStudy.Infra.Data.Mappings.Mongo;
public class AddressMap
{
    public void Configure()
    {
        if (!BsonClassMap.IsClassMapRegistered(typeof(Address)))
        {
            BsonClassMap.RegisterClassMap<Address>(cm =>
            {
                cm.AutoMap();

                cm.MapIdMember(x => x.Id)
                  .SetIdGenerator(StringObjectIdGenerator.Instance)
                  .SetSerializer(new StringSerializer(MongoDB.Bson.BsonType.ObjectId));
                /*
                cm.MapIdMember(x => x.Street)
                    .SetElementName("street");
                cm.MapIdMember(x => x.Number)
                    .SetElementName("number");
                cm.MapIdMember(x => x.Neighborhood)
                    .SetElementName("neighborhood");
                cm.MapIdMember(x => x.City)
                    .SetElementName("city");
                cm.MapIdMember(x => x.State)
                    .SetElementName("state");
                cm.MapIdMember(x => x.ZipCode)
                    .SetElementName("zipcode");
                cm.MapIdMember(x => x.Complement)
                    .SetElementName("complement");
                */
            });
        }
    }
}