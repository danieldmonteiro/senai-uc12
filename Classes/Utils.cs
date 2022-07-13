using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_uc12.Classes
{
    static class Utils
    {
        public static void BarraCarregamento(string texto, int tempo, int quantidade){
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(texto);

            for (var contador = 0; contador < quantidade; contador++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }  
            Console.ResetColor();
            
        }   


        public static void VerificarPastaArquivo(string Caminho){
            
            string pasta = Caminho.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(Caminho))
            {
                using (File.Create(Caminho)){}
            }
            
        }
    }
}