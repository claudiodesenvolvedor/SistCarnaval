using PRJ.SistemaCarnaval.Domain.Entities;
using PRJ.SistemaCarnaval.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PRJ.SistemaCarnaval.Infra.Data.Context
{
    public class SistemaCarnavalContext : DbContext
    {
        public SistemaCarnavalContext()
            :base("DefaultConnection")
        {

        }

        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Coordenador> Coordenadores { get; set; }
        public DbSet<Credenciado> Credenciados { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<HistoricoCandCred> HistoricosCandCred { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<TipoCredencial> TipoCredenciais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));


            modelBuilder.Configurations.Add(new PessoaConfig());
            modelBuilder.Configurations.Add(new BancoConfig());
            modelBuilder.Configurations.Add(new CandidatoConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());


            base.OnModelCreating(modelBuilder);
        }


    }
}
