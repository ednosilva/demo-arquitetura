using System.Collections.Generic;

namespace Demo.Dominio.Compartilhado
{
    public interface IRepositorioBase<TEntidade> where TEntidade : IIdentificavel
    {
        TEntidade Recuperar(int id);

        void Inserir(TEntidade obj);

        void Alterar(TEntidade obj);

        void Remover(TEntidade obj);

        void Remover(int id);
    }
}