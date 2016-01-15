using Demo.Dominio.Vendas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infraestrutura.Configuracao.Vendas
{
    public class ComissaoConfig : EntityTypeConfiguration<Comissao>
    {
        public ComissaoConfig()
        {
            ToTable("Comissao");
        }
    }
}
