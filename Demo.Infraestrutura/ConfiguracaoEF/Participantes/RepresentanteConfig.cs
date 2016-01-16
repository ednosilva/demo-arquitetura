using Demo.Dominio.Participantes;
using System.Data.Entity.ModelConfiguration;

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
