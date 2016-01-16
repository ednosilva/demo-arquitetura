using Demo.Dominio.Participantes;
using System.Data.Entity.ModelConfiguration;

namespace Demo.Infraestrutura.Configuracao.Participantes
{
    public class ParticipanteConfig : EntityTypeConfiguration<Participante>
    {
        public ParticipanteConfig()
        {
            ToTable("Participante");
            Property(x => x.Nome).IsRequired().HasMaxLength(100);
            Property(x => x.Inscricao).IsRequired().HasMaxLength(100);
        }
    }
}
