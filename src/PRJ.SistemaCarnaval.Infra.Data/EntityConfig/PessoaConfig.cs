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
            // HasKey(p => new { p.PessoaId, cpf }); // Chave composta

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
                .IsRequired()
                .HasMaxLength(30);

            Property(p => p.UsuarioAlteracao)
                .HasMaxLength(30);


            // Relacionamentos

            // Relacionamento de um-pra-zero ou um entre pessoa e endereço
            HasOptional(p => p.EnderecoLista)
                .WithRequired(e => e.PessoaLista);

            // Relacionamento de um-pra-zero ou um entre pessoa e pessoa
            HasOptional(p => p.PessoaLista)
                .WithRequired(p => p.PessoaLista);

            // Relacionamento de um-pra-zero ou um entre pessoa e candidato
            HasOptional(p => p.CandidatoLista)
                .WithRequired(c => c.PessoaLista);

            // Relacionamento de um-pra-zero ou muitos entre pessoa e telefone
            HasMany<Telefone>(p => p.TelefoneLista)
                .WithRequired(t => t.PessoaLista)
                .HasForeignKey(t => t.PessoaId);
            

            ToTable("Pessoas");

        }
    }
}
