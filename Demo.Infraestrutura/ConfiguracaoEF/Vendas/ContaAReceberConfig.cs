using Demo.Dominio.Vendas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infraestrutura.Configuracao.Vendas
{
    public class ContaAReceberConfig : EntityTypeConfiguration<ContaAReceber>
    {
        public ContaAReceberConfig()
        {
            ToTable("ContasReceber");

            Property(x => x.Numero)
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.DataDeEmissao)
                .HasColumnType("Date");

            Property(x => x.Valor)
                .HasPrecision(10, 2);

            Property(x => x.DataDeVencimento)
                .HasColumnType("Date");

            HasRequired(x => x.Cliente)
                .WithMany();
        }
    }
}
