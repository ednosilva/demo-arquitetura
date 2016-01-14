using System.Collections.Generic;
using Demo.Dominio;
using Demo.Dominio.Servicos;
using Demo.Dominio.Repositórios;
using Demo.Aplicacao.Compartilhado;

namespace Demo.Aplicacao
{
    public class ServicoDeAplicacaoDeProduto : IServicoDeAplicacaoDeProduto
    {
        private readonly IRepositorioDeProduto _repositorioDeProduto;
        private readonly IServicoDeCadastroDeProduto _servicoDeCadastroDeProduto;
        private readonly IFabricaDeUnidadeDeTrabalho _fabricaDeUnidadeDeTrabalho;

        public ServicoDeAplicacaoDeProduto(IServicoDeCadastroDeProduto servicoDeCadastroDeProduto,
            IRepositorioDeProduto repositorioDeProduto, IFabricaDeUnidadeDeTrabalho fabricaDeUnidadeDeTrabalho)
        {
            _servicoDeCadastroDeProduto = servicoDeCadastroDeProduto;
            _repositorioDeProduto = repositorioDeProduto;
            _fabricaDeUnidadeDeTrabalho = fabricaDeUnidadeDeTrabalho;
        }

        #region IServicoDeAplicacaoDeProduto Members

        public virtual void CadastrarProduto(Produto produto)
        {
            using (var unidadeDeTrabalho = _fabricaDeUnidadeDeTrabalho.Criar())
            {
                unidadeDeTrabalho.Iniciar();

                _servicoDeCadastroDeProduto.CadastrarProduto(produto);

                unidadeDeTrabalho.Completar();
            }
        }

        public virtual IList<Produto> RecuperarTodosOsProdutos()
        {
            return _repositorioDeProduto.RecuperarTodos();
        }

        public virtual Produto RecuperarPorNome(string nome)
        {
            return _repositorioDeProduto.ObterProdutoPorNome(nome);
        }

        public virtual void RemoverPorNome(string nome)
        {
            using (var unidadeDeTrabalho = _fabricaDeUnidadeDeTrabalho.Criar())
            {
                unidadeDeTrabalho.Iniciar();

                _repositorioDeProduto.RemoverPorNome(nome);

                unidadeDeTrabalho.Completar();
            }
        }

        #endregion
    }
}