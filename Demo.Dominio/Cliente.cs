using System.Collections.Generic;

namespace Demo.Dominio
{
    public class Cliente : Participante
    {
        public decimal LimiteDeCredito { get; private set; }

        public IList<Representante> Representantes { get; private set; }

        private Cliente() { }

        public Cliente(string inscricao, int limiteDeCredito, string nome)
        {
            this.Inscricao = inscricao;
            this.LimiteDeCredito = limiteDeCredito;
            this.Nome = nome;

            this.Representantes = new List<Representante>();
        }
    }
}