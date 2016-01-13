namespace Demo.Dominio
{
    public class Transportadora : Participante
    {
        private Transportadora() { }

        public Transportadora(string inscricao, string nome)
        {
            this.Inscricao = inscricao;
            this.Nome = nome;
        }
    }
}