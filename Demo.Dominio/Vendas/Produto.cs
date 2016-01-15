using Demo.Dominio.Compartilhado;
using System;

namespace Demo.Dominio.Vendas
{
    public class Produto : IIdentificavel
    {
        public string Nome { get; private set; }

        public decimal Preço { get; private set; }

        private Produto() { }

        public Produto(int codigoDeBarras, string nome, decimal preço)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentOutOfRangeException("nome");

            if (preço < 0)
                throw new ArgumentOutOfRangeException("preço");

            this.Nome = nome;
            this.Preço = preço;
        }
    }
}