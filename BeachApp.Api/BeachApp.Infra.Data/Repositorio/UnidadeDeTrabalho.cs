using BeachApp.Domain.Interfaces.Repositorio;

namespace BeachApp.Infra.Data.Repositorio
{
    public class UnidadeDeTrabalho : IDisposable, IUnidadeDeTrabalho
    {
        private readonly BeachAppContext _contexto;

        private bool _disposed;
        public UnidadeDeTrabalho(BeachAppContext contexto)
        {
            _contexto = contexto;
        }

        public async Task Commit()
        {
            await _contexto.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disponsing)
        {
            if (!_disposed && disponsing)
            {
                _contexto.Dispose();
            }
            _disposed = true;
        }
    }
}
