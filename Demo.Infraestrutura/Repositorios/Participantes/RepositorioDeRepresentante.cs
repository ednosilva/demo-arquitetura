using Demo.Dominio.Participantes;
using Demo.Infraestrutura.Configuracao;

namespace Demo.Infraestrutura.Repositorios.Participantes
{
    public class RepositorioDeRepresentante : RepositorioBase<Representante>, IRepositorioDeRepresentante
    {
        public RepositorioDeRepresentante(ContextoBanco contexto) : base(contexto) { }
    }
}