using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using Demo.Dominio;
using Demo.Infra.Repositorio.Configuracao;
using Demo.Dominio.Compartilhado;

namespace Demo.Infra.Repositorio
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : IIdentificavel
    {
        protected readonly ContextoBanco _contexto;

        public RepositorioBase(ContextoBanco contexto)
        {
            _contexto = contexto;

            Debug.WriteLine("ID DO CONTEXTO EF: " + _contexto.GetHashCode());
        }

        #region IRepositorioBase<TEntidade> Members

        public TEntidade Recuperar(int id)
        {
            return _contexto.Set<TEntidade>().SingleOrDefault(x => x.Id == id);
        }

        public void Inserir(TEntidade obj)
        {
            _contexto.Set<TEntidade>().Add(obj);
        }

        public void Alterar(TEntidade obj)
        {
            _contexto.Entry(obj).State = EntityState.Modified;
        }

        public void Remover(TEntidade obj)
        {
            _contexto.Set<TEntidade>().Remove(obj);
        }

        public void Remover(int id)
        {
            TEntidade obj = Recuperar(id);
            Remover(obj);
        }

        #endregion
    }
}