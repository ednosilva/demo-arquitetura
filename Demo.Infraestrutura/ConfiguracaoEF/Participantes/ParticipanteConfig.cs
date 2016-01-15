using Demo.Dominio.Participantes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
