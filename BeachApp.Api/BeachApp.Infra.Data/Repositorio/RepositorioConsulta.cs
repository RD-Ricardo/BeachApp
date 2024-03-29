﻿using BeachApp.Domain.Entidades.EntidadeConfig;
using BeachApp.Domain.Interfaces.Repositorio;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BeachApp.Infra.Data.Repositorio
{
    public class RepositorioConsulta<T> : IDisposable, IRepositorioConsulta<T> where T : class, IEntidade
    {
        private readonly BeachAppContext _db;

        public RepositorioConsulta(BeachAppContext db)
        {
            _db = db;
        }

        public async Task<bool> Any(Expression<Func<T, bool>> filtro, params string[] includes) => await Query(true, includes).AnyAsync(filtro);

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task<IEnumerable<T>> FindBy(Expression<Func<T, bool>> filtro, bool leitura = false, params string[] includes)
        {
            return await Query(leitura, includes).Where(filtro).ToListAsync();
        }

        public async Task<IEnumerable<TResult>> FindBy<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> filtro, bool leitura = false, params string[] includes)
        {
            return await Query(leitura, includes).Where(filtro).Select(select).ToListAsync();
        }

        public Task<IEnumerable<dynamic>> FindByDynamic(Expression<Func<T, dynamic>> selection, Expression<Func<T, bool>> filter, bool readOnly = false, params string[] includes)
        {
            throw new NotImplementedException();
        }

        public async Task<T> FindById(int id, bool leitura = false, params string[] includes)
        {
            return await Query(leitura, includes).FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> filtro, bool leitura = false, params string[] includes)
        {
            return await Query(leitura, includes).FirstOrDefaultAsync(filtro);
        }

        public async Task<TResult> FirstOrDefault<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> filtro, bool leitura = false, params string[] includes)
        {
            return await Query(leitura, includes).Where(filtro).Select(select).FirstOrDefaultAsync();
        }

        public Task<dynamic> FirstOrDefaultDynamic(Expression<Func<T, dynamic>> selection, Expression<Func<T, bool>> filter, bool readOnly = false, params string[] includes)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query(bool leitura = false, params string[] includes)
        {
            var query = leitura
                 ? _db.Set<T>().AsNoTracking()
                 : _db.Set<T>();

            if (includes != null &&
                includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return query;
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> filtro, bool leitura = false, params string[] includes) => Query(leitura, includes).Where(filtro);
    }
}
