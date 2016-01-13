using Demo.Dominio;
using System.Collections.Generic;

namespace Demo.Aplicacao
{
    public interface IServicoDeAplicacaoDaTransportadora
    {
        IList<Transportadora> RecuperarTodasAsTransportadoras();
    }
}
