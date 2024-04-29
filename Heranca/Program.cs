Cliente c1 = new Cliente();

Console.WriteLine("Informe o nome do cliente:");
c1.DefinirNome(Console.ReadLine());

Console.WriteLine("Informe o endereço do cliente:");
c1.DefinirEndereco(Console.ReadLine());

Console.WriteLine("Informe o gênero do cliente:");
//c1.DefinirGenero(Console.ReadLine().First()); se fosse char;
c1.DefinirGenero(Console.ReadLine());

Console.WriteLine("Informe o telefone do cliente:");
c1.DefinirTelefone(Console.ReadLine());

Console.WriteLine("Informe o salario do cliente:");
c1.DefinirSalario(float.Parse(Console.ReadLine()));

Console.WriteLine("Informe a data de nascimento do cliente:");
c1.DefinirNascimento(DateOnly.Parse(Console.ReadLine()));

Console.WriteLine("Informe o numero da conta:");
c1.DefinirConta(int.Parse(Console.ReadLine()));

c1.ImprimirCliente();

Funcionario funcionario1 = new Funcionario();

Console.WriteLine("Informe o nome do funcionario:");
funcionario1.DefinirNome(Console.ReadLine());

Console.WriteLine("Informe o endereço do funcionario:");
funcionario1.DefinirEndereco(Console.ReadLine());

funcionario1.DefinirGenero(Console.ReadLine());

Console.WriteLine("Informe o telefone do funcionario:");
funcionario1.DefinirTelefone(Console.ReadLine());

Console.WriteLine("Informe o salario do funcionario:");
funcionario1.DefinirSalario(float.Parse(Console.ReadLine()));

Console.WriteLine("Informe a data de nascimento do funcionario:");
funcionario1.DefinirNascimento(DateOnly.Parse(Console.ReadLine()));

Console.WriteLine("Informe o código do funcionario:");
funcionario1.DefinirCodigo(int.Parse(Console.ReadLine()));

Console.WriteLine("Informe o cargo do funcionario");
funcionario1.DefinirCargo(Console.ReadLine());

funcionario1.ImprimirCliente();