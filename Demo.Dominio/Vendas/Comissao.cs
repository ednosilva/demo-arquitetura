using Demo.Dominio.Compartilhado;
using Demo.Dominio.Participantes;

namespace Demo.Dominio.Vendas
{
    public class Comissao : IIdentificavel
    {
        public Representante Representante { get; private set; }

        public decimal Valor { get; private set; }

        public decimal ValorDaVenda { get; private set; }

        public int PercentualDaComissao { get; private set; }

        private Comissao() { }

        public Comissao(Representante representante, decimal valor, decimal valorDaVenda, int percentualDaComissao)
        {
            this.Representante = representante;
            this.Valor = valor;
            this.ValorDaVenda = ValorDaVenda;
            this.PercentualDaComissao = percentualDaComissao;
        }
    }
}