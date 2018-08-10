using ProjetoModeloDDD2.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD2.Infra.Data.Migrations
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteID);
            Property(c => c.Nome).IsRequired().HasMaxLength(150);
            Property(c => c.Sobrenome).IsRequired().HasMaxLength(150);
            Property(c => c.Nome).IsRequired();
        }

    }
}
