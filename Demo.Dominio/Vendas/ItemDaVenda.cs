using Demo.Dominio.Compartilhado;
using Demo.Dominio.Participantes;
using System;

namespace Demo.Dominio.Vendas
{
    public class ItemDaVenda : IIdentificavel, IEquatable<ItemDaVenda>
    {
        public Produto Produto { get; private set; }

        public decimal Quantidade { get; private set; }

        public decimal ValorUnitario { get; private set; }

        public decimal ValorTotal { get; private set; }

        //public decimal PercentualIpi { get; private set; }

        //public decimal ValorDoIpi { get; private set; }

        public Representante Representante { get; private set; }

        public string Descricao { get; private set; }

        //public decimal ValorDoIcms { get; private set; }

        //public decimal BaseDeCalculoDoIcms { get; private set; }

        //public decimal PercentualDoIcms { get; private set; }

        private ItemDaVenda() { }

        public ItemDaVenda(string descricao, int valorUnitario, int quantidade,
            Produto produto, Representante representante)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentOutOfRangeException("descricao");

            if (produto == null)
                throw new ArgumentNullException("produto");

            if (representante == null)
                throw new ArgumentNullException("representante");

            this.Descricao = descricao;
            this.ValorUnitario = valorUnitario;
            this.Quantidade = quantidade;
            this.ValorTotal = valorUnitario * quantidade;
            this.Produto = produto;
            this.Representante = representante;
        }

        public bool Equals(ItemDaVenda outro)
        {
            if (outro == null)
                return false;

            if (outro == this)
                return true;

            return this.Produto.Equals(outro.Produto);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Venda);
        }

        public override int GetHashCode()
        {
            return this.Produto.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Produto: {0}, Quantidade: {1}", this.Produto.Nome, this.Quantidade);
        }
    }
}