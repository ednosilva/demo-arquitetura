using Demo.Dominio.Compartilhado;
using Demo.Dominio.Participantes;
using System;

namespace Demo.Dominio.Vendas
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