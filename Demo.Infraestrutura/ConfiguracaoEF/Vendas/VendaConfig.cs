using Demo.Dominio.Vendas;
using System.Data.Entity.ModelConfiguration;

namespace Demo.Infraestrutura.Configuracao.Vendas
{
    public class VendaConfig : EntityTypeConfiguration<Venda>
    {
        public VendaConfig()
        {
            ToTable("Venda");

            Property(x => x.Descricao).HasMaxLength(300).IsRequired();
            //Property(x => x.ChaveDeAcessoNfe).IsFixedLength().HasMaxLength(44);
            //Property(x => x.DataDaImpressao).IsOptional();

            HasRequired(x => x.Cliente)
                .WithMany();

            HasMany(x => x.ItensDaVenda)
                .WithRequired();
        }
    }
}
