using Demo.Dominio.Compartilhado;

namespace Demo.Dominio
{
    public class Produto : IIdentificavel
    {
        public int CodigoDeBarras { get; private set; }

        public string Nome { get; private set; }

        public decimal Preço { get; private set; }

        private Produto() { }

        public Produto(int codigoDeBarras, string nome, decimal preço)
        {
            this.CodigoDeBarras = codigoDeBarras;
            this.Nome = nome;
            this.Preço = preço;
        }
    }
}