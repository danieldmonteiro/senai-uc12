using senai_uc12.Classes;

Console.Clear();
Console.WriteLine(@$"
=========================================
|  Bem-vindo ao sistema de cadastro de  |
|      Pessoas Físicas e Jurídicas      |
=========================================
");

BarraCarregamento("Ïniciando", 100, 40);

List<PessoaFisica> listaPf = new List<PessoaFisica>();

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

            string? opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=========================================
|     Escolha uma das opções abaixo     |
=========================================
|      1 - Cadastrar Pessoa Física      |
|      2 - Listar Pessoas Físicas       |
|                                       |
|      0 - Voltar ao menu anterior      |
=========================================
");


                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.Clear();
                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
                        novaPf.Nome = Console.ReadLine();

                        bool dataValida;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine($"Digite a data de nascimento. Ex: DD/MM/AAAA");
                            string? dataNascimento = Console.ReadLine();

                            dataValida = metodosPf.ValidarDataNasc(dataNascimento);

                            if (dataValida)
                            {
                                DateTime DataConvertida;
                                DateTime.TryParse(dataNascimento, out DataConvertida);

                                novaPf.dataNasc = DataConvertida;
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada inválida. Por favor, digite uma data válida");
                                Console.ResetColor();
                                Thread.Sleep(3000);

                            }

                        } while (dataValida == false);

                        Console.Clear();
                        Console.WriteLine($"Digite o número do CPF");
                        novaPf.Cpf = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine($"Digite o rendimento mensal (somente números)");
                        novaPf.Rendimento = float.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine($"Digite o logradouro");
                        novoEndPf.logradouro = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine($"Digite o número");
                        novoEndPf.numero = int.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine($"Digite o complemento (aperte ENTER par vazio)");
                        novoEndPf.complemento = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine($"Este endereço é comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPf.endComercial = true;
                        }
                        else
                        {
                            novoEndPf.endComercial = false;
                        }

                        novaPf.Endereco = novoEndPf;

                        listaPf.Add(novaPf);

                        StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt");
                        sw.WriteLine(novaPf.Nome);
                        sw.WriteLine(novaPf.dataNasc);
                        sw.WriteLine(novaPf.Cpf);
                        sw.WriteLine(novaPf.Rendimento);
                        sw.WriteLine(novaPf.Endereco.logradouro);
                        sw.WriteLine(novaPf.Endereco.numero);
                        sw.WriteLine(novaPf.Endereco.complemento);
                        sw.WriteLine(novaPf.Endereco.endComercial);

                        sw.Close();


                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":

                        Console.Clear();

                        //if (listaPf.Count > 0)
                        //{
                        //  foreach (PessoaFisica cadaPessoa in listaPf)
                        //{
                        //  Console.Clear();
                        //Console.WriteLine(@$"
                        //Nome: {cadaPessoa.Nome}
                        //Endereço: {cadaPessoa.Endereco.logradouro}, {cadaPessoa.Endereco.numero}
                        //Imposto a ser pago: {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C")}
                        //");

                        //Console.ForegroundColor = ConsoleColor.DarkRed;
                        //Console.WriteLine("Aperte ENTER para continuar");
                        //Console.ResetColor();
                        //Console.ReadLine();
                        //}
                        //}
                        //else
                        //{
                        //Console.ForegroundColor = ConsoleColor.DarkRed;
                        //Console.WriteLine($"Lista vazia!");
                        //Thread.Sleep(3000);
                        //Console.ResetColor();

                        //}

                        StreamReader sr = new StreamReader("Gabi.txt");

                        string linha;
                        while ((linha = sr.ReadLine()) != null)
                        {
                            Console.WriteLine($"{linha}");
                        }
                        sr.Close();

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Aperte ENTER para continuar");
                        Console.ResetColor();
                        Console.ReadLine();

                        break;

                    case "0":



                        break;

                    default:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção inválida! Digite uma opção válida!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;
                }


            } while (opcaoPf != "0");


            //Console.WriteLine($"Nome: {novaPf.Nome}");
            //Console.WriteLine("Nome: " + novaPf.Nome);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ResetColor();
            Console.ReadLine();

            break;







        case "2":

            string? opcaoPj;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=========================================
|     Escolha uma das opções abaixo     |
=========================================
|    1 - Cadastrar Pessoa Jurídica      |
|    2 - Listar Pessoas Jurídica        |
|                                       |
|    0 - Voltar ao menu anterior        |
=========================================
");

                opcaoPj = Console.ReadLine();
                PessoaJuridica metodosPj = new PessoaJuridica();
                

                switch (opcaoPj)
                {
                    case "1":
                        PessoaJuridica novaPj = new PessoaJuridica();
                       
                        Endereco novoEndPj = new Endereco();
                        
                        Console.Clear();
                        Console.WriteLine($"Digite o nome da pessoa jurídica que deseja cadastrar");
                        novaPj.Nome = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine($"Digite o número do CNPJ");
                        novaPj.Cnpj = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine($"Digite a Razão Social");
                        novaPj.RazaoSocial = Console.ReadLine();

                         metodosPj.Inserir(novaPj);
                         
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":

                        List<PessoaJuridica> listaPj = metodosPj.LerArquivo();

                        foreach (PessoaJuridica cadaItem in listaPj)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
Nome: {cadaItem.Nome}
CNPJ: {cadaItem.Cnpj}
Razão Social: {cadaItem.RazaoSocial}
");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Aperte ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                        }

                        break;

                        //Console.Clear();

                        //StreamReader sr = new StreamReader("Gabi.txt");

                        //string linha;
                        //while ((linha = sr.ReadLine()) != null)
                        //{
                        //Console.WriteLine($"{linha}");
                        //}
                        //sr.Close();

                        //Console.ForegroundColor = ConsoleColor.DarkRed;
                        //Console.WriteLine("Aperte ENTER para continuar");
                        //Console.ResetColor();
                        //Console.ReadLine();

                        //break;

                    case "0":



                        break;

                    default:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção inválida! Digite uma opção válida!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;
                }


            } while (opcaoPj != "0");

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ResetColor();
            Console.ReadLine();

            break;













            
            
            

            //novaPj.Nome = "Nome Pj";
            //novaPj.RazaoSocial = "Razão Social Pj";
            //novaPj.Cnpj = "00000000000100";
            //novaPj.Rendimento = 10000.5f;

            //novoEndPj.logradouro = "Alameda Barão de Limeira";
            //novoEndPj.numero = 539;
            //novoEndPj.complemento = "SENAI Informática";
            //novoEndPj.endComercial = true;

            

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
