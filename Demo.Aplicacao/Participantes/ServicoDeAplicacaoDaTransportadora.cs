using System.Collections.Generic;
using Demo.Dominio.Participantes;

namespace Demo.Aplicacao.Participantes
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