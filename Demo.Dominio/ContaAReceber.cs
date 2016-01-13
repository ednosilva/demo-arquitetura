using Demo.Dominio.Compartilhado;
using System;

namespace Demo.Dominio
{
    public class ContaAReceber : IIdentificavel
    {
        public Cliente Cliente { get; private set; }

        public string Numero { get; private set; }

        public decimal Valor { get; private set; }

        public DateTime DataDeVencimento { get; private set; }

        public DateTime DataDeEmissao { get; private set; }
    }
}