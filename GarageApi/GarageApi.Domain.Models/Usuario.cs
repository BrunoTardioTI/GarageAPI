using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Garage.API.Domain.Models
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public Guid IdGuid { get; set; } = Guid.NewGuid();
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        //public List<PerfilUsuario> Perfis { get; set; } = new List<PerfilUsuario>();
    }

}
