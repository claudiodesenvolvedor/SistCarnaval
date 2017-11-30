using PRJ.SistemaCarnaval.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PRJ.SistemaCarnaval.Infra.Data.EntityConfig
{
    public class CandidatoConfig : EntityTypeConfiguration<Candidato>
    {
        public CandidatoConfig()
        {
            HasKey(c => c.CandidatoId);

            Property(c => c.Pis)
                .HasMaxLength(13)
                .IsFixedLength();

            Property(c => c.Email)
                .HasMaxLength(50);

            Property(c => c.CienteSelecao)
                .HasMaxLength(13)
                .IsRequired();

            Property(c => c.ReciboRiotur)
                .HasMaxLength(13)
                .IsRequired();

            Property(c => c.Conta)
                .HasMaxLength(12);

            Property(c => c.Agencia)
                .HasMaxLength(5);

            Property(c => c.Operacao)
                .HasMaxLength(3);

            Property(c => c.DataCadastro)
                .IsRequired();

            Property(c => c.UsuarioCadastro)
                .IsRequired()
                .HasMaxLength(30);

            Property(p => p.UsuarioAlteracao)
                .HasMaxLength(30);

            
            // Relacionamentos
            //HasRequired(c => c.PessoaLista)
            //    .WithMany(c => c.CandidatoLista)
            //    .HasForeignKey(p => p.PessoaId);

            //HasOptional(c => c.BancoLista)
            //    .WithMany(c => c.CandidatoLista)
            //    .HasForeignKey(c => c.BancoId);

            HasOptional(c => c.BancoLista)
                .WithOptionalDependent(c => c.CandidatoLista);

            HasRequired(c => c.PessoaLista)
                .WithRequiredDependent(c => c.CandidatoLista);

            ToTable("Candidatos");

        }
    }
}
