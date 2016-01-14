﻿using System;
using System.Collections.Generic;
using System.Linq;
using Demo.Dominio;
using Demo.Dominio.Repositórios;
using Demo.Infraestrutura.Configuracao;

namespace Demo.Infraestrutura.Repositorio
{
    public class RepositorioDeProduto : RepositorioBase<Produto>, IRepositorioDeProduto
    {
        public RepositorioDeProduto(ContextoBanco contexto) : base(contexto) { }

        #region IRepositorioDeProduto Members

        public Produto ObterProdutoPorNome(string nome)
        {
            return _contexto.Produtos.Single(x => x.Nome == nome);
        }

        public IList<Produto> RecuperarTodos()
        {
            return _contexto.Produtos.ToList();
        }

        public bool ProdutoJáExiste(string nome)
        {
            return _contexto.Produtos.Any(x =>
                                          x.Nome.Equals(nome, StringComparison.InvariantCultureIgnoreCase));
        }

        public void RemoverPorNome(string nome)
        {
            Produto produto = ObterProdutoPorNome(nome);
            _contexto.Produtos.Remove(produto);
        }

        #endregion
    }
}