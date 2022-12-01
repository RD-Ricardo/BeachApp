namespace BeachApp.Domain.Entidades.EntidadeBase
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime  DataCriacao { get; set; } = DateTime.Now;
        public DateTime  DataAlteracao{ get; set; }
    }
}