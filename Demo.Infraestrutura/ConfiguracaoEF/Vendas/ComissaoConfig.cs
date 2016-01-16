using Demo.Dominio.Vendas;
using System.Data.Entity.ModelConfiguration;

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
