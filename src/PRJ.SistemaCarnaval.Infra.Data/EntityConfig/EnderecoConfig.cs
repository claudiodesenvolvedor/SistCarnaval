using PRJ.SistemaCarnaval.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PRJ.SistemaCarnaval.Infra.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            // Fluent API
            HasKey(e => e.EnderecoId);

            Property(e => e.Cep)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            Property(e => e.Numero)
                .HasMaxLength(8);

            Property(e => e.Complemento)
                .HasMaxLength(10);

            Property(e => e.DataCadastro)
                .IsRequired(); 

            Property(e => e.UsuarioCadastro)
                .IsRequired()
                .HasMaxLength(30);

            Property(e => e.UsuarioAlteracao)
                .HasMaxLength(30);


            // Relacionamentos

            // Relacionamento de um-pra-um entre pessoa e endereço
            //HasOptional(p => p.)
            //    .WithRequired(e => e.);



            ToTable("Enderecos");

        }
    }
}
