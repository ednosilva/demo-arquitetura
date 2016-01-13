using Demo.Dominio;
using Demo.Dominio.Repositórios;

namespace Demo.Infra.Repositorio
{
    public class RepositorioDeRepresentante : RepositorioBase<Representante>, IRepositorioDeRepresentante
    {
        public RepositorioDeRepresentante(ContextoBanco contexto) : base(contexto) { }
    }
}