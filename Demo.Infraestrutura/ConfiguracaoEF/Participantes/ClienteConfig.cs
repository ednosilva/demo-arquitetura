using Demo.Dominio.Participantes;
using System.Data.Entity.ModelConfiguration;

namespace Demo.Infraestrutura.Configuracao.Participantes
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            ToTable("Cliente");
        }
    }
}
