using Demo.Dominio;
using Demo.Dominio.Repositórios;
using Demo.Infraestrutura.Configuracao;

namespace Demo.Infraestrutura.Repositorio
{
    public class RepositorioDeContasAReceber : RepositorioBase<ContaAReceber>, IRepositorioDeContasAReceber
    {
        public RepositorioDeContasAReceber(ContextoBanco contexto) : base(contexto) { }
    }
}