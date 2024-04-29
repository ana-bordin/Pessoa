using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pessoa
{
    public string Nome;
    public string Sobrenome;
    public int Idade;
    public string TelefoneFixo;
    public string TelefoneCelular;
    public string Email;

    public Pessoa()
    {
    }
    public string DefinirNome()
    {
        Console.WriteLine("\nInforme o nome desejado:");
        return Console.ReadLine();
    }
    public string DefinirSobrenome()
    {
        Console.WriteLine("Informe o sobrenome:");
        return Console.ReadLine();
    }
    public int DefinirIdade()
    {
        Console.WriteLine("Informe a idade:");
        return int.Parse(Console.ReadLine());
    }
    public void DefinirTelefoneFixo(string telefoneFixo)
    {
        this.TelefoneFixo = telefoneFixo;
    }
    public void DefinirTelefoneCelular(string telefoneCelular)
    {
        TelefoneCelular = telefoneCelular;
    }
    public void DefinirEmail(string email)
    {
        Email = email;
    }
    public void MostrarDados()
    {
        Console.WriteLine($"\n\nNome: {this.Nome}");
        Console.WriteLine($"Sobrenome: {this.Sobrenome}");
        Console.WriteLine($"Idade: {this.Idade}");
        Console.WriteLine($"TelefoneFixo: {this.TelefoneFixo}");
        Console.WriteLine($"TelefoneCelular: {this.TelefoneCelular}");
        Console.WriteLine($"Email: {this.Email}");
    }
}