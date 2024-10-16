using Garage.API.Domain.Models;
using MongoDB.Driver;

namespace GarageApi.WS.GerenciadorDeUsuarios.Repositorio
{
    public class MongoDbContext
    {

        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetSection("MongoDBSettings:ConnectionString").Value);
            _database = client.GetDatabase(configuration.GetSection("MongoDBSettings:DatabaseName").Value);
        }

        public IMongoCollection<Usuario> Usuarios => _database.GetCollection<Usuario>("Usuarios");

    }
}
