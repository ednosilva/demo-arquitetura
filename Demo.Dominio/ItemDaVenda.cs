using Demo.Dominio.Compartilhado;

namespace Demo.Dominio
{
    public class ItemDaVenda : IIdentificavel
    {
        public Produto Produto { get; private set; }

        public decimal Quantidade { get; private set; }

        public decimal ValorUnitario { get; private set; }

        public decimal ValorTotal { get; private set; }

        public decimal PercentualIPI { get; private set; }

        public decimal ValorDoIPI { get; private set; }

        public Representante Representante { get; private set; }

        public string Descricao { get; private set; }

        public decimal ValorDoICMS { get; private set; }

        public decimal BaseDeCalculoDoICMS { get; private set; }

        public decimal PercentualDoICMS { get; private set; }

        private ItemDaVenda() { }

        public ItemDaVenda(string descricao, int valorUnitario, int quantidade,
            Produto produto, Representante representante)
        {
            this.Descricao = descricao;
            this.ValorUnitario = valorUnitario;
            this.Quantidade = quantidade;
            this.ValorTotal = valorUnitario * quantidade;
            this.Produto = produto;
            this.Representante = representante;
        }
    }
}