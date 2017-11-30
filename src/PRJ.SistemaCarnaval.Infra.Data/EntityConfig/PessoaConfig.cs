using PRJ.SistemaCarnaval.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace PRJ.SistemaCarnaval.Infra.Data.EntityConfig
{
    public class PessoaConfig : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfig()
        {
            HasKey(p => p.PessoaId);
            // HasKey(p => new { p.PessoaId, cpf });

            Property(p => p.Nome)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Observacao)
                .HasMaxLength(1000);

            Property(p => p.Cpf)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnAnnotation("Index", 
                    new IndexAnnotation(new IndexAttribute() { IsUnique = true})
                 );

            Property(p => p.Rg)
                .IsFixedLength()
                .HasMaxLength(9);

            Property(p => p.TipoHabilitacao)
                .IsRequired()
                .HasMaxLength(2);

            Property(p => p.TipoFoto)
                .HasMaxLength(20);

            Property(p => p.OrgaoEmissor)
                .HasMaxLength(10);

            Property(p => p.Ativo)
                .IsRequired();

            Property(p => p.Foto)
                .HasMaxLength(3072);

            Property(p => p.DataCadastro)
                .IsRequired();

            Property(p => p.UsuarioCadastro)
                .IsRequired();

            ToTable("Pessoas");

        }
    }
}
