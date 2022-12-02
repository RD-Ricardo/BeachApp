using BeachApp.Domain.Entidades.EntidadeConfig;

namespace BeachApp.Domain.Entidades
{
    public class Pedido : EntidadeBase
    {
        public decimal PrecoTotal { get; set; }
        public int TotalItensPedido { get; set; }
        public ICollection<PedidoIten> PedidoItens { get;  set; }
    }
}
