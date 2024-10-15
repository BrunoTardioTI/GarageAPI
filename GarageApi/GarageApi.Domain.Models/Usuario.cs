namespace Garage.API.Domain.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<PerfilUsuario> Perfis { get; set; } = new List<PerfilUsuario>();

        public DateTime DataCadastro { get; set; } = DateTime.UtcNow;
    }

}
