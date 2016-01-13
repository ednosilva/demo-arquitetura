using Demo.Dominio;
using Demo.Dominio.Repositórios;

namespace Demo.Infra.Repositorio
{
    public class RepositorioDeContasAReceber : RepositorioBase<ContaAReceber>, IRepositorioDeContasAReceber
    {
        public RepositorioDeContasAReceber(ContextoBanco contexto) : base(contexto) { }
    }
}