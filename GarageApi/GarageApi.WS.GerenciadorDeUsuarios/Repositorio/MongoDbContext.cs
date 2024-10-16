using Garage.API.Domain.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace GarageApi.WS.GerenciadorDeUsuarios.Repositorio
{

    public class MongoDbConnection
    {
        private readonly MongoClient _client;

        public MongoDbConnection(string connectionString)
        {
            // Criação de configurações a partir da URI de conexão
            var settings = MongoClientSettings.FromConnectionString(connectionString);

            // Configurar a versão da API do servidor
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            // Criar um novo cliente e conectar ao servidor
            _client = new MongoClient(settings);
        }

        public IMongoDatabase GetDatabase(string databaseName)
        {
            return _client.GetDatabase(databaseName);
        }

        public void TestConnection()
        {
            try
            {
                // Envia um comando de ping para o banco de dados "admin"
                var result = _client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while connecting to MongoDB: " + ex.Message);
            }
        }
    }
}