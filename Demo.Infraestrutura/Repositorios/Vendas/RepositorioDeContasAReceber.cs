using Demo.Dominio.Vendas;
using Demo.Infraestrutura.Configuracao;

namespace Demo.Infraestrutura.Repositorios.Vendas
{
    public class RepositorioDeContasAReceber : RepositorioBase<ContaAReceber>, IRepositorioDeContasAReceber
    {
        public RepositorioDeContasAReceber(ContextoBanco contexto) : base(contexto) { }
    }
}