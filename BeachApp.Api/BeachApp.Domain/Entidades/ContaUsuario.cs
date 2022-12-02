using BeachApp.Domain.Entidades.EntidadeConfig;

namespace BeachApp.Domain.Entidades
{
    public class ContaUsuario : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Telefone { get; set; }
        public ICollection<Estabelecimento> Estabelecimentos { get; set; }
    }
}
