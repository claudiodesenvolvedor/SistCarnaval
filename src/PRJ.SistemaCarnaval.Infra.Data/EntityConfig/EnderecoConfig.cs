using PRJ.SistemaCarnaval.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PRJ.SistemaCarnaval.Infra.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            // Fluent API 2
            HasKey(e => e.EnderecoId);

            Property(e => e.Cep)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            Property(e => e.Numero)
                .HasMaxLength(8);

            Property(e => e.Complemento)
                .HasMaxLength(10);

            Property(p => p.DataCadastro)
                .IsRequired(); 

            Property(p => p.UsuarioCadastro)
                .IsRequired()
                .HasMaxLength(30);

            Property(p => p.UsuarioAlteracao)
                .HasMaxLength(30);

            ToTable("Enderecos");

        }
    }
}
