using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using senai_uc12.Interfaces;

namespace senai_uc12.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome { get; set; }
        
        public float Rendimento { get; set; }
        
        public string? Endereco { get; set; }

        public abstract float PagarImposto(float rendimento);
        
    }
}