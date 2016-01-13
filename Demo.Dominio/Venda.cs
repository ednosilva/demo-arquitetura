using Demo.Dominio.Compartilhado;
using System;
using System.Collections.Generic;

namespace Demo.Dominio
{
    public class Venda : IIdentificavel
    {
        public Transportadora Transportadora { get; private set; }

        public Transportadora Despachante { get; private set; }

        public virtual Cliente Cliente { get; private set; }

        public IList<Comissao> Comissoes { get; private set; }

        public IList<ContaAReceber> ContasAReceber { get; private set; }

        public int NumeroDaNota { get; private set; }

        public virtual DateTime DataDaEmissao { get; private set; }

        public virtual DateTime DataDaSaida { get; private set; }

        public virtual decimal ValorTotal { get; private set; }

        public virtual IList<ItemDaVenda> ItensDaVenda { get; private set; }

        public string Descricao { get; private set; }

        public bool FoiImpressa { get; private set; }

        public DateTime? DataDaImpressao { get; private set; }

        public string ChaveDeAcessoNFE { get; private set; }

        private Venda() { }

        public Venda(Cliente cliente, int numeroDaNota, DateTime dataDaEmissao,
            DateTime dataDaSaida, int valorTotal, string descricao)
        {
            this.Cliente = cliente;
            this.NumeroDaNota = numeroDaNota;
            this.DataDaEmissao = dataDaEmissao;
            this.DataDaSaida = dataDaSaida;
            this.ValorTotal = valorTotal;
            this.Descricao = descricao;

            this.Comissoes = new List<Comissao>();
            this.ContasAReceber = new List<ContaAReceber>();
            this.ItensDaVenda = new List<ItemDaVenda>();
        }

        public virtual IList<Comissao> GerarComissoes()
        {
            return null;
        }

        public virtual IList<ContaAReceber> GerarContasAReceber()
        {
            return null;
        }

        public void AdicionarItem(ItemDaVenda itemDaVenda)
        {
            if (itemDaVenda == null)
                throw new ArgumentNullException("itemDaVenda");

            this.ItensDaVenda.Add(itemDaVenda);
        }
    }
}