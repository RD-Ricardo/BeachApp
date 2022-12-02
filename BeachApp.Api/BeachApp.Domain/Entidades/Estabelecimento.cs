using BeachApp.Domain.Entidades.EntidadeConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachApp.Domain.Entidades
{
    public class Estabelecimento : EntidadeBase
    {
        public string  Nome { get; set; }
        public bool Ativo { get; set; }
        public int ContaUsuarioId { get; set; }
        public ContaUsuario ContaUsuario { get; set; }
        public ICollection<GuardaSol> GuardaSols { get; set; }
    }
}
