using System;
using System.Collections.Generic;

namespace Demo.Dominio.Participantes
{
    public class Representante : Participante, IEquatable<Representante>
    {
        public int PercentualDeComissao { get; private set; }

        public IList<Cliente> Clientes { get; private set; }

        private Representante() { }

        public Representante(string inscricao, string nome, int percentualDeComissao)
        {
            this.Inscricao = inscricao;
            this.Nome = nome;
            this.PercentualDeComissao = percentualDeComissao;

            this.Clientes = new List<Cliente>();
        }

        public bool Equals(Representante outro)
        {
            if (outro == null)
                return false;

            if (outro == this)
                return true;

            return this.Inscricao.Equals(outro.Inscricao);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Representante);
        }

        public override int GetHashCode()
        {
            return this.Inscricao.GetHashCode();
        }
    }
}