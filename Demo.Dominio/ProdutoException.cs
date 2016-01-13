using Demo.Dominio.Compartilhado;
using System;

namespace Demo.Dominio
{
    public class ProdutoException : DemoArquiteturaException
    {
        public ProdutoException(string mensagem)
            : base(mensagem) { }

        public ProdutoException(string mensagem, Exception exception)
            : base(mensagem, exception) { }
    }
}