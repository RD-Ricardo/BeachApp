using BeachApp.Domain.Entidades.EntidadeConfig;

namespace BeachApp.Domain.Entidades
{
    public class ContaGuardaSol : EntidadeBase
    {
        public string NomeCliente { get; set; }
        public decimal ValorTotalConta { get; set; }
        public bool ContaAberta { get; set; }
        public int GurdaSolId { get; set; }
        public GuardaSol GuardaSol { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
