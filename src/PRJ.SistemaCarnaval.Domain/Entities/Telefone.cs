using System;

namespace PRJ.SistemaCarnaval.Domain.Entities
{
    public class Telefone
    {
        public Telefone()
        {
            TelefoneId = new Guid();
        }

        public Guid TelefoneId { get; set; }
        public int NumeroTelefone { get; set; }
        public int CodigoTipoTelefone { get; set; }

        public virtual Guid PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

    }
}
