using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_uc12.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNasc(DateTime dataNasc);
    }
}