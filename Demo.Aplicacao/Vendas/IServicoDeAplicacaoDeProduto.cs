using Demo.Dominio.Vendas;
using System.Collections.Generic;

namespace Demo.Aplicacao.Vendas
{
    public interface IServicoDeAplicacaoDeProduto
    {
        void CadastrarProduto(Produto produto);

        Produto RecuperarPorNome(string nome);

        IList<Produto> RecuperarTodosOsProdutos();

        void RemoverPorNome(string nome);
    }
}
