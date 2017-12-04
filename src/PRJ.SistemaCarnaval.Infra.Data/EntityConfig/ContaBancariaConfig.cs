using System;
using PRJ.SistemaCarnaval.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PRJ.SistemaCarnaval.Infra.Data.EntityConfig
{
    public class ContaBancariaConfig : EntityTypeConfiguration<ContaBancaria>
    {
        public ContaBancariaConfig()
        {
            HasKey(cb => cb.ContaBancariaId);

            Property(cb => cb.TipoConta)
                .IsRequired();

            Property(cb => cb.Agencia)
                .HasMaxLength(5)
                .IsRequired();

            Property(cb => cb.Conta)
                .HasMaxLength(8)
                .IsRequired();

            Property(cb => cb.Digito)
                .HasMaxLength(1)
                .IsRequired();

            Property(cb => cb.Operacao)
                .HasMaxLength(3)
                .IsOptional();

            ToTable("ContasBancarias");
        }
    }
}
