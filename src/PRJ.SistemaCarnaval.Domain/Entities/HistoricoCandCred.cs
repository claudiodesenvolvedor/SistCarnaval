using System;

namespace PRJ.SistemaCarnaval.Domain.Entities
{
    public class HistoricoCandCred
    {
        public HistoricoCandCred()
        {
            HistoricoCandCredId = new Guid();
        }

        public Guid HistoricoCandCredId { get; set; }
        public int CodigoAno { get; set; }
        public int CodigoSetorTipoCredencial { get; set; }
        public int CodigoTipoProbTrabalhado { get; set; }
        public string Observacao { get; set; }

        public string UsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public string UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public virtual Pessoa Pessoa { get; set; }

    }
}
