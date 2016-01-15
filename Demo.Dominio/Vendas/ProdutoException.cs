using Demo.Dominio.Compartilhado;
using System;

namespace Demo.Dominio.Vendas
{
    public class ProdutoException : DominioException
    {
        public ProdutoException(string mensagem)
            : base(mensagem) { }

        public ProdutoException(string mensagem, Exception exception)
            : base(mensagem, exception) { }
    }
}