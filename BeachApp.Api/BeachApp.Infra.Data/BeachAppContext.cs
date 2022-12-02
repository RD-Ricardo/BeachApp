using BeachApp.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace BeachApp.Infra.Data
{
    public class BeachAppContext : DbContext
    {
        public BeachAppContext(DbContextOptions<BeachAppContext> options) : base(options)
        {
                
        }

        public DbSet<CategoriaProduto> CategoriaProdutos { get; set; }
        public DbSet<ContaGuardaSol> ContaGuardaSols { get; set; }
        public DbSet<ContaUsuario> ContaUsuarios { get; set; }
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public DbSet<GuardaSol> GuardaSols { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoIten> PedidoItens { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
