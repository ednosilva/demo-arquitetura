using Demo.Dominio.Compartilhado;

namespace Demo.Dominio
{
    public abstract class Participante : IIdentificavel
    {
        public string Inscricao { get; protected set; }

        public string Nome { get; protected set; }

        protected Participante() { }

        public Participante(string inscricao, string nome)
        {
            this.Inscricao = inscricao;
            this.Nome = nome;
        }
    }
}