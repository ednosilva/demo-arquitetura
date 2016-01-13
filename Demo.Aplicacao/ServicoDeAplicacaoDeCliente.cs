using Demo.Dominio;
using Demo.Dominio.Repositórios;

namespace Demo.Aplicacao
{
    public class ServicoDeAplicacaoDeCliente : IServicoDeAplicacaoDeCliente
    {
        private readonly IRepositorioDeCliente _repositorioDeCliente;

        public ServicoDeAplicacaoDeCliente(IRepositorioDeCliente repositorioDeCliente)
        {
            _repositorioDeCliente = repositorioDeCliente;
        }

        #region IServicoDeAplicacaoDeCliente Members

        public Cliente RecuperarClientePorId(int id)
        {
            return _repositorioDeCliente.Recuperar(id);
        }

        #endregion
    }
}