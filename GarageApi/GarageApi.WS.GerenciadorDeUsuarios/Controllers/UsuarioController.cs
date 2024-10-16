using Garage.API.Domain.Models;
using GarageApi.WS.GerenciadorDeUsuarios.Repositorio;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace GarageApi.WS.GerenciadorDeUsuarios.Controllers
{

  
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IMongoCollection<Usuario> _usuarios;

        public UsuarioController(MongoDbConnection mongoDbConnection)
        {
            // Obtemos o banco de dados e a coleção de usuários
            var database = mongoDbConnection.GetDatabase("GarageAppDb");
            _usuarios = database.GetCollection<Usuario>("Usuario");
        }

        [HttpPost]
        public ActionResult<Usuario> CreateUsuario([FromBody] Usuario novoUsuario)
        {
            if (novoUsuario == null)
            {
                return BadRequest("Usuário não pode ser nulo.");
            }

            // Adiciona o novo usuário à coleção
            _usuarios.InsertOne(novoUsuario);
            return CreatedAtAction(nameof(CreateUsuario), new { id = novoUsuario.Id }, novoUsuario);
        }
    }
}

