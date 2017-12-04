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
        public int Ddd { get; set; }
        public int NumeroTelefone { get; set; }
        public int TipoTelefone { get; set; }

        public Guid PessoaId { get; set; }
        public virtual Pessoa PessoaLista { get; set; }


    }
}
