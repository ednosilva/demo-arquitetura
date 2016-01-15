using System;
using System.Collections.Generic;

namespace Demo.Dominio.Participantes
{
    public class Cliente : Participante
    {
        public decimal LimiteDeCredito { get; private set; }

        public IList<Representante> Representantes { get; private set; }

        private Cliente() { }

        public Cliente(string inscricao, int limiteDeCredito, string nome)
        {
            if (string.IsNullOrWhiteSpace(inscricao))
                throw new ArgumentOutOfRangeException("inscricao");

            if (limiteDeCredito < 0)
                throw new ArgumentOutOfRangeException("limiteDeCredito");

            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentOutOfRangeException("nome");

            this.Inscricao = inscricao;
            this.LimiteDeCredito = limiteDeCredito;
            this.Nome = nome;

            this.Representantes = new List<Representante>();
        }
    }
}