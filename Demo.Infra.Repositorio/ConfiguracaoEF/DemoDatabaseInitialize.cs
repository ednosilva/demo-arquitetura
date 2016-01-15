using System;
using System.Collections.Generic;
using System.Data.Entity;
using Demo.Dominio.Vendas;
using Demo.Dominio.Participantes;

namespace Demo.Infraestrutura.Configuracao
{
    public class DemoDatabaseInitialize : DropCreateDatabaseIfModelChanges<ContextoBanco>
    {
        protected override void Seed(ContextoBanco context)
        {
            context.Produtos.Add(new Produto
                                     (
                                         codigoDeBarras: 1234,
                                         nome: "Coca-cola Lata",
                                         preço: 2m
                                     ));
            context.Produtos.Add(new Produto
                                     (
                                         codigoDeBarras: 4567,
                                         nome: "Coca-cola garrafa 290ml",
                                         preço: 1.5m
                                     ));
            context.Produtos.Add(new Produto
                                     (
                                         codigoDeBarras: 7890,
                                         nome: "Coca-cola garrafa 600ml",
                                         preço: 2.5m
                                     ));
            context.Produtos.Add(new Produto
                                     (
                                         codigoDeBarras: 1356,
                                         nome: "Coca-cola garrafa 1L",
                                         preço: 3m
                                     ));
            context.Produtos.Add(new Produto
                                     (
                                         codigoDeBarras: 4680,
                                         nome: "Coca-cola garrafa 2L",
                                         preço: 4m
                                     ));

            var produto = new Produto (codigoDeBarras: 9876543, nome: "Coca-Cola", preço: 4m);
            var cliente = new Cliente (inscricao: "000.000.191-00", limiteDeCredito: 200000, nome: "Álvaro Brognoli");
            var representante = new Representante(Inscricao: "001.910.000-00", Nome: "Renan", PercentualDeComissao: 5);
            var venda = new Venda
                            (
                                cliente: cliente,
                                numeroDaNota: 123456789,
                                dataDaEmissao: new DateTime(2011, 12, 31),
                                dataDaSaida: new DateTime(2011, 12, 31),
                                valorTotal: 120,
                                descricao: "Compra de coca-cola para o time."
                            );

            venda.AdicionarItem(new ItemDaVenda
                                    (
                                        descricao: "Coca-cola 2L",
                                        valorUnitario: 4,
                                        quantidade: 2,
                                        produto: produto,
                                        representante: representante
                                    )
                                );

            context.Vendas.Add(venda);

            context.Transportadoras.Add(new Transportadora
                                            (
                                                inscricao: "12345678",
                                                nome: "Ouro Negro"
                                            ));
            context.Transportadoras.Add(new Transportadora
                                            (
                                                inscricao: "893843",
                                                nome: "Jolivan"
                                            ));
            context.Transportadoras.Add(new Transportadora
                                            (
                                                inscricao: "937202",
                                                nome: "Mercurio"
                                            ));

            context.SaveChanges();

            base.Seed(context);
        }
    }
}