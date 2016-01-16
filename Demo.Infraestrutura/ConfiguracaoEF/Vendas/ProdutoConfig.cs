using Demo.Dominio.Vendas;
using System.Data.Entity.ModelConfiguration;

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
