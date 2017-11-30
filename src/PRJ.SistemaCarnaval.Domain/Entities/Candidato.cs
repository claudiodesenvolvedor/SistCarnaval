using System;

namespace PRJ.SistemaCarnaval.Domain.Entities
{
    public class Candidato
    {
        public Candidato()
        {
            CandidatoId = new Guid();
        }

        public Guid CandidatoId { get; set; }
        public Guid PessoaId { get; set; }
        public Guid BancoId { get; set; }

        public string Pis { get; set; }
        public string Email { get; set; }
        public string CienteSelecao { get; set; }
        public string ReciboRiotur { get; set; }
        public int? CodigoTipoConta { get; set; }
        public string Agencia { get; set; }
        public string Operacao { get; set; }
        public string Conta { get; set; }

        public string UsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public string UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public virtual Pessoa PessoaLista { get; set; }
        public virtual Banco BancoLista { get; set; }

    }
}
