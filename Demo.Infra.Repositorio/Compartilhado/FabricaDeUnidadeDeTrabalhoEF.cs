using Demo.Aplicacao.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infraestrutura.Configuracao
{
    public class FabricaDeUnidadeDeTrabalhoEF : IFabricaDeUnidadeDeTrabalho
    {
        private readonly ContextoBanco _contexto;

        public FabricaDeUnidadeDeTrabalhoEF(ContextoBanco contexto)
        {
            this._contexto = contexto;
        }

        public IUnidadeDeTrabalho Criar()
        {
            return new UnidadeDeTrabalhoEF(_contexto);
        }
    }
}
