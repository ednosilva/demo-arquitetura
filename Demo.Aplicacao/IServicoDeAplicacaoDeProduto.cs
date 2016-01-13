using Demo.Dominio;
using System.Collections.Generic;

namespace Demo.Aplicacao
{
    public interface IServicoDeAplicacaoDeProduto
    {
        void CadastrarProduto(Demo.Dominio.Produto produto);

        Produto RecuperarPorNome(string nome);

        IList<Produto> RecuperarTodosOsProdutos();

        void RemoverPorNome(string nome);
    }
}
