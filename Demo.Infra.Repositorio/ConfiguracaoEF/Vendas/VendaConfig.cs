using Demo.Dominio.Vendas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infraestrutura.Configuracao.Vendas
{
    public class VendaConfig : EntityTypeConfiguration<Venda>
    {
        public VendaConfig()
        {
            ToTable("Venda");

            Property(x => x.Descricao).HasMaxLength(300).IsRequired();
            Property(x => x.ChaveDeAcessoNFE).IsFixedLength().HasMaxLength(44);
            Property(x => x.DataDaImpressao).IsOptional();

            HasRequired(x => x.Cliente)
                .WithMany();

            HasMany(x => x.ItensDaVenda)
                .WithRequired();
        }
    }
}
