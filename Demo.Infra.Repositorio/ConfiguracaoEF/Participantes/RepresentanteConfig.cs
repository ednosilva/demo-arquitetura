using Demo.Dominio.Participantes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infraestrutura.Configuracao.Participantes
{
    public class RepresentanteConfig : EntityTypeConfiguration<Representante>
    {
        public RepresentanteConfig()
        {
            ToTable("Representante");

            HasMany(x => x.Clientes)
                .WithMany(x => x.Representantes)
                .Map(m =>
                {
                    m.ToTable("ClienteRepresentante");
                    m.MapLeftKey("ClienteId");
                    m.MapRightKey("RepresentanteId");
                });
        }
    }
}
