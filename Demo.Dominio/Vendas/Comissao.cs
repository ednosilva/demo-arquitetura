using Demo.Dominio.Compartilhado;
using Demo.Dominio.Participantes;
using System;

namespace Demo.Dominio.Vendas
{
    public class Comissao : IIdentificavel, IEquatable<Comissao>
    {
        public Representante Representante { get; private set; }

        public decimal Valor { get; private set; }

        public decimal ValorDaVenda { get; private set; }

        public int PercentualDaComissao { get; private set; }
        
        private Comissao() { }

        internal Comissao(Representante representante, decimal valorDoItem)
        {
            this.Representante = representante;
            this.PercentualDaComissao = representante.PercentualDeComissao;
            this.ValorDaVenda = valorDoItem;
            this.Valor = CalcularValorComissao(valorDoItem);
        }

        internal void Aumentar(decimal valorDoItem)
        {
            this.ValorDaVenda += valorDoItem;
            this.Valor += CalcularValorComissao(valorDoItem);
        }

        private decimal CalcularValorComissao(decimal valorDoItem)
        {
            return valorDoItem * (PercentualDaComissao / 100.0m);
        }

        public bool Equals(Comissao outro)
        {
            if (outro == null)
                return false;

            if (outro == this)
                return true;

            return this.Representante.Equals(outro.Representante);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Comissao);
        }

        public override int GetHashCode()
        {
            return this.Representante.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Representante: {0}, Valor: {1}", this.Representante.Nome, this.Valor);
        }
    }
}