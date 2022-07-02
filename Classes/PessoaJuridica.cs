using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using senai_uc12.Interfaces;

namespace senai_uc12.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }
        
        public string? RazaoSocial { get; set; }
        
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}