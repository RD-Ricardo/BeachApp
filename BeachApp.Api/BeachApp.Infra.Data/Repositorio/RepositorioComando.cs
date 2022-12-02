using BeachApp.Domain.Entidades.EntidadeConfig;
using BeachApp.Domain.Interfaces.Repositorio;
using System.Linq.Expressions;

namespace BeachApp.Infra.Data.Repositorio
{
    public class RepositorioComando<T> : IRepositorioComando<T> where T : class, IEntidade
    {
        private readonly BeachAppContext _db;

        public RepositorioComando(BeachAppContext db)
        { 
            _db = db;
        }

        public void Delete<TKey>(TKey key)
        {
            var entity = _db.Set<T>().Find(key);

            if (entity != null)
                Delete(entity);
        }

        public void Delete(T entidade)
        {
            _db.Set<T>().Remove(entidade);
        }

        public void Delete(Expression<Func<T, bool>> entidade)
        {
            var entity = _db.Set<T>().FirstOrDefault(entidade);

            if (entity != null)
                Delete(entity);
        }

        public void DeleteRange(Expression<Func<T, bool>> filtro)
        {
            var entities = _db.Set<T>().Where(filtro);
            _db.Set<T>().RemoveRange(entities);
        }

        public async Task<T> Insert(T entidade)
        {
            var entry = await _db.Set<T>().AddAsync(entidade);
            return entry.Entity;
        }

        public async Task InsertRange(IEnumerable<T> entidades)
        {
            await _db.Set<T>().AddRangeAsync(entidades);
        }


        public void Update(T entidade)
        {
            _db.Set<T>().Update(entidade);
        }

        public void UpdateRange(IEnumerable<T> entidades)
        {
            _db.Set<T>().UpdateRange(entidades);
        }
    }
}
