using System;

namespace PRJ.SistemaCarnaval.Domain.Entities
{
    public class Endereco
    {
        public Endereco()
        {
            EnderecoId = new Guid();
        }

        public Guid EnderecoId { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Descricao { get; set; }
        public string UsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public string UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }

        //public virtual Pessoa Pessoa { get; set; }

    }
}
