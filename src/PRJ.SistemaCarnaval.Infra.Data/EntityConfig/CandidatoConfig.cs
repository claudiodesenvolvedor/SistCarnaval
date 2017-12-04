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

            Property(c => c.DataCadastro)
                .IsRequired();

            Property(c => c.UsuarioCadastro)
                .IsRequired()
                .HasMaxLength(30);

            Property(c => c.UsuarioAlteracao)
                .HasMaxLength(30);

            
            // Relacionamentos ---------------------------------------------

            // Relacionamento de um-pra-zero ou um entre pessoa e endereço
            HasOptional(c => c.BancoLista)
                .WithRequired(b => b.CandidatoLista);

            // Relacionamento de um-pra-zero ou um entre pessoa e endereço
            HasOptional(c => c.ContaBancariaLista)
                .WithRequired(b => b.CandidatoLista);


            ToTable("Candidatos");

        }
    }
}
