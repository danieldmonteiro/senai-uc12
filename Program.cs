using senai_uc12.Classes;

Console.Clear();
Console.WriteLine(@$"
=========================================
|  Bem-vindo ao sistema de cadastro de  |
|      Pessoas Físicas e Jurídicas      |
=========================================
");

BarraCarregamento("Ïniciando", 100, 40);

string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
=========================================
|     Escolha uma das opções abaixo     |
=========================================
|           1 - Pessoa Física           |
|           2 - Pessoa Jurídica         |
|                                       |
|           0 - Sair                    |
=========================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodosPf = new PessoaFisica();
            Endereco novoEndPf = new Endereco();

            novaPf.Nome = "Daniel";
            novaPf.dataNasc = new DateTime(2000, 01, 01);
            novaPf.Cpf = "08680901741";
            novaPf.Rendimento = 3500.5f;

            novoEndPf.logradouro = "Alameda Barão de Limeira";
            novoEndPf.numero = 539;
            novoEndPf.complemento = "SENAI Informática";
            novoEndPf.endComercial = true;

            novaPf.Endereco = novoEndPf;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
Maior de Idade: {(metodosPf.ValidarDataNasc(novaPf.dataNasc) ? "Sim" : "Não")}
Imposto a ser pago: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C")}
");

            //Console.WriteLine($"Nome: {novaPf.Nome}");
            //Console.WriteLine("Nome: " + novaPf.Nome);

            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();

            break;

        case "2":

            PessoaJuridica novaPj = new PessoaJuridica();
            PessoaJuridica metodosPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.Nome = "Nome Pj";
            novaPj.RazaoSocial = "Razão Social Pj";
            novaPj.Cnpj = "00000000000100";
            novaPj.Rendimento = 10000.5f;

            novoEndPj.logradouro = "Alameda Barão de Limeira";
            novoEndPj.numero = 539;
            novoEndPj.complemento = "SENAI Informática";
            novoEndPj.endComercial = true;

            novaPj.Endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Válido: {(metodosPj.ValidarCnpj(novaPj.Cnpj) ? "Sim" : "Não")}
Endereço: {novaPj.Endereco.logradouro}, Número: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
Imposto a ser pago: {metodosPj.PagarImposto(novaPj.Rendimento).ToString("C")}
");
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            
            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");
            Thread.Sleep(3000);

            BarraCarregamento("Finalizando", 500, 6);

            
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção inválida! Digite uma opção válida!");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }

} while (opcao != "0");


static void BarraCarregamento(string texto, int tempo, int quantidade)
{
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
