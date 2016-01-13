using System;
namespace Demo.Aplicacao.Compartilhado
{
    public interface IUnidadeDeTrabalho : IDisposable
    {
        void Iniciar();

        void Completar();
    }
}