using Garage.API.Domain.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GarageApi.WS.GerenciadorDeUsuarios.Repositorio
{
    public class MongoDBSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IOptions<MongoDBSettings> settings)
        {
            var connectionString = settings.Value.ConnectionString;
            var databaseName = settings.Value.DatabaseName;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("A string de conexão não foi encontrada.");
            }

            var mongoClient = new MongoClient(connectionString);
            _database = mongoClient.GetDatabase(databaseName);
        }

        public IMongoCollection<Usuario> Usuarios => _database.GetCollection<Usuario>("Usuarios");
    }
}
