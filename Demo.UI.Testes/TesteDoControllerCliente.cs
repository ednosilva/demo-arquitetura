using System.Web.Mvc;
using Demo.Dominio;
using Demo.UI.Mvc.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Demo.Aplicacao;
using Demo.Aplicacao.Participantes;
using Demo.Dominio.Participantes;

namespace Demo.UI.Testes
{
    [TestClass]
    public class TesteDoControllerCliente
    {
        private ClienteController controller;
        private Mock<IServicoDeAplicacaoDeCliente> mockServicoDeAplicacaoDeCliente;

        [TestInitialize]
        public void IniciarTestes()
        {
            mockServicoDeAplicacaoDeCliente = new Mock<IServicoDeAplicacaoDeCliente>();
            controller = new ClienteController(mockServicoDeAplicacaoDeCliente.Object);
        }

        [TestMethod]
        public void Quando_buscar_um_cliente_inexistente_devolve_em_branco()
        {
            // arrange
            setupRecuperarClientePorId(null);

            // act
            ActionResult actionResult = controller.RecuperarClientePorId(1);

            // assert
            var emptyResult = actionResult as EmptyResult;
            Assert.IsNotNull(emptyResult);
        }

        [TestMethod]
        public void Quando_buscar_um_cliente_existente_devolve_somente_o_nome_dele()
        {
            // arrange
            const string nomeDoCliente = "Cliente de Teste";
            var cliente = new Cliente(nome: nomeDoCliente, limiteDeCredito: 1000, inscricao: string.Empty);
            setupRecuperarClientePorId(cliente);

            // act
            ActionResult actionResult = controller.RecuperarClientePorId(1);

            // assert
            var jsonResult = actionResult as JsonResult;
            Assert.IsNotNull(jsonResult);

            Assert.AreEqual(nomeDoCliente, jsonResult.Data.ToString());
        }

        private void setupRecuperarClientePorId(Cliente cliente)
        {
            mockServicoDeAplicacaoDeCliente.Setup(x => x.RecuperarClientePorId(It.IsAny<int>()))
                .Returns(cliente);
        }
    }
}