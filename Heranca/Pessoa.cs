public class Pessoa
{
    public string Nome;
    public string Endereco;
    public string Genero;
    public string Telefone;
    public float Salario;
    public DateOnly Nascimento;

    public Pessoa()
    {

    }
    public void DefinirNome(string n)
    {
        this.Nome = n;
    }
    public void DefinirEndereco(string e)
    {
        this.Endereco = e;
    }
    public void DefinirGenero(string g)
    {
        this.Genero = g;
    }
    public void DefinirTelefone(string t)
    {
        this.Telefone = t;
    }
    public void DefinirSalario(float s)
    {
        this.Salario = s;
    }
    public void DefinirNascimento(DateOnly n)
    {
        this.Nascimento = n;
    }
    public void ImprimirPessoa()
    {
        Console.WriteLine($"\n\nNome: {this.Nome}");
        Console.WriteLine($"Endereço: {this.Endereco}");
        Console.WriteLine($"Gênero: {this.Genero}");
        Console.WriteLine($"Telefone: {this.Telefone}");
        Console.WriteLine($"Salario: {this.Salario}");
        Console.WriteLine($"Nascimento: {this.Nascimento}");
    }
}
