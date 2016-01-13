using Demo.Dominio;

namespace Demo.Aplicacao
{
    public interface IServicoDeAplicacaoDeCliente
    {
        Cliente RecuperarClientePorId(int id);
    }
}
