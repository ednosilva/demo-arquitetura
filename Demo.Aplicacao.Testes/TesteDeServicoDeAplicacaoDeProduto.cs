using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Sequences;
using Demo.Aplicacao.Compartilhado;
using Demo.Dominio.Vendas;
using Demo.Aplicacao.Vendas;

namespace Demo.Aplicacao.Testes
{
    //public class FabricaDeMockDeUnidadeDeTrabalho : IFabricaDeUnidadeDeTrabalho
    //{
    //    public IUnidadeDeTrabalho Criar()
    //    {
    //        return new Mock<IUnidadeDeTrabalho>().Object;
    //    }
    //}

    [TestClass]
    public class TesteDeServicoDeAplicacaoDeProduto : IFabricaDeUnidadeDeTrabalho
    {
        private Mock<IServicoDeCadastroDeProduto> mockDoServicoDeProduto;
        private Mock<IRepositorioDeProduto> mockDoRepositorioDeProduto;
        private Mock<IUnidadeDeTrabalho> mockDaUnidadeDeTrabalho;
        private ServicoDeAplicacaoDeProduto servico;

        public IUnidadeDeTrabalho Criar()
        {
            return mockDaUnidadeDeTrabalho.Object;
        }

        [TestInitialize]
        public void IniciarTestes()
        {
            mockDoServicoDeProduto = new Mock<IServicoDeCadastroDeProduto>();
            mockDoRepositorioDeProduto = new Mock<IRepositorioDeProduto>();
            mockDaUnidadeDeTrabalho = new Mock<IUnidadeDeTrabalho>();

            servico = new ServicoDeAplicacaoDeProduto(mockDoServicoDeProduto.Object, mockDoRepositorioDeProduto.Object, this);
        }

        [TestMethod]
        public void Quando_CadastrarProduto_chamar_cadastrar_do_dominio_dentro_de_uma_transacao()
        {
            // arrange
            var produto = new Produto(nome: "Camisa Polo", preço: 100m);
            using (Sequence.Create())
            {
                mockDaUnidadeDeTrabalho.Setup(_ => _.Iniciar()).InSequence();
                mockDoServicoDeProduto.Setup(_ => _.CadastrarProduto(produto)).InSequence();
                mockDaUnidadeDeTrabalho.Setup(_ => _.Completar()).InSequence();

                // act
                servico.CadastrarProduto(produto);
            }
        }


        [TestMethod]
        public void Quando_RemoverPorNome_chamar_remover_do_repositorio_dentro_de_uma_transacao()
        {
            // arrange
            using (Sequence.Create())
            {
                mockDaUnidadeDeTrabalho.Setup(_ => _.Iniciar()).InSequence();
                mockDoRepositorioDeProduto.Setup(_ => _.RemoverPorNome("produto de teste")).InSequence();
                mockDaUnidadeDeTrabalho.Setup(_ => _.Completar()).InSequence();

                // act
                servico.RemoverPorNome("produto de teste");
            }
        }

        [TestMethod]
        public void Quando_RecuperarTodosOsProdutos_recuperar_todos_do_repositorio()
        {
            // arrange
            var lista = new List<Produto>();
            mockDoRepositorioDeProduto.Setup(_ => _.RecuperarTodos()).Returns(lista);

            // act
            var retorno = servico.RecuperarTodosOsProdutos();

            // assert
            mockDoRepositorioDeProduto.VerifyAll();
            Assert.AreSame(lista, retorno);
        }

        [TestMethod]
        public void Quando_RecuperarPorNome_recuperar_por_nome_no_repositorio()
        {
            // arrange
            var produto = new Produto(nome: "Camisa Polo", preço: 100m);
            mockDoRepositorioDeProduto.Setup(_ => _.ObterProdutoPorNome("nome a ser pesquisado")).Returns(produto);

            // act
            var retorno = servico.RecuperarPorNome("nome a ser pesquisado");

            // assert
            mockDoRepositorioDeProduto.VerifyAll();
            Assert.AreSame(produto, retorno);
        }
    }
}
