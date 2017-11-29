using System;

namespace PRJ.SistemaCarnaval.Domain.Entities
{
    public class Credenciado
    {
        public Credenciado()
        {
            CredenciadoId = new Guid();
        }

        public Guid CredenciadoId { get; set; }
        public string OrgaoAlocacao { get; set; }

        public string UsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public string UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public virtual Pessoa Pessoa { get; set; }

    }
}
