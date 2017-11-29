using System;

namespace PRJ.SistemaCarnaval.Domain.Entities
{
    public class Setor
    {
        public Setor()
        {
            SetorId = new Guid();
        }

        public Guid SetorId { get; set; }
        public string Descricao { get; set; }
        public int VagasDisponiveis { get; set; }

        public string UsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public string UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }


    }
}
