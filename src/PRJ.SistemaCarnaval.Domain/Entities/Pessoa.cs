using System; 
using System.Collections.Generic;

namespace PRJ.SistemaCarnaval.Domain.Entities
{
    public class Pessoa
    {
        public Pessoa()
        {
            PessoaId = new Guid();
            Ativo = true;
        }

        public Guid PessoaId { get; set; }
        public Guid PessoaIndicacaoId { get; set; }
        public Guid EnderecoId { get; set; }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string OrgaoEmissor { get; set; }
        public byte[] Foto { get; set; }
        public string TipoFoto { get; set; }
        public string TipoHabilitacao { get; set; }
        public string Observacao { get; set; }
        public string UsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public string UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }

        
        public virtual Pessoa PessoaLista { get; set; }
        public virtual Endereco EnderecoLista { get; set; }

        public virtual ICollection<Telefone> TelefoneLista { get; set; }
        public virtual Candidato CandidatoLista { get; set; }

    }
}
