namespace Demo.Infraestrutura.Configuracao
{
    public interface IGerenciadorDeContexoBanco
    {
        ContextoBanco Contexto { get; }

        void Finalizar();
    }
}