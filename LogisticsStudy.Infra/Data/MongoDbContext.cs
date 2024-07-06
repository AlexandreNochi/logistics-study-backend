using LogisticsStudy.Core.Models.Delivery;
using LogisticsStudy.Core.Models.Documents;
using LogisticsStudy.Core.Models.Shared;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace LogisticsStudy.Infra.Data;
public class MongoDbContext
{
    private readonly IMongoDatabase _database;

    //string connectionString, string databaseName
    // public MongoDbContext(IOptions<MongoSettings> options)
    // {
    //     var client = new MongoClient(options.Value.ConnectionString);
    //     _database = client.GetDatabase(options.Value.DatabaseName);
    // }

    public MongoDbContext(IConfiguration configuration)
    {
        var client = new MongoClient(configuration.GetConnectionString("MongoDb"));
        _database = client.GetDatabase(configuration["MongoDbSettings:DatabaseName"]);
        // _database = client.GetDatabase(settings.Value.DatabaseName);
    }

    public IMongoCollection<Address> Products => _database.GetCollection<Address>("address");
    public IMongoCollection<Package> Packages => _database.GetCollection<Package>("packages");
    public IMongoCollection<Shipping> Shippings => _database.GetCollection<Shipping>("shippings");
    public IMongoCollection<Insurance> Insurances => _database.GetCollection<Insurance>("insurances");
    public IMongoCollection<Invoice> Invoices => _database.GetCollection<Invoice>("invoices");
}