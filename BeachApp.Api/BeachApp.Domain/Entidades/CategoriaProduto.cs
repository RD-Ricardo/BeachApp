using BeachApp.Domain.Entidades.EntidadeConfig;

namespace BeachApp.Domain.Entidades
{
    public class CategoriaProduto : EntidadeBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
