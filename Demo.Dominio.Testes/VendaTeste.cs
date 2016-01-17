using Demo.Dominio.Participantes;
using Demo.Dominio.Vendas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Dominio.Testes
{
    [TestClass]
    public class VendaTeste
    {
        [TestMethod]
        public void Quando_criar_uma_Venda_as_Comissões_devem_ser_geradas()
        {
            // arrage
            var produto1 = new Produto("H2OH 500 ml", 3.00m);
            var produto2 = new Produto("H2OH 1,5 l", 4.50m);
            var produto3 = new Produto("Café Pilão 500 g", 8.00m);
            var representante1 = new Representante("234567", "Antonio de Souza", 2);
            var representante2 = new Representante("345678", "Rafael de Moura", 3);
            var cliente = new Cliente("123456", 1000, "José da Silva");
            var item1 = new ItemDaVenda(produto1, 2, representante1, "Item 1");
            var item2 = new ItemDaVenda(produto2, 5, representante1, "Item 2");
            var item3 = new ItemDaVenda(produto3, 1, representante2, "Item 3");
            var itensDaNota = new HashSet<ItemDaVenda> { item1, item2, item3 };
            
            // act
            var venda = new Venda(cliente, 98765432, new DateTime(2016, 03, 10),
                new DateTime(2016, 03, 10), "3 Itens", itensDaNota);

            // assert
            Assert.AreEqual(2, venda.Comissoes.Count);

            var comissao1 = venda.Comissoes.Single(c => c.Representante.Equals(representante1));
            Assert.AreEqual(28.50m, comissao1.ValorDaVenda);
            Assert.AreEqual(0.57m, comissao1.Valor);

            var comissao2 = venda.Comissoes.Single(c => c.Representante.Equals(representante2));
            Assert.AreEqual(8.00m, comissao2.ValorDaVenda);
            Assert.AreEqual(0.24m, comissao2.Valor);
        }
    }
}
