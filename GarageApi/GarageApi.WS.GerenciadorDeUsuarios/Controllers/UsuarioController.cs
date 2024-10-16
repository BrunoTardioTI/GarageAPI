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
            // Obtemos o banco de dados e a cole��o de usu�rios
            var database = mongoDbConnection.GetDatabase("GarageAppDb");
            _usuarios = database.GetCollection<Usuario>("Usuario");
        }

        [HttpPost]
        public ActionResult<Usuario> CreateUsuario([FromBody] Usuario novoUsuario)
        {
            if (novoUsuario == null)
            {
                return BadRequest("Usu�rio n�o pode ser nulo.");
            }

            // Adiciona o novo usu�rio � cole��o
            _usuarios.InsertOne(novoUsuario);
            return CreatedAtAction(nameof(CreateUsuario), new { id = novoUsuario.Id }, novoUsuario);
        }
    }
}

