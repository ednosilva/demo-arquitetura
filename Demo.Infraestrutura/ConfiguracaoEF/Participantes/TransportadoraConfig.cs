using Demo.Dominio.Participantes;
using System.Data.Entity.ModelConfiguration;

namespace Demo.Infraestrutura.Configuracao.Participantes
{
    public class TransportadoraConfig : EntityTypeConfiguration<Transportadora>
    {
        public TransportadoraConfig()
        {
            ToTable("Transportadora");
        }
    }
}
