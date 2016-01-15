using Demo.Infraestrutura.Repositorios;
using System.Web;

namespace Demo.Infraestrutura.Configuracao
{
    public class GerenciadorDeContextoBancoHttp : IGerenciadorDeContexoBanco
    {
        public const string ContextoHttp = "ContextoHttp";

        public ContextoBanco Contexto
        {
            get
            {
                if (HttpContext.Current.Items[ContextoHttp] == null)
                {
                    HttpContext.Current.Items[ContextoHttp] = new ContextoBanco();
                }
                return HttpContext.Current.Items[ContextoHttp] as ContextoBanco;
            }
        }

        #region IGerenciadorDeRepositorio Members

        public void Finalizar()
        {
            if (HttpContext.Current.Items[ContextoHttp] != null)
            {
                (HttpContext.Current.Items[ContextoHttp] as ContextoBanco).Dispose();
            }
        }

        #endregion
    }
}