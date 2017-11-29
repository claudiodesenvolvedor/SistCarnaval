using System;

namespace PRJ.SistemaCarnaval.Domain.Entities
{
    public class TipoCredencial
    {
        public TipoCredencial()
        {
            TipoCredencialId = new Guid();
        }

        public Guid TipoCredencialId { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }

    }
}
