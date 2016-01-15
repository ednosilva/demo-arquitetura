using System.Collections.Generic;

namespace Demo.Dominio.Participantes
{
    public class Representante : Participante
    {
        public int PercentualDeComissao { get; private set; }

        public IList<Cliente> Clientes { get; private set; }

        private Representante() { }

        public Representante(string Inscricao, string Nome, int PercentualDeComissao)
        {
            this.Inscricao = Inscricao;
            this.Nome = Nome;
            this.PercentualDeComissao = PercentualDeComissao;

            this.Clientes = new List<Cliente>();
        }
    }
}