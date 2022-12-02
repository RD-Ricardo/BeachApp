using System.Linq.Expressions;

namespace BeachApp.Domain.Interfaces.Repositorio
{
    public interface IRepositorioComando<TEntidade> where TEntidade : class
    {
        void Delete<TKey>(TKey key);
        void Delete(TEntidade entidade);
        void Delete(Expression<Func<TEntidade, bool>> entidade);
        void DeleteRange(Expression<Func<TEntidade, bool>> filter);
        Task<TEntidade> Insert(TEntidade entidade);
        Task InsertRange(IEnumerable<TEntidade> entidades);
        void Update(TEntidade entidade);
        void UpdateRange(IEnumerable<TEntidade> entidades);
    }
}
