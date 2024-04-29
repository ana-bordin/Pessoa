string telefoneFixo, telefoneCelular, email;
Pessoa[] pessoas = new Pessoa[3];

Pessoa CriarPessoa()
{
    Pessoa pessoa = new Pessoa();

    pessoa.Nome = pessoa.DefinirNome();
    pessoa.Sobrenome = pessoa.DefinirSobrenome();
    pessoa.Idade = pessoa.DefinirIdade();

    Console.WriteLine("Informe o telefone fixo:");
    telefoneFixo = Console.ReadLine();
    pessoa.DefinirTelefoneFixo(telefoneFixo);

    Console.WriteLine("Informe o telefone celular:");
    telefoneCelular = Console.ReadLine();
    pessoa.DefinirTelefoneCelular(telefoneCelular);

    Console.WriteLine("Informe o email:");
    email = Console.ReadLine();
    pessoa.DefinirEmail(email);

    return pessoa;
}

for (int i = 0; i < 3; i++)
    pessoas[i] = CriarPessoa();

for (int i = 0; i < 3; i++)
    pessoas[i].MostrarDados();