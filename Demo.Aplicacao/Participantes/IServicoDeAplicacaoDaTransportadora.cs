using Demo.Dominio;
using Demo.Dominio.Participantes;
using System.Collections.Generic;

namespace Demo.Aplicacao.Participantes
{
    public interface IServicoDeAplicacaoDaTransportadora
    {
        IList<Transportadora> RecuperarTodasAsTransportadoras();
    }
}
