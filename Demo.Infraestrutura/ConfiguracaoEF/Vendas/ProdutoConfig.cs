using Demo.Dominio.Vendas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infraestrutura.Configuracao.Vendas
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            Property(x => x.Nome).HasMaxLength(100).IsRequired();
            Property(x => x.Preço).HasPrecision(10, 2);
        }
    }
}
