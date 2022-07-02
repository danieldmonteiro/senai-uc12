using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using senai_uc12.Interfaces;

namespace senai_uc12.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {
        public string? Cpf { get; set; }
        
        public DateTime dataNasc { get; set; }
        
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}