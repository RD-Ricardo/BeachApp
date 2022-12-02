using BeachApp.Domain.Entidades.EntidadeConfig;

namespace BeachApp.Domain.Entidades
{
    public class GuardaSol : EntidadeBase
    {
        public string Nome { get; set; }   
        public string Numero { get; set; }
        public string Cor { get; set; }
        public  bool Ativo  { get; set; }
        public int EstabelecimentoId { get; set; }
        public Estabelecimento Estabelecimento { get; set; }
        public ICollection<ContaGuardaSol> ContaGuardaSol { get; set; }
    }
}
