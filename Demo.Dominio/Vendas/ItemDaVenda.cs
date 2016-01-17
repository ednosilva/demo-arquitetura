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

        public ItemDaVenda(Produto produto, int quantidade,
            Representante representante, string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentOutOfRangeException("descricao");

            if (produto == null)
                throw new ArgumentNullException("produto");

            if (representante == null)
                throw new ArgumentNullException("representante");

            this.Produto = produto;
            this.ValorUnitario = produto.Preço;
            this.Quantidade = quantidade;
            this.ValorTotal = produto.Preço * quantidade;
            this.Representante = representante;
            this.Descricao = descricao;
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