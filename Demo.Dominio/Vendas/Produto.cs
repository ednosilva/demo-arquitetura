using Demo.Dominio.Compartilhado;
using System;

namespace Demo.Dominio.Vendas
{
    public class Produto : IIdentificavel, IEquatable<Produto>
    {
        public string Nome { get; private set; }

        public decimal Preço { get; private set; }

        private Produto() { }

        public Produto(string nome, decimal preço)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentOutOfRangeException("nome");

            if (preço < 0)
                throw new ArgumentOutOfRangeException("preço");

            this.Nome = nome;
            this.Preço = preço;
        }

        public bool Equals(Produto outro)
        {
            if (outro == null)
                return false;

            if (outro == this)
                return true;

            return this.Nome.Equals(outro.Nome);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Produto);
        }

        public override int GetHashCode()
        {
            return this.Nome.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Nome, this.Preço);
        }
    }
}