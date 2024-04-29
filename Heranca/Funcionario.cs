using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Funcionario : Pessoa
{

    public int Codigo;
    public string Cargo;

    public Funcionario()
    {
    }

    public void DefinirCodigo(int codigo)
    {
        this.Codigo = codigo;
    }
    public void DefinirCargo (string cargo) 
    { 
        this.Cargo = cargo;
    }
    public void ImprimirCliente()
    {
        ImprimirPessoa();
        Console.WriteLine($"Codigo: {this.Codigo}"); 
        Console.WriteLine($"Cargo: {this.Cargo}");
    }
}