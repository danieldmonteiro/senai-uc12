using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using senai_uc12.Interfaces;

namespace senai_uc12.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }
        
        public string? RazaoSocial { get; set; }

        public string Caminho { get; private set; } = "Database/PessoaJuridica.csv";
        
        
        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento / 100 * 3;

            }else if (rendimento <= 6000)
            {
                return rendimento / 100 * 5;

            }else if (rendimento <= 10000)
            {
                return rendimento / 100 * 7;

            }else
            {
                return rendimento / 100 * 9;
            }
        }
        //xx.xxx.xxx/0001-xx --------- xxxxxxxx0001xx
        public bool ValidarCnpj(string cnpj)
        {
            bool retornoCnpjvalido = Regex.IsMatch(cnpj, @"(⌃(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)");
        
        if (retornoCnpjvalido == true)
        {
            if (cnpj.Length == 18)
            {

                string substringCnpj = cnpj.Substring(11, 4);

                if (substringCnpj == "0001")
                {
                    return true;
                }

            }else if (cnpj.Length == 14)
            {
                string substringCnpj = cnpj.Substring(8, 4);

                if (substringCnpj == "0001")
                {
                    return true;
                }
            }
        }
        return false;
        
        }

        public void Inserir(PessoaJuridica novaPj){

            Utils.VerificarPastaArquivo(Caminho);

            string[] pjstrings = {$"{novaPj.Nome}, {novaPj.Cnpj}, {novaPj.RazaoSocial}"};

            File.AppendAllLines(Caminho, pjstrings);

        }

        public List<PessoaJuridica> LerArquivo(){

            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(Caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.Cnpj = atributos[1];
                cadaPj.RazaoSocial= atributos[2];

                listaPj.Add(cadaPj);
            }

            return listaPj;
        }

    }
}