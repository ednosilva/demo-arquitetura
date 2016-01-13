using Demo.Dominio.Compartilhado;
using System.Collections.Generic;

namespace Demo.Dominio.Repositórios
{
    public interface IRepositorioDeTransportadora : IRepositorioBase<Transportadora>
    {
        IList<Transportadora> RecuperarTodos();
    }
}