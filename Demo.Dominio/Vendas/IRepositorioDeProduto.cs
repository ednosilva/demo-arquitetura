using Demo.Dominio.Compartilhado;
using System.Collections.Generic;

namespace Demo.Dominio.Vendas
{
    public interface IRepositorioDeProduto : IRepositorioBase<Produto>
    {
        Produto ObterProdutoPorNome(string nome);

        IList<Produto> RecuperarTodos();

        bool ProdutoJáExiste(string nome);

        void RemoverPorNome(string nome);
    }
}