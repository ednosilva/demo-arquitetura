using System.Collections.Generic;
using System.Linq;
using Demo.Dominio;
using Demo.Dominio.Repositórios;
using Demo.Infraestrutura.Configuracao;

namespace Demo.Infraestrutura.Repositorio
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