using Demo.Dominio.Compartilhado;

namespace Demo.Dominio
{
    public class Comissao : IIdentificavel
    {
        public Representante Representante { get; private set; }

        public decimal Valor { get; private set; }

        public decimal ValorDaVenda { get; private set; }

        public int PercentualDaComissao { get; private set; }
    }
}