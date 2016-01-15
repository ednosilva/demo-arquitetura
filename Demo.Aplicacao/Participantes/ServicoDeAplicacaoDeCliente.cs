using Demo.Dominio.Participantes;

namespace Demo.Aplicacao.Participantes
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