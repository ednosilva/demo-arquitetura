using Demo.Aplicacao.Compartilhado;

namespace Demo.Infra.Repositorio.Configuracao
{
    public class UnidadeDeTrabalhoEF : IUnidadeDeTrabalho
    {
        private ContextoBanco _contexto;

        public UnidadeDeTrabalhoEF(ContextoBanco contexto)
        {
            _contexto = contexto;
        }

        public void Iniciar()
        {
            
        }

        public void Completar()
        {
            _contexto.SaveChanges();
        }

        public void Dispose() { }
    }
}