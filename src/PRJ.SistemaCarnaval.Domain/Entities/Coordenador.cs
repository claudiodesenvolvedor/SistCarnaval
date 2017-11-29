using System;

namespace PRJ.SistemaCarnaval.Domain.Entities
{
    public class Coordenador
    {
        public Coordenador()
        {
            CoordenadorId = new Guid();
        }

        public Guid CoordenadorId { get; set; }
        public string LocalReuniao { get; set; }
        public DateTime DataReuniao { get; set; }
        public DateTime HoraReuniao { get; set; }

        public string UsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public string UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public virtual Pessoa Pessoa { get; set; }

    }
}
