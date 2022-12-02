using BeachApp.Domain.Entidades.EntidadeConfig;
using System.Runtime.CompilerServices;

namespace BeachApp.Domain.Entidades
{
    public class Produto : EntidadeBase
    {
        public string Nome{ get; set; }
        public string Observacao { get; set; }
        public string ImagemUrl{ get; set; }
        public decimal Preco { get; set; }
        public int CategoriaProdutoId { get; set; }
        public CategoriaProduto CategoriaProduto { get; set; }
    }
}
