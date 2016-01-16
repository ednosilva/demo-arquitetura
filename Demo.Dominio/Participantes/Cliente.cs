using System;
using System.Collections.Generic;

namespace Demo.Dominio.Participantes
{
    public class Cliente : Participante, IEquatable<Cliente>
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

        public bool Equals(Cliente outro)
        {
            if (outro == null)
                return false;

            if (outro == this)
                return true;

            return this.Inscricao.Equals(outro.Inscricao);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Cliente);
        }

        public override int GetHashCode()
        {
            return this.Inscricao.GetHashCode();
        }
    }
}