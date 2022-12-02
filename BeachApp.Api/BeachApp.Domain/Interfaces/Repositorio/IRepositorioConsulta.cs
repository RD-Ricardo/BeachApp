using BeachApp.Domain.Entidades.EntidadeConfig;
using System.Linq.Expressions;

namespace BeachApp.Domain.Interfaces.Repositorio
{
    public interface IRepositorioConsulta<TEntidade> where TEntidade : IEntidade
    {
       Task<bool> Any(Expression<Func<TEntidade, bool>> filter, params string[] includes);
       Task<IEnumerable<TEntidade>> FindBy(Expression<Func<TEntidade, bool>> filter, bool readOnly = false, params string[] includes);
       Task<IEnumerable<TResult>> FindBy<TResult>(Expression<Func<TEntidade, TResult>> selection, Expression<Func<TEntidade, bool>> filter, bool readOnly = false, params string[] includes);
       Task<IEnumerable<dynamic>> FindByDynamic(Expression<Func<TEntidade, dynamic>> selection, Expression<Func<TEntidade, bool>> filter, bool readOnly = false, params string[] includes);
       Task<TEntidade> FindById(int id, bool readOnly = false, params string[] includes);
       Task<TEntidade> FirstOrDefault(Expression<Func<TEntidade, bool>> filter, bool readOnly = false, params string[] includes);
       Task<TResult> FirstOrDefault<TResult>(Expression<Func<TEntidade, TResult>> selection, Expression<Func<TEntidade, bool>> filter, bool readOnly = false, params string[] includes);
       Task<dynamic> FirstOrDefaultDynamic(Expression<Func<TEntidade, dynamic>> selection, Expression<Func<TEntidade, bool>> filter, bool readOnly = false, params string[] includes);
       IQueryable<TEntidade> Query(bool readOnly = false, params string[] includes);
       IQueryable<TEntidade> Query(Expression<Func<TEntidade, bool>> filter, bool readOnly = false, params string[] includes);
    }
}
