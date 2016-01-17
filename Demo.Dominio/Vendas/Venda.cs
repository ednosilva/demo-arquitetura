using Demo.Dominio.Compartilhado;
using Demo.Dominio.Participantes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Dominio.Vendas
{
    public class Venda : IIdentificavel
    {
        public Transportadora Transportadora { get; private set; }

        //public Transportadora Despachante { get; private set; }

        public virtual Cliente Cliente { get; private set; }

        public IList<Comissao> Comissoes { get; private set; }

        public IList<ContaAReceber> ContasAReceber { get; private set; }

        public int NumeroDaNota { get; private set; }

        public virtual DateTime DataDaEmissao { get; private set; }

        public virtual DateTime DataDaSaida { get; private set; }

        public virtual decimal ValorTotal { get; private set; }

        public virtual IList<ItemDaVenda> ItensDaVenda { get; private set; }

        public string Descricao { get; private set; }

        //public bool FoiImpressa { get; private set; }

        //public DateTime? DataDaImpressao { get; private set; }

        //public string ChaveDeAcessoNfe { get; private set; }

        private Venda() { }

        public Venda(Cliente cliente, int numeroDaNota, DateTime dataDaEmissao,
            DateTime dataDaSaida, string descricao, IEnumerable<ItemDaVenda> itens)
        {
            if (cliente == null)
                throw new ArgumentNullException("cliente");

            if (cliente == null)
                throw new ArgumentNullException("cliente");

            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentOutOfRangeException("descricao");

            this.Cliente = cliente;
            this.NumeroDaNota = numeroDaNota;
            this.DataDaEmissao = dataDaEmissao;
            this.DataDaSaida = dataDaSaida;
            this.Descricao = descricao;

            this.Comissoes = new List<Comissao>();
            this.ContasAReceber = new List<ContaAReceber>();
            this.ItensDaVenda = new List<ItemDaVenda>(itens);

            this.ValorTotal = ItensDaVenda.Sum(i => i.ValorTotal);

            GerarComissoes();
            GerarContasAReceber();
        }

        private void GerarComissoes()
        {
            foreach (var item in ItensDaVenda)
            {
                var comissao = Comissoes.SingleOrDefault(c => c.Representante == item.Representante);

                if (comissao == null)
                {
                    comissao = new Comissao(item.Representante, item.ValorTotal);
                    Comissoes.Add(comissao);
                }
                else
                {
                    comissao.Aumentar(item.ValorTotal);
                }
            }
        }

        protected virtual void GerarContasAReceber()
        {
        }

        public void AdicionarItem(ItemDaVenda itemDaVenda)
        {
            if (itemDaVenda == null)
                throw new ArgumentNullException("itemDaVenda");

            this.ItensDaVenda.Add(itemDaVenda);
        }

        public bool Equals(Venda outra)
        {
            if (outra == null)
                return false;

            if (outra == this)
                return true;

            return this.NumeroDaNota.Equals(outra.NumeroDaNota);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Venda);
        }

        public override int GetHashCode()
        {
            return this.NumeroDaNota.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.NumeroDaNota, this.Cliente.Nome);
        }
    }
}