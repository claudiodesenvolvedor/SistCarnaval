using System;

namespace PRJ.SistemaCarnaval.Domain.Entities
{
    public class Banco
    {
        public Banco()
        {
            BancoId = new Guid();
        }

        public Guid BancoId { get; set; }
        public string CodigoBanco { get; set; }
        public string Cnpj { get; set; }
        public string Descricao { get; set; }

    }
}
