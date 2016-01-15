using System;

namespace Demo.Dominio.Participantes
{
    public class Transportadora : Participante
    {
        private Transportadora() { }

        public Transportadora(string inscricao, string nome)
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