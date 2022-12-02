using BeachApp.Domain.Entidades.EntidadeConfig;

namespace BeachApp.Domain.Entidades
{
    public class PedidoIten : EntidadeBase
    {
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
