using System.Collections.Generic;
using System.Linq;
using Demo.Infraestrutura.Configuracao;
using Demo.Dominio.Participantes;

namespace Demo.Infraestrutura.Repositorios.Participantes
{
    public class RepositorioDeCliente : RepositorioBase<Cliente>, IRepositorioDeCliente
    {
        public RepositorioDeCliente(ContextoBanco contexto) : base(contexto) { }

        #region IRepositorioDeCliente Members

        public IList<Cliente> RecuperarPorLimiteDeCredito(decimal limiteInicial, decimal limiteFinal)
        {
            return _contexto.Clientes
                .Where(c => c.LimiteDeCredito >= limiteInicial && c.LimiteDeCredito <= limiteFinal)
                .ToList();
        }

        #endregion
    }
}