using System;

namespace Demo.Dominio.Participantes
{
    public class Transportadora : Participante, IEquatable<Transportadora>
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

        public bool Equals(Transportadora outra)
        {
            if (outra == null)
                return false;

            if (outra == this)
                return true;

            return this.Inscricao.Equals(outra.Inscricao);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Transportadora);
        }

        public override int GetHashCode()
        {
            return this.Inscricao.GetHashCode();
        }
    }
}