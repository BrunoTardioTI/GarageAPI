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
        private readonly MongoDbContext _context;

        public UsuarioController(MongoDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsuario([FromBody] Usuario novoUsuario)
        {
            if (novoUsuario == null)
                return BadRequest("Dados do usuário inválidos.");

            await _context.Usuarios.InsertOneAsync(novoUsuario);  // Insere o usuário no MongoDB
            return CreatedAtAction(nameof(GetUsuarioById), new { id = novoUsuario.Id }, novoUsuario);
        }

        [HttpGet("{id:length(24)}")]
        public async Task<IActionResult> GetUsuarioById(string id)
        {
            var usuario = await _context.Usuarios.Find(u => u.Id == id).FirstOrDefaultAsync();
            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }
    }
}
