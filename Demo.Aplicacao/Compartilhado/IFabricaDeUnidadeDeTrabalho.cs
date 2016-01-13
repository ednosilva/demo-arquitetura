using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Aplicacao.Compartilhado
{
    /// <summary>
    /// Uma Fábrica de Unidade de Trabalho
    /// </summary>
    public interface IFabricaDeUnidadeDeTrabalho
    {
        IUnidadeDeTrabalho Criar();
    }
}
