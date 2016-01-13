namespace Demo.Infra.Repositorio.Configuracao
{
    public interface IGerenciadorDeRepositorio
    {
        ContextoBanco Contexto { get; }

        void Finalizar();
    }
}