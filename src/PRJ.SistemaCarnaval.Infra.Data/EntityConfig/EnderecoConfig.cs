using PRJ.SistemaCarnaval.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Property(p => p.DataCadastro)
                .IsRequired(); 

            Property(p => p.UsuarioCadastro)
                .IsRequired()
                .HasMaxLength(30);

            ToTable("Enderecos");

        }
    }
}
