using System.Collections.Generic;
using Demo.Dominio;
using Demo.Dominio.Repositórios;

namespace Demo.Aplicacao
{
    public class ServicoDeAplicacaoDaTransportadora : IServicoDeAplicacaoDaTransportadora
    {
        private readonly IRepositorioDeTransportadora _repositorioDeTransportadora;

        public ServicoDeAplicacaoDaTransportadora(IRepositorioDeTransportadora repositorioDeTransportadora)
        {
            _repositorioDeTransportadora = repositorioDeTransportadora;
        }

        #region IServicoDeAplicacaoDaTransportadora Members

        public IList<Transportadora> RecuperarTodasAsTransportadoras()
        {
            return _repositorioDeTransportadora.RecuperarTodos();
        }

        #endregion
    }
}