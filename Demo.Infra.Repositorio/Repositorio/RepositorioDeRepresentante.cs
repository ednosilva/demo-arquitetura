using Demo.Dominio;
using Demo.Dominio.Repositórios;
using Demo.Infraestrutura.Configuracao;

namespace Demo.Infraestrutura.Repositorio
{
    public class RepositorioDeRepresentante : RepositorioBase<Representante>, IRepositorioDeRepresentante
    {
        public RepositorioDeRepresentante(ContextoBanco contexto) : base(contexto) { }
    }
}