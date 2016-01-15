using System.Collections.Generic;
using System.Linq;
using Demo.Infraestrutura.Configuracao;
using Demo.Dominio.Participantes;

namespace Demo.Infraestrutura.Repositorios.Participantes
{
    public class RepositorioDeTransportadora : RepositorioBase<Transportadora>, IRepositorioDeTransportadora
    {
        public RepositorioDeTransportadora(ContextoBanco contexto) : base(contexto) { }

        #region IRepositorioDeTransportadora Members

        public IList<Transportadora> RecuperarTodos()
        {
            return _contexto.Transportadoras.ToList();
        }

        #endregion
    }
}