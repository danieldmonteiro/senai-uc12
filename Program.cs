using senai_uc12.Classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaFisica metodosPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();

novaPf.Nome = "Daniel";
novaPf.dataNasc = new DateTime(2000 , 01 , 01);
novaPf.Cpf = "08680901741";
novaPf.Rendimento = 3500.5f;

novoEndPf.logradouro = "Alameda Barão de Limeira";
novoEndPf.numero = 539;
novoEndPf.complemento = "SENAI Informática";
novoEndPf.endComercial = true;

novaPf.Endereco = novoEndPf;

Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
Maior de Idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}

");

//Console.WriteLine(metodosPf.ValidarDataNasc("01/01/2000"));



//Console.WriteLine(novaPf.Nome);

//Console.WriteLine($"Nome: {novaPf.Nome}");
//Console.WriteLine("Nome: " + novaPf.Nome);


