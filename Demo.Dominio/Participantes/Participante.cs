using Demo.Dominio.Compartilhado;
using System;

namespace Demo.Dominio.Participantes
{
    public abstract class Participante : IIdentificavel
    {
        public string Inscricao { get; protected set; }

        public string Nome { get; protected set; }

        protected Participante() { }

        public Participante(string inscricao, string nome)
        {
            if (string.IsNullOrWhiteSpace(inscricao))
                throw new ArgumentOutOfRangeException("inscricao");

            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentOutOfRangeException("nome");

            this.Inscricao = inscricao;
            this.Nome = nome;
        }
    }
}