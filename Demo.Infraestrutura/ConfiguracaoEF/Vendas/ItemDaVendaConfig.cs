using Demo.Dominio.Vendas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infraestrutura.Configuracao.Vendas
{
    public class ItemDaVendaConfig : EntityTypeConfiguration<ItemDaVenda>
    {
        public ItemDaVendaConfig()
        {
            ToTable("ItemDaVenda");

            Property(x => x.Descricao).HasMaxLength(300).IsRequired();

            HasRequired(x => x.Representante)
                .WithMany();

            HasRequired(x => x.Produto)
                .WithMany();
        }
    }
}
