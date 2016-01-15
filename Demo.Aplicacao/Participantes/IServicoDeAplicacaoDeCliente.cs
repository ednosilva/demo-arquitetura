using Demo.Dominio.Participantes;

namespace Demo.Aplicacao.Participantes
{
    public interface IServicoDeAplicacaoDeCliente
    {
        Cliente RecuperarClientePorId(int id);
    }
}
