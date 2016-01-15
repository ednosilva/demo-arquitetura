using System;

namespace Demo.Dominio.Compartilhado
{
    public class DominioException : Exception
    {
        public DominioException(string mensagem) : base(mensagem) { }

        public DominioException(string mensagem, Exception exception)
            : base(mensagem, exception) { }
    }
}