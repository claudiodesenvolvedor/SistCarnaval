using PRJ.SistemaCarnaval.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PRJ.SistemaCarnaval.Infra.Data.EntityConfig
{
    public class BancoConfig : EntityTypeConfiguration<Banco>
    {
        public BancoConfig()
        {
            HasKey(b => b.BancoId);

            Property(b => b.CodigoBanco)
                .IsRequired()
                .HasMaxLength(3)
                .IsFixedLength();

            Property(b => b.Cnpj)
                .HasMaxLength(18);

            Property(b => b.Descricao)
                .IsRequired()
                .HasMaxLength(70);

            ToTable("Bancos");
        }
    }
}
