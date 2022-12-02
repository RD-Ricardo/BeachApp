using BeachApp.Domain.Entidades.EntidadeConfig;

namespace BeachApp.Domain.Entidades.EntidadeConfig
{
    public abstract class EntidadeBase : IEntidade
    {
        public int Id { get; set; }
        public DateTime  DataCriacao { get; set; } = DateTime.Now;
        public DateTime  DataAlteracao{ get; set; }
    }
}