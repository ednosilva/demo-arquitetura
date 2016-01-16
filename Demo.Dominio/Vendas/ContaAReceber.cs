using Demo.Dominio.Compartilhado;
using Demo.Dominio.Participantes;
using System;

namespace Demo.Dominio.Vendas
{
    public class ContaAReceber : IIdentificavel, IEquatable<ContaAReceber>
    {
        public Cliente Cliente { get; private set; }

        public string Numero { get; private set; }

        public decimal Valor { get; private set; }

        public DateTime DataDeVencimento { get; private set; }

        public DateTime DataDeEmissao { get; private set; }

        private ContaAReceber() { }

        public ContaAReceber(string numero, Cliente cliente, decimal valor,
            DateTime dataDeVencimento, DateTime dataDeEmissao)
        {
            this.Numero = numero;
            this.Cliente = cliente;
            this.Valor = valor;
            this.DataDeVencimento = DataDeVencimento;
            this.DataDeEmissao = dataDeEmissao;
        }

        public bool Equals(ContaAReceber outra)
        {
            if (outra == null)
                return false;

            if (outra == this)
                return true;

            return this.Numero.Equals(outra.Numero);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as ContaAReceber);
        }

        public override int GetHashCode()
        {
            return this.Numero.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Numero, this.Cliente.Nome);
        }
    }
}