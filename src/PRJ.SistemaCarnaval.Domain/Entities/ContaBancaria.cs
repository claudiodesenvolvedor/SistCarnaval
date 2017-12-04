using System;

namespace PRJ.SistemaCarnaval.Domain.Entities
{
    public class ContaBancaria
    {
        public ContaBancaria()
        {
            ContaBancariaId = new Guid();
        }

        public Guid ContaBancariaId { get; set; }   
     
        public int TipoConta { get; set; }
        public string Agencia { get; set; }
        public string Operacao { get; set; }
        public string Conta { get; set; }
        public string Digito { get; set; }

        public virtual Candidato CandidatoLista { get; set; }
    }
}
